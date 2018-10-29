using System.Collections.Generic;

namespace Elte3
{
    public class KinderGarden
    {
        public Teacher Teacher;
        public List<Child> children = new List<Child>();
        public bool IsInOrder { get; private set; } = true;

        public void AddTeacer(Teacher teacher)
        {
            this.Teacher = teacher;
        }

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public void DoSomethingEveryone(Activity activity)
        {
            int boredChildrensCount = 0;
            foreach (var child in children)
            {
                child.DoSomething(activity);
                if (!child.IsCalm) boredChildrensCount++;
            }
            if (boredChildrensCount >= 3) IsInOrder = false;
        }
    }
}