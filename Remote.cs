﻿using System;
using System.Timers;


namespace DogDoors
{
    public class Remote
    {
        private readonly DogDoor _door;

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (_door.IsOpen())
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
            
            var timer = new Timer(5000);
            timer.Elapsed += delegate
            {
                _door.Close();
                timer.Enabled = false;
            };
            timer.Enabled = true;
        }

        
    }
}