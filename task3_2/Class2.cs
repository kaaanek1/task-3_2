namespace task3_2
{
    class LVL2: ParentClass
    {
        private int[,] array;


        public LVL2(int a, int b, bool fill = false): base(fill)
        {
            array = new int[b, a];
            
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-1000, 1000);
                }
            }
        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Элемент ({i},{j}): ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum/(array.GetLength(0)*array.GetLength(1));
        }

        public override void Print()
        {
            Console.WriteLine($"Матрица размером [{array.GetLength(0)}X{array.GetLength(1)}]");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == array.GetLength(1) - 1) { Console.WriteLine(array[i, j]); }
                    else { Console.Write($"{array[i, j]} "); }
                }
            }
        }
    }
}
