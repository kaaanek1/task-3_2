namespace task3_2
{
    sealed class LVL1: ParentClass
    {
        private int[] array;

        public LVL1(int l, bool fill = false): base(fill)
        {
            array = new int[l];
            if (fill)
            {
                UserFill();
                Console.WriteLine("Одномерный массив создан.");
            }
            else
            {
                RndFill();
                Console.WriteLine("Одномерный массив создан.");
            }
        }

        protected override void RndFill()
        {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-1000, 1000);
                }
        }

    
        protected override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Элемент {i}: ");
                    int x = int.Parse(Console.ReadLine());
                    array[i] = x;
                }
        }

        public override double Average()
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            return sum / array.Length;
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                { 
                    Console.WriteLine($"{array[i]}");
                }
                else 
                { 
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
