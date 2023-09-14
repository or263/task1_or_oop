using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Cow : Mammal
    {
        protected int birthNum;

        public Cow(string name, int age, bool isToref, int calories, int milkCalories, int pMonths, int birthNum) :
            base(name, age, isToref, calories, milkCalories, pMonths)
        {
            this.birthNum = birthNum;
        }

        public int getBirthNum() { return birthNum; }

        public void setBirthNum(int birthNum) { this.birthNum = birthNum; }

        public override string ToString()
        {
            return $"Cow {name}, birthNum {birthNum}\n{base.ToString()}";
        }

        public new int Eat() { return (base.Eat()) / 4; }
    }
}
