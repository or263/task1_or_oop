using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1_or
{
    internal class Crow : Bird
    {
        protected int eggs;

        public Crow(int eggs, int flyHeight, int wingsLen, string name, int age, bool isToref, int calories) :
            base(flyHeight, wingsLen, name, age, isToref, calories)
        {
            this.eggs = eggs;
        }

        public int getEggs() { return eggs; }

        public void setEggs(int eggs) { this.eggs = eggs; }

        public override string ToString()
        {
            return $"Crow {name}, Eggs {eggs} \n{base.ToString()}";
        }
    }
}
