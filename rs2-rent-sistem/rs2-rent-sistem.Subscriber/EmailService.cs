using DotNetEnv;
using MailKit.Net.Smtp;
using MimeKit;

public class EmailService
{
    public EmailService()
    {
        // Load environment variables from .env file
        Env.Load();
    }

    public void SendEmail(string recipientEmail, string message)
    {
        var emailMessage = new MimeMessage();

        var fromEmail = Environment.GetEnvironmentVariable("FromEmail");

        emailMessage.From.Add(new MailboxAddress("eRent Notification Service", fromEmail));
        emailMessage.To.Add(new MailboxAddress("Customer", recipientEmail));
        emailMessage.Subject = "New Reservation Added";
        emailMessage.Body = new TextPart("plain")
        {
            Text = message
        };

        using var client = new SmtpClient();
        try
        {
            var smtpServer = Environment.GetEnvironmentVariable("SmtpServer");
            var smtpPort = int.Parse(Environment.GetEnvironmentVariable("SmtpPort"));
            var smtpUser = Environment.GetEnvironmentVariable("SmtpUser");
            var smtpPass = Environment.GetEnvironmentVariable("SmtpPass");

            client.Connect(smtpServer, smtpPort, false);
            client.Authenticate(smtpUser, smtpPass);
            client.Send(emailMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while sending email to {recipientEmail}: {ex.Message}");
        }
        finally
        {
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
