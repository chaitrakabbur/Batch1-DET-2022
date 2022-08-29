using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Program4
    {
        public static void Main4()
        {

            List<Animal> sound = new List<Animal>();
            sound.Add(new Dog() );
            sound.Add(new Cat() );
           // list.Add(new Frog { Age = 4, Name = "Shino", Gender = "Male" });
            foreach (Animal a in sound)
            
                Console.WriteLine(a.sound());

            

        }

    }
}
