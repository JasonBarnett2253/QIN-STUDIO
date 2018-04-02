using System;
using System.Collections.Generic;
using System.Text;

namespace bossfights {
    class Boss: Actor {
        public string Flag;

        public Boss() {
            this.Name = "渣渣灰";
            this.Flag = "大扎好，我系渣渣辉，探挽懒月，介四里没有挽过的船新版本，挤需体验三番钟，里造会干我";
            this.HP = 50;
            this.ATK = 5;
            this.DEF = 5;
            this.SPD = 6;
            this.Skills = new int[0];
        }
        public void SayFlag() {
            Console.WriteLine(this.Flag);
        }

        public void AI(Actor aims) {
            this.Attack(aims);
        }
    }
}
