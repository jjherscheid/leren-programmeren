using System;
using System.Collections.Generic;

namespace Honden
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckel teckel = new Teckel();
            Herdershond herdershond = new Herdershond();

            List<Hond> huis1Honden = new List<Hond>()
            {
                teckel,
                herdershond
            };

            Huis huis1 = new Huis(huis1Honden);
            huis1.Aanbellen();
        }
    }

    class Huis
    {
        List<Hond> honden;

        public Huis(List<Hond> honden)
        {
            Console.WriteLine("Huis gemaakt");
            this.honden = honden;
        }

        public void Aanbellen()
        {
            foreach(Hond hond in this.honden)
            {
                hond.Blaf();
            }
        }
    }

    class Hond
    {
        public virtual void Blaf() { }
    }

    class Teckel : Hond
    {
        public override void Blaf()
        {
            Console.WriteLine("kef kef");
        }
    }

    class Herdershond : Hond
    {
        public override void Blaf()
        {
            Console.WriteLine("WOEF");
        }
    }
}
