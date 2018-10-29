namespace UmlToCode
{
    internal class AbstractProcess : Orderable
    {
        public void Process(Orderable item)
        {

        }

        public void StepBefore()
        {

        }

        internal void Action(Orderable item)
        {

        }

        public void StepAfter() { }

        public bool Checkout()
        {
            throw new System.NotImplementedException();
        }

        public bool Pay()
        {
            throw new System.NotImplementedException();
        }
    }
}