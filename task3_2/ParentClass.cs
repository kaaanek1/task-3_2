namespace task3_2
{
    abstract class ParentClass
    {
        protected static Random random = new Random();
        protected bool fill;

        protected ParentClass(bool fill = false)
        {
            this.fill = fill;
        }

        public abstract void RndFill();

        public abstract void UserFill();

        public abstract double Average();

        public abstract void Print();
    }
}