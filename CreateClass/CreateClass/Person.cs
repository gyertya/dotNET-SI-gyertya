using System;

namespace CreateClass
{
    public class Person
    {
        public int Age { get => _age; set => _age = value; }

        public DateTime birthDate;

        public Gender gender;
        private int _age;

        public enum Gender
        {
            MALE,
            FEMALE
        }

        public DateTime GetBirthDate
        {
            get { return birthDate; }
        }

        public void SetBirthDate(int yy, int mm, int dd)
        {
            birthDate = new DateTime(yy, mm, dd);
        }
        public string Name { get; set; }

        public new string ToString => $"Name: {Name}, DOB: {birthDate}, Gender: {gender}";
    }
}