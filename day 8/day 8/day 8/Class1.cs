using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8
{
    public class Game
    {

        public int energyLevel = 1;
        public int winningProb = 100;

        public void zeroSpin() { this.energyLevel = 1; this.winningProb = 100; }

        public void fisrtSpin()
        {
            this.energyLevel += 1;
            this.winningProb += 10;
        }

        public void SecondSpin() { this.energyLevel += 2; this.winningProb = +20;}
        public void ThirdSpin() { this.energyLevel -= 3; this.winningProb -= 30; }
        public void FourthSpin() { this.energyLevel += 4; this.winningProb += 40; }
        public void FifthSpin() { this.energyLevel -= 5; this.winningProb -= 50; }
        public void SixthSpin() { this.energyLevel -= 1; this.winningProb -= 60; }
        public void SeventhSpin() { this.energyLevel += 2; this.winningProb -= 70; }
        public void EighthSpin() { this.energyLevel -= 2; this.winningProb -= 20; }
        public void NinthSpin() { this.energyLevel -= 3; this.winningProb -= 30; }
        public void TenthSpin() { this.energyLevel += 10; this.winningProb += 100; }
    }
}
