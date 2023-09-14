using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Park
    {
        protected Animal[] Animals;
        protected int AnimalsInPark;

        public Park()
        {
            this.Animals = new Animal[1000];
            this.AnimalsInPark = 0;
        }

        public void AddToPark(Animal a)
        {
            if (this.AnimalsInPark < 1001)
                this.Animals[this.AnimalsInPark] = a;
        }

        public Animal[] TorefAndOderThanTen()
        {
            Animal[] arr = new Animal[1000];
            int filled = 0;
            for (int i = 0; i < this.Animals.Length; i++)
            {
                if (this.Animals[i].getAge() > 10 && this.Animals[i].getIsToref())
                {
                    arr[filled] = this.Animals[i];
                    filled++;
                }
            }
            return arr;
        }

        public Animal[] TorefAndReptileOrBird()
        {
            Animal[] arr = new Animal[1000];
            int filled = 0;
            for (int i = 0; i < this.Animals.Length; i++)
            {
                if (this.Animals[i].getIsToref())
                {
                    if (this.Animals[i] is Bird || this.Animals[i] is Reptile)
                    {
                        arr[filled] = this.Animals[i];
                        filled++;
                    }
                }
            }
            return arr;
        }

    }
}
