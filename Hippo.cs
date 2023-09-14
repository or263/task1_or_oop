using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Hippo : Mammal
    {
        protected int fat;

        public Hippo(string name, int age, bool isToref, int calories, int milkCalories, int pMonths,int fat)
            :base( name,  age,  isToref,  calories,  milkCalories, pMonths)
        {
            this.fat = fat;
        }   

        public int getFat() { return this.fat; }

        public void setFat(int fat) { this.fat = fat;}

        public override string ToString()
        {
            return $"Hippo {name}, fat {fat}\n{base.ToString()}";
        }
    }
}
