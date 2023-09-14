using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Kobra : Snake
    {
        protected string color;

        public Kobra (string color, bool venom, int tileLen, string name, int age, bool isToref, int calories):
            base(venom, tileLen, name, age, isToref, calories)
        {
            this.color = color;
        }

        public string getColor() { return this.color; }

        public void setColor(string color) { this.color = color;}

        public override string ToString()
        {
            return $"Kobra {name}, Color {color} \n{base.ToString()}";
        }
    }
}
