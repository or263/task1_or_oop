using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Mammal : Animal
    {
        protected int milkCalories;
        protected int pMonths;

        public Mammal(string name, int age, bool isToref, int calories, int milkCalories, int pMonths)
            : base(name, age, isToref, calories)
        {
            this.milkCalories = milkCalories;
            this.pMonths = pMonths;
        }

        public int getMilkCalories() { return this.milkCalories; }
        public int getPMonths() { return this.pMonths; }

        public void setMilkCalories(int milkCaloris) { this.milkCalories = milkCaloris; }
        public void setPMonths(int pMonths) { this.pMonths = pMonths; }

        public override string ToString()
        {
            return $"Mammal {name}, milkCalories {milkCalories}, pMonths{pMonths} \n{base.ToString()}";
        }

        public new int Eat() { return base.Eat() + this.milkCalories; }
    }
}
