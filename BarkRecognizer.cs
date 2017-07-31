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

        public void Recognize(BarkSample newBark)
        {
            Console.WriteLine($"     BarkRecognizer: heard a '{newBark.Sample}'");
            var allowedBarks = _door.AllowedBarks;
            foreach (var bark in allowedBarks)
            {
                if (bark.Equals(newBark))
                {
                    _door.Open();
                    return;
                }
                Console.WriteLine("This dog is not allowed...");
            }
        }
    }
}