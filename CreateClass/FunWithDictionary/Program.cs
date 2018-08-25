using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string> {
                { "txt", "notepad.exe" },
                { "bmp", "paint.exe" }
            };

            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            try
            {
                openWith.Add("txt", "kew is already in use...");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("txt key already exist...");
            }

            Console.WriteLine($"Lets see, what's in the dict under the bmp key: {openWith["bmp"]}");

            openWith["dib"] = "dibEditor.exe";
            openWith["doc"] = "winword.exe";
            Console.WriteLine($"Modified dib: {openWith["dib"]}");
            Console.WriteLine($"Winword added: {openWith["doc"]}");

            Console.WriteLine($"Try existing value: {openWith.TryGetValue("dib", out string existingValue)}");
            Console.WriteLine($"Try not existing value: {openWith.TryGetValue("not", out string notExistingValue)}");
            Console.WriteLine(existingValue);
            Console.WriteLine(notExistingValue);

            Console.WriteLine($"Try existing key: {openWith.ContainsKey("dib")}");
            Console.WriteLine($"Try not existing key: {openWith.ContainsKey("dib not")}");

            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

            foreach (var key in keyColl)
            {
                Console.WriteLine(key);
            }

            Dictionary<string, string>.ValueCollection valColl = openWith.Values;
            foreach (var value in valColl)
            {
                Console.WriteLine(value);
            }

            openWith.Remove("doc");
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            foreach (var item in openWith.OrderBy(i => i.Key))
            {
                Console.WriteLine(item);
            }
        }
    }
}
