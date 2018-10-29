using System;

namespace Elte3
{
    public abstract class Child
    {
        private static Random rnd = new Random();
        protected int satisfyLevel = rnd.Next(1,3);
        public bool IsCalm { get; protected set; } = true;

        protected abstract void DoActivity(Activity activity);

        public void DoSomething(Activity activity)
        {
            DoActivity(activity);
            CheckSatisfy();
        }

        public void CheckSatisfy()
        {
            if (satisfyLevel <= 0) IsCalm = false;
        }
    }
}