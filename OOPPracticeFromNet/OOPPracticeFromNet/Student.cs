namespace OOPPracticeFromNet
{
    public class Student : Person
    {
        public Student()
        {
        }

        public void GoToClasses()
        {
            System.Console.WriteLine("I'm going to class");
        }
        public void ShowAge()
        {
            System.Console.WriteLine($"My age is: {this.age} years old");
        }
    }
}