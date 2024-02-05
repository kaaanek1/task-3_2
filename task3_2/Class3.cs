using System.Text.RegularExpressions;

namespace task3_2
{
    class LVL3: ParentClass
    {
        private int[][] array;
        private int l;

        public LVL3(int l, bool fill = false): base(fill)
        {
            array = new int[l][];
            this.l = l;

            if (fill)
            {
                UserFill();
                Console.WriteLine("Ступенчатый массив успешно создан.");
            }
            else
            {
                RndFill();
                Console.WriteLine("Ступенчатый массив успешно создан.");
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write($"Длина {i} подмассива: ");
                int l1 = int.Parse(Console.ReadLine());
                array[i] = new int[l1];
                for (int j = 0; j < l1; j++)
                {
                    int x = random.Next(-1000, 1000);
                    array[i][j] = x;
                }
            }
        }

        protected override void UserFill()
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write($"Длина {i} подмассива: ");
                int l1 = int.Parse(Console.ReadLine());
                array[i] = new int[l1];
                for (int j = 0; j < l1; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    int x = int.Parse(Console.ReadLine());
                    array[i][j] = x;
                }
            }
        }

        public override double Average()
        {
            int sum = 0;
            int el = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = array[i][j];
                    sum += x;
                    el++;
                }
            }
            return sum/el;
        }

        public override void Print()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j == array[i].Length - 1)
                    {
                        Console.WriteLine(array[i][j]);
                    }
                    else
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                }
            }
        }
    }
}
