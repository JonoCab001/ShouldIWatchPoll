using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShouldIWatchPoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool favActor = true;
            bool favDrama = false;

            bool shouldIWatchDecision = (favActor || favDrama);

            if (shouldIWatchDecision)
            {
                Console.WriteLine("I'll definitely watch this one! :)");
            }
            else
            {
                Console.WriteLine("Nah, I'll skip it...");
            }

            Console.ReadKey();
        }
    }
}
