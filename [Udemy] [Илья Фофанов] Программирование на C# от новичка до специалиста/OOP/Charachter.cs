﻿using System;

namespace OOP
{

    public class Point2D
    {
        private int x;
        private int y;
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
    }
    public class Charachter 
    {
        private static int speed = 10;
        public int PrintSpeed()
        {
            /*Console.WriteLine($"speed = {speed}");*/
            return speed;
        }
        public void IncreaceSpeed()
        {
            Console.WriteLine($"speed = {speed}");
        }
        public int Health { get; private set; } = 100;
        public string Race { get; private set; }
        public int Armor { get; private set; }
        public Charachter(string race, int armor = 30)
        {
            Race = race;
            Armor = armor;
        }
       
        public void Hit(int demage)
        {
            if (demage > Health)
                demage = Health;
            Health -= demage;
            Console.WriteLine(Health);
        }
    }
}