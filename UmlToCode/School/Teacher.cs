namespace School
{
    internal class Teacher : Person
    {
        private readonly string subject;

        public void Explain()
        {
            System.Console.WriteLine("Explanation begins");
        }
    }
}