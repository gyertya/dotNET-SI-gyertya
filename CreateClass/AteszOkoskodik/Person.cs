using System;

/// <summary>
/// The main <c>Content</c>
/// </summary>
namespace AteszOkoskodik
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Person(string v)
        {
            _name = v;
        }

    }
}