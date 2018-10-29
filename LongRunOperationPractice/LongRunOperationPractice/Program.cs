using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LongRunOperationPractice
{
    class Program
    {
        public static async void Main(string[] args)
        {
            Console.WriteLine("Calling ...");

            var mystring = await DoItAsync();

            Console.WriteLine(mystring);
            Console.ReadLine();
        }

        private async static Task<string> DoItAsync()
        {
            var httpClient = new HttpClient();
            var message = await httpClient.GetAsync("http:/devu.com");
            var content = await message.Content.ReadAsStringAsync();

            return content;
        }
    }
}
