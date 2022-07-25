﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy.Behaviour.Fly
{
    public class FlyRocketPowered : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly with rocket power...");
        }
    }
}
