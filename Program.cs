using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals =
            {
                new Cow("bbb", 15, false, 1500, 450, 12, 5),
                new Cow("bbc",17,false,2100,830,12,2),
                new Hippo("ppp", 4, true, 3300, 230, 12, 37),
                new Hippo("hhh", 7, true, 3500, 290, 12, 32),
                new Cow("ccc", 10, false, 1800, 520, 12, 0),
            };

            Reptile[] reptiles =
            {
                new Snake(true, 10, "sss", 4, true, 620),
                new Crocodile(true, 30, "crr", 6, true, 700),
                new Kobra("black", true, 13, "kkk", 3, true, 640),
                new Snake(true, 8, "ssn", 2, true, 580),
                new Crocodile(true, 24, "crr", 4, true, 640),
            };

            Animal[] animals =
            {
                new Snake(true, 10, "sss", 4, true, 620),
                new Crocodile(true, 30, "crr", 6, true, 700),
                new Kobra("black", true, 13, "kkk", 3, true, 640),
                new Hippo("hhh", 7, true, 3500, 290, 12, 32),
                new Cow("ccc", 10, false, 1800, 520, 12, 0),
                new Animal("aaa", 9, false, 350),
                new Bird(700, 30, "brr", 4, false, 220),
                new Crow(3, 800, 35, "cro", 6, true, 280),

            };

            foreach (var item in mammals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in reptiles)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

        }

        public static int AllCalories(Animal[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = count + arr[i].Eat();
            }
            return count;
        }

        public static int MammalsAmount(Animal[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Mammal)
                    count++;
            }
            return count;
        }

        public static void TimeToDanceForBirdsAndSnakes(Animal[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Snake)
                    (arr[i] as Snake).Dance();
                if (arr[i] is Bird)
                    ((Bird)arr[i]).Dance();
            }
        }

        public static string FatHippo(Animal[] arr)
        {
            int mostFat = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hippo)
                {
                    if (((Hippo)arr[i]).getFat() > mostFat)
                    {
                        mostFat = ((Hippo)arr[i]).getFat();
                        index = i;
                    }

                }
            }
            return (arr[index]).getName();
        }
    }
}
