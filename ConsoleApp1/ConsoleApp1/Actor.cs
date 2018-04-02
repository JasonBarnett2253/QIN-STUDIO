using System;
using System.Collections.Generic;
using System.Text;

namespace bossfights {
    class Actor {
        public string Name;
        public int HP;
        public int ATK;
        public int DEF;
        public int SPD;
        public int[] Skills;

        //攻击
        public void Attack(Actor aims) {
            //判定攻击
            int hurt = (this.ATK * this.ATK) / (this.ATK + aims.DEF) * 2;
            Random ran = new Random();
            int n = ran.Next(-(hurt/5), 1000);
            aims.HP = aims.HP - hurt;
        }

        //防御
        public void Defense(Actor aims) {
            //设定防御状态
            aims.DEF = aims.DEF * 2;
        }

        //使用技能
        public void Use(Actor aims, int id) {

        }
    }
}
