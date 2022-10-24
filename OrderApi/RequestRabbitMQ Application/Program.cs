using RabbitMQ.Client;
using System;

namespace RequestRabbitMQ_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "futurepast1977";

            string Password = "redmondmicrosot123";

            string HostName = "localhost";



            //Main entry point to the RabbitMQ .NET AMQP client

            var connectionFactory = new RabbitMQ.Client.ConnectionFactory()

            {

                UserName = UserName,

                Password = Password,

                HostName = HostName

            };



            var connection = connectionFactory.CreateConnection();

            var model = connection.CreateModel();

            Console.WriteLine("Creating Exchange");

            // Create Exchange

            model.ExchangeDeclare("demoExchange", ExchangeType.Direct);

            Console.ReadLine();

        }

    }
}
