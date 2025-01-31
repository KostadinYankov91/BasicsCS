﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Rebel : IRebel, IAge
    {
        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public string Name { get; private set; }

        public string Group { get; private set; }

        public int Food { get; private set; }

        public string Age { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
