using DotNetEnv;
using Microsoft.Extensions.Configuration;
using rs2_rent_sistem.Subscriber;

class Program
{
    static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables();

        var configuration = builder.Build();
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
        Env.Load("../../../../.env");

        var emailService = new EmailService();

        var reservationEmailConsumer = new NotificationEmailConsumer(emailService);
        reservationEmailConsumer.SendEmail();
        Console.WriteLine("Reservation Email Consumer started");
        Thread.Sleep(Timeout.Infinite);
    }
}