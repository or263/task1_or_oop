using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Snake : Reptile
    {
        protected bool venom;

        public Snake(bool venom, int tileLen, string name, int age, bool isToref, int calories) :
            base(tileLen, name, age, isToref, calories)
        {
            this.venom = venom;
        }

        public bool getVenom() { return this.venom; }

        public void setVenom(bool venom) { this.venom = venom; }

        public override string ToString()
        {
            return $"Snake {name}, Venom {venom}\n{base.ToString()}";
        }

        public string Dance() { return "Yay Im dancing!! ☺☺♦♦"; }
    }
}
