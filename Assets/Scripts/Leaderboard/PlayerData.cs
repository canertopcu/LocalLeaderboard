﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerData
    {
        public string Name;
        public int Score;

        public PlayerData(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
