using System;
using System.Collections.Generic;
using System.Text;

namespace bossfights {
    class Fight {
        Player player;
        Boss boss;
        int turn = 1;
        int level;

        /// <summary>
        /// 按照关数来生成一场战斗
        /// </summary>
        /// <param name="level"></param>
        public Fight(int level, Player player) {
            this.level = level;
            this.player = player;
            this.boss = new Boss();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("野生的{0}出现了", this.boss.Name);
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("第{0}关第{1}回合", this.level, this.turn);
            Console.WriteLine("BOSS:{0}", this.boss.Name);
            Console.WriteLine(this.boss.Name + ":");
            this.boss.SayFlag();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            this.Turn();
        }


        /// <summary>
        /// 回合开始
        /// </summary>
        public void Turn() {
            this.PrintInfo();
            if(this.FristHead()) {
                player.choose(boss);
                Console.WriteLine("------------------------------------------------------------------------------------------");
                if (this.GetResult()) {
                    boss.AI(player);
                    this.Turn();
                }
            } else {
                boss.AI(player);
                Console.WriteLine("------------------------------------------------------------------------------------------");
                if (this.GetResult()) {
                    player.choose(boss);
                    this.Turn();
                }
            }
        }

        /// <summary>
        /// 确定行动顺序
        /// </summary>
        /// <param name="player"></param>
        /// <param name="boss"></param>
        /// <returns>TRUE玩家先手FALSEboss先手</returns>
        public bool FristHead() {
            return this.player.SPD > this.boss.SPD;
        }

        
        /// <summary>
        /// 显示战斗状况
        /// </summary>
        public void PrintInfo() {
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine(this.boss.Name);
            Console.WriteLine("血量：{0}", this.boss.HP);
            Console.WriteLine("攻击：{0} | 防御{1} | 速度{2}", this.boss.ATK, this.boss.DEF, this.boss.SPD);
            Console.WriteLine("技能：");
            Console.WriteLine("状态：");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine(this.player.Name);
            Console.WriteLine("血量：{0}", this.player.HP);
            Console.WriteLine("攻击：{0} | 防御{1} | 速度{2}", this.player.ATK, this.player.DEF, this.player.SPD);
            Console.WriteLine("技能：");
            Console.WriteLine("状态：");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

        //结算战斗状态
        public bool GetResult() {
            if (this.player.HP <= 0) {
                Console.WriteLine("you lose");
                return false;
            } else if  (this.boss.HP <= 0) {
                Console.WriteLine("you win");
                return false;
            }
            return true;
        }

    }
}
