using System;

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

        protected abstract void RndFill();

        protected abstract void UserFill();

        public abstract double Average();

        public abstract void Print();
    }
}
