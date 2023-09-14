using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Crocodile : Reptile
    {
        protected bool teeth;

        public Crocodile(bool teeth, int tileLen, string name, int age, bool isToref, int calories):
            base(tileLen, name, age, isToref, calories)
        {
            this.teeth = teeth;
        }

        public bool getTeeth() { return this.teeth; }

        public void setTeeth(bool teeth) { this.teeth = teeth; }

        public override string ToString()
        {
            return $"Crocodile {name}, Teeth {teeth}\n{base.ToString()}";
        }
    }
}
