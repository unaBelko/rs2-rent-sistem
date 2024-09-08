using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace rs2_rent_sistem.Subscriber
{
    public class NotificationEmailConsumer
    {
        private readonly IModel _channel;
        private readonly EmailService _emailService;

        public NotificationEmailConsumer(EmailService emailService)
        {

            _emailService = emailService;
            Console.WriteLine("RABBITMQ_HOST: " + Environment.GetEnvironmentVariable("RABBITMQ_HOST"));

            var factory = new ConnectionFactory
            {
                HostName = Environment.GetEnvironmentVariable("RABBITMQ_HOST"),
                UserName = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME"),
                Password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD"),
                VirtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST")
            };
            var connection = factory.CreateConnection();
            _channel = connection.CreateModel();
        }

        public void SendEmail()
        {
            var queueName = Environment.GetEnvironmentVariable("RABBITMQ_QUEUENAME");
            _channel.QueueDeclare(queue: queueName,
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(" [x] Received {0}", message);
                var email = ExtractEmailFromMessage(message);
                if (!string.IsNullOrEmpty(email))
                {
                    _emailService.SendEmail(email, "Your reservation has been successfully created.");
                }
            };
            _channel.BasicConsume(queue: queueName,
                                  autoAck: true,
                                  consumer: consumer);
        }

        private string ExtractEmailFromMessage(string message)
        {
            var parts = message.Split(' ');
            return parts.Length > 3 ? parts[3] : string.Empty;
        }
    }
}
