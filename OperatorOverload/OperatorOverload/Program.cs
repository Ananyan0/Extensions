namespace OperatorOverload;

class Group
{
    public List<Student> students;

    public Group(List <Student> Students)
    {
        students = Students;
    }

    public Group()
    {
        students = new List<Student>();
    }

    public static bool operator true(Group group)
    {
        return group.students != null && group.students.Count > 0;
    }

    public static bool operator false(Group group)
    {
        return group.students == null && group.students.Count == 0;
    }

    public static Group operator +(Group group1, Group group2)
    {
        List<Student> mergedGroups = new List<Student>(group1.students);
       
        for(int i = 0; i < group2.students.Count; i++)
        {
            mergedGroups.Add(group2.students[i]);
        }

        return new Group(mergedGroups);
    }

    public static Group operator -(Group group1, Group group2)
    {   
        List<Student> newGroup = new List<Student>();
        int Size = group1.students.Count;
        if(group1.students.Count > group2.students.Count)
        {
            Size = group2.students.Count;
        } 
    
        for(int i = 0; i < Size; i++)
        {
            bool isEqual = false;
            for(int j = i + 1; j < Size; j++)
            {   

                if(group1.students[i] == group2.students[j])
                {
                    group1.students.RemoveAt(i);
                }
            }
        }

        return new Group(group1.students);
    }

}

class Student
{
    private string _name { get; set; }
    private int _age { get; set; }

    public Student(string Name, int Age)
    {
        _name = Name;
        _age = Age;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { 
            if(value < 0) throw new ArgumentOutOfRangeException("Ca not be negative");
            _age = value; 
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Karen", 25);
        Student student2 = new Student("Anna", 20);
        Student student3 = new Student("Sirak", 20);

        Student student4 = new Student("Anna", 20);
        Student student5 = new Student("Aro", 37);
        Student student6 = new Student("Meri", 19);        

        Group group1 = new Group();
        Group group2 = new Group();

        group1.students.Add(student1);
        group1.students.Add(student2);
        group1.students.Add(student3);

        group2.students.Add(student4);
        group2.students.Add(student5);
        group2.students.Add(student6);

        /*
        Group newGroup = new Group();
        newGroup = group1 + group2;

        foreach(Student items in newGroup.students)
        {
            Console.WriteLine($"Name: {items.Name}, Age: {items.Age}");
        }
        */
    }
}