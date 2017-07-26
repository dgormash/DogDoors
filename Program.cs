using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoors
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = new DogDoor();
            var remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            remote.PressButton();
            Console.WriteLine("Fido's all done...");
            remote.PressButton();
            Console.WriteLine("Fido's back inside...");
            remote.PressButton();
            Console.ReadKey();
        }
    }
}
