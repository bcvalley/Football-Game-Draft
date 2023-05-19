using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football2
{
    internal class Player : Person
    {
        public int Number { get; set; }
        public int Hight { get; set; }
        public Player(string name,int age,int number, int hight):base(name,age)
        {
            Number = number;
            Hight = hight;
        }
    }
}
