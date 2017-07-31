using System;

namespace DogDoors
{
    public class BarkRecognizer
    {
        readonly DogDoor _door;

        public BarkRecognizer(DogDoor door)
        {
            _door = door;
        }

        public void Recognize(string bark)
        {
            Console.WriteLine($"     BarkRecognizer: heard a '{bark}'");
            _door.Open();
        }
    }
}