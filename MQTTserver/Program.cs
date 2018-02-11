using MQTTnet;
using MQTTnet.Server;
using System;
using System.Threading.Tasks;

namespace MQTTserver
{
    public class Util
    {
        /// <summary>
        /// Adds two Numbers. Unit test this! 
        /// </summary>
        /// <returns>Summ of A and B</returns>
        public static int TestMeIAddNumbers(int A, int B)
        {
            return A + B;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server Started!");
            Task.Run(async () => await StartServer()).Wait();
        }

        private static async Task StartServer()
        {
            var optionsBuilder = new MqttServerOptionsBuilder()
                .WithConnectionBacklog(100)
                .WithDefaultEndpointPort(1883);

            var mqttServer = new MqttFactory().CreateMqttServer();
            await mqttServer.StartAsync(optionsBuilder.Build());
            Console.WriteLine("Type 'quit' to exit");
            while (true)
            {
                if (Console.ReadLine().Contains("quit"))
                    break; 
            }
            await mqttServer.StopAsync();
        }
    }
}
