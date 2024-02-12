using System;

namespace task3_2
{
    class LVL2: ParentClass
    {
        private int[,] array;

        private int a;
        private int b;

        public LVL2(int a, int b, bool fill = false): base(fill)
        {
            array = new int[b, a];

            this.a = a;
            this.b = b;
            
            if(fill)
            {
                UserFill();
                Console.WriteLine("Матрица успешно создана.");
            }
            else
            {
                RndFill();
                Console.WriteLine("Матрица успешно создана.");
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array[i, j] = random.Next(-1000, 1000);
                }
            }
        }

        protected override void UserFill()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"Элемент ({i},{j}): ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    sum += array[i, j];
                }
            }
            return sum/(a*b);
        }

        public override void Print()
        {
            Console.WriteLine($"Матрица размером [{b}X{a}]");
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (j == a - 1) { Console.WriteLine(array[i, j]); }
                    else { Console.Write($"{array[i, j]} "); }
                }
            }
        }
    }
}
