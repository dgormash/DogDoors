using System;

namespace DogDoors
{
    public class DogDoor
    {
        bool _open;

        public DogDoor()
        {
            _open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            _open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            _open = false;
        }

        public bool IsOpen()
        {
            return _open ;
    }
    }
}