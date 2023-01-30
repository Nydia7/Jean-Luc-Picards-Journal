using System;
using System.IO;

namespace CaptainJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'start' to start writing in Captain's Journal and 'stop' to end writing.");
            string input = Console.ReadLine();
            string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string content = "";

            if (input == "start")
            {
                Console.WriteLine("Start writing in the journal:");
                input = Console.ReadLine();
                while (input != "stop")
                {
                    content += input + "\n";
                    input = Console.ReadLine();
                }

                content = "Captain's log\nStardate " + DateTime.Now.ToString("yyyy-MM-dd") + "\n" + content + "Jean-Luc Picard";
                File.WriteAllText(fileName, content);
                Console.WriteLine("Journal saved as " + fileName);
            }
            else
            {
                Console.WriteLine("Invalid command. Writing in the journal is stopped.");
            }
        }
    }
}