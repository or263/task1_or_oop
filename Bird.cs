using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Bird : Animal
    {
        protected int flyHeight;
        protected int wingsLen;

        public Bird(int flyHeight, int wingsLen, string name, int age, bool isToref, int calories) :
            base(name, age, isToref, calories)
        {
            this.flyHeight = flyHeight;
            this.wingsLen = wingsLen;
        }

        public int getFlyHeight() { return this.flyHeight; }
        public int getWingsLen() { return this.wingsLen; }

        public void setFlyHeight(int flyHeight) { this.flyHeight = flyHeight; }
        public void setWings(int wingsLen) { this.wingsLen = wingsLen; }

        public override string ToString()
        {
            return $"Bird {name}, FlyHeight {flyHeight}, WingsLen {wingsLen} \n{base.ToString()}";
        }

        public string Sing() { return " kwik tzwitz kwik kwik tzwitz"; }

        public string Dance() { return "Yay Im dancing!! ☺☺♦♦"; }
    }
}
