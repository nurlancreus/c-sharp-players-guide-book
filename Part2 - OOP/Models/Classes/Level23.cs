﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___OOP.Models.Classes
{

    public class Asteroid
    {
        public float PositionX { get; private set; }
        public float PositionY { get; private set; }
        public float VelocityX { get; private set; }
        public float VelocityY { get; private set; }

        public Asteroid(float positionX, float positionY,
        float velocityX, float velocityY)
        {
            PositionX = positionX;
            PositionY = positionY;
            VelocityX = velocityX;
            VelocityY = velocityY;
        }
        public void Update()
        {
            PositionX += VelocityX;
            PositionY += VelocityY;
        }

        public void DisplayPosition()
        {
            Console.WriteLine($"({PositionX}, {PositionY})");
        }
    }
    public class AsteroidsGame
    {
        private Asteroid[] _asteroids;
        public AsteroidsGame()
        {
            _asteroids = new Asteroid[5];
            _asteroids[0] = new Asteroid(100, 200, -4, -2);
            _asteroids[1] = new Asteroid(-50, 100, -1, +3);
            _asteroids[2] = new Asteroid(0, 0, 2, 1);
            _asteroids[3] = new Asteroid(400, -100, -3, -1);
            _asteroids[4] = new Asteroid(200, -300, 0, 3);
        }
        public void Run()
        {
            while (true)
            {
                int count = 0;
                foreach (Asteroid asteroid in _asteroids)
                {
                    Console.Write(++count + ". ");
                    asteroid.DisplayPosition();
                    asteroid.Update();
                    Console.Write("Updated: ");
                    asteroid.DisplayPosition();
                    Console.WriteLine("");
                }
                break;
            }
        }
    }
}
