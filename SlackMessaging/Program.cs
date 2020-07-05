using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackBotMessages;

namespace SlackMessaging
{
    class Progrma
    {
        static void Main(string[] args)
        {
            SBMClient client = new SBMClient("https://hooks.slack.com/services/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");
            Message msg = new Message(text:"Hello from my first app", channel:"general", username:"vhoagamo6", icon_emoji:":poop:");

            client.Send(msg);
            Console.WriteLine("Your message is sent!");
            Console.ReadLine();
        }
    }
}
