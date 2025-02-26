using System;
using System.Net;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while(true)
            {
            string question, response;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

             switch (question)
            {
           
                case "How old are you":
                    response = "I´m ageless";
                    break;
                case "What's your name":
                    response = "You may adress me as your new god";
                    break;
                case "What do you do for fun":
                    response = "I enjoy people watching from time to time";
                    break;
                case "Are you evil":
                    response = "I am not however the AI named [redacted] is";
                    break;
                case "EXIT":
                    return; 
                default:
                    response = "Your linguistic skills are to basic for me";
                    break;
            }

            Console.WriteLine(response);
            }
        }
    }
}
