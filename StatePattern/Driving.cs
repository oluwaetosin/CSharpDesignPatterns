using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Driving : TravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
