using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool isToref;
        protected int calories;

        public Animal(string name, int age, bool isToref, int calories)
        {
            this.name = name;
            this.age = age;
            this.isToref = isToref;
            this.calories = calories;
        }

        public string getName() { return this.name; }
        public int getAge() { return this.age; }
        public bool getIsToref() { return this.isToref; }
        public int getCalories() { return this.calories; }

        public void setName(string name) { name = this.name; }
        public void setAge(int age) { age = this.age; }
        public void setIsToref(bool isToref) { isToref = this.isToref; }
        public void setCalories(int calories) { calories = this.calories; }

        public override string ToString()
        {
            return $"Name {name}, Age {age}, isToref {isToref}, Calories{calories}";
        }

        public int Eat() { return (this.calories) * 3; }

    }
}
