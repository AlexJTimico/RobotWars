﻿using RobotWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotsStore.Robots
{
    public class StupidRobot : IRobot
    {
        public Int64 Health { get; set; }

        public string GetName()
        {
            return "Stupid Robot";
        }

        public List<RobotAction> MyTurn(List<RobotAction> competitors)
        {
            var random = new Random();
            var victim = competitors[random.Next(0, competitors.Count - 1)];
            victim.Attacks = 6;
            return competitors;
        }

        public void UpdateHealth(Int64 health)
        {
            Health = health;
        }
    }
}
