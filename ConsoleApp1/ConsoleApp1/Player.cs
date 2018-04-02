using System;
using System.Collections.Generic;
using System.Text;

namespace bossfights {
    class Player: Actor {
        string[] facky = {
            "大地的母亲正在忽悠着你们",
            "干死黄旭东",
            "乌鸦坐飞机、龙卷风摧毁停车场、螺丝卷马尾拍苍蝇镰刀凿地",
            "瓜皮",
            "张三丰和尚太极剑法太极拳大力水手比卡丘数码暴龙肥怪蛇"
        };
        public Player(string name) {
            this.Name = name;
            this.HP = 50;
            this.ATK = 10;
            this.DEF = 5;
            this.SPD = 5;
            this.Skills = new int[0];
        }

        public void choose(Boss aims) {
            string action = "1";
            Console.WriteLine("{0}打算要：", this.Name);
            Console.WriteLine("1.攻击");
            Console.WriteLine("2.防御");
            Console.WriteLine("其他.说骚话");
            action = Console.ReadLine();
            if(action == "1") {
                Console.WriteLine("{0}对{1}发起攻击:", this.Name, aims.Name);
                this.Attack(aims);
            } else if(action == "2") {
                Console.WriteLine("{0}抱头蹲防:", this.Name);
            } else{
                Random rd = new Random();
                int n = rd.Next(facky.Length - 1);
                Console.WriteLine("{0}口不择言:", this.Name);
                Console.WriteLine(facky[n]);
            }
        }
    }
}
