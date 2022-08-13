using ServiceReference1;
using System;

namespace ProxyDeseni
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string isim = await client.nameAsync("Mustafa");
            Console.WriteLine("Ismim : " + isim);
            await client.CloseAsync();

            Console.ReadKey();

        }
    }
}
