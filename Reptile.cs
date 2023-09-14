using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Reptile : Animal
    {
        protected int tileLen;

        public Reptile(int tileLen, string name, int age, bool isToref, int calories):
            base(name, age, isToref, calories)
        {
            this.tileLen = tileLen;
        }

        public int getTileLen () { return this.tileLen; }
        
        public void setTileLen (int tileLen) {  this.tileLen = tileLen; }

        public override string ToString()
        {
            return $"Reptile {name}, tileLen {tileLen}\n{base.ToString()}";
        }
    }
}
