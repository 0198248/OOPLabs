using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Difficulty
    {
        public int alienSpawnRate;
        public int alienHP;
        public short alienMoveSpeed;
        public int scorePerAlien;
        public int diffChance;
        private int diffLevel;
        public short alienDamage;
        randomizer rand;

        public void SetNormalDifficulty()
        {
            alienSpawnRate = 400;
            alienHP = 4;
            alienMoveSpeed = 6;
            scorePerAlien = 10;
            diffChance = 500;
            diffLevel = 1;
            alienDamage = 2;
        }
        public Difficulty(randomizer Rand)
        {
            SetNormalDifficulty();
            rand = Rand;
        }
        public void DifficultyTick() 
        {
            if (diffLevel < 14)
            {
                if (rand.createNum(diffChance) == diffChance)
                {
                    alienSpawnRate += 150;
                    alienHP += 1;
                    alienMoveSpeed += 1;
                    scorePerAlien += 5;
                    diffChance = (int)(diffChance * 1.25);
                    alienDamage += 2;
                    diffLevel++;
                }
            }
        }
    }
}
