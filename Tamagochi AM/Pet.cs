using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_AM
{
    public abstract class Pet
    {
        //public int Hunger
        //{
        //  get; private set;
        //} = 50;
        private int hunger = 50;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set 
            {
                hunger = value;
                if (!IsAlive())
                {
                    throw new DeadPetException();
                }
            }
        }
        private Random random = new Random();
        public int Do()
        {
            var toss = random.Next(1,20);
            if (toss < 10) 
            {
                Chill();
            }
            else if (toss < 16)
            {
                Play();
            }
            else
            {
                Feed();
            }
            return toss;
        }
        public int Boredom
        {
            get; private set;
        } = 50;
        public bool IsAlive()
        {
            if (Hunger > 100 || Hunger < 0)
            {
                return false;
            }
            return true;
        }
        public void Feed()
        {
            Hunger -= 15; Boredom += 5;
            Console.WriteLine("Papá..");
        }
        public void Play()
        {
            Hunger += 20; Boredom -= 25;
            Console.WriteLine("Hraje si..");
        }
        public void Chill()
        {
            Hunger += 10; Boredom += 10;
            Console.WriteLine("Odpočívá..");
        }
        public virtual string WhoAmI()
        {
            return "Pes";
        }
        
    }
}