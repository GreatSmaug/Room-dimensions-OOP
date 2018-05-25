using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_dimensions__OOP_
{
    public class test
    {
        // Constructor
        public test() => Length = 0;

        // Constructor taking an argument
        public test(float length)
        {
            Length = length;
        }

        public float Length { get; }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }

    public class Testroom
    {
        static void Main()
        {
            var room1 = new Room();
            Console.WriteLine(room1.Length);

            var room2 = new Room(12);
            Console.WriteLine(room2.Length);
        }

    }

    }
}
