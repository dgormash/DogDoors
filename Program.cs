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
            var barkRpcognizer = new BarkRecognizer(door);
            Console.WriteLine("Fido starts barking...");
            barkRpcognizer.Recognize("Woof");
            Console.WriteLine("Fido barks to go outside...");
            //remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            Console.WriteLine("Fido's all done...");
            //if (!door.IsOpen())
            //{
            //    Console.WriteLine("Fido barks to go inside...");
            //    remote.PressButton();
            //}
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Fido stuck outside...");
            Console.WriteLine("Fido starts barking...");
            barkRpcognizer.Recognize("Woof");
            //Console.WriteLine("... so Gina grabs the remote control...");
            //remote.PressButton();
            Console.WriteLine("Fido's back inside...");
            Console.ReadKey();
        }
    }
}
