using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagotchi
{
  
    public class Dog
    {
        private int energyCurrent = 0;
        private int energyMax = 0;
        private int hungryCurrent = 0;
        private int hungryMax = 0;
        private int happyCurrent = 0;
        private int happyMax = 0;

        public Dog()
        {
            energyMax = energyCurrent = 100;
            hungryMax = hungryCurrent = 0;
            happyMax = happyCurrent = 100;
        }
        public int getEnergy()
        {  
            return energyCurrent; 
        }
        public void increaseEnergy(int value)
        {
         if(energyCurrent + value < energyMax) 
            energyCurrent = energyMax;
         else  energyCurrent += value;
        }
        public void decreaseEnergy(int value)
        {
            if (energyCurrent - value < 0)
                energyCurrent = 0;
            else energyCurrent -= value;
        }
        public int getHungry()
        {
            return hungryCurrent;
        }
        public void increaseHungry(int value)
        {
            if (hungryCurrent + value < hungryMax)
                hungryCurrent = hungryMax;
            else hungryCurrent += value;
        }
        public void decreaseHungry(int value)
        {
            if (hungryCurrent - value < 0)
                hungryCurrent = 0;
            else hungryCurrent -= value;
        }
        public int getHappy()
        {
            return happyCurrent;
        }
        public void increaseHappy(int value)
        {
            if (happyCurrent + value < happyMax)
                happyCurrent = happyMax;
            else happyCurrent += value;
        }
        public void decreaseHappy(int value)
        {
            if (happyCurrent - value < 0)
                happyCurrent = 0;
            else happyCurrent -= value;
        }
    }
}
