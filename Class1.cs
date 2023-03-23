class ClassExample
{
    string Name;
    int id;
    string department;
    float grade;
    public ClassExample(string myName, int myId, string myDepartment, float myGrade)
    {
        this.Name = myName;
        this.id = myId;
        this.department = myDepartment;
        this.grade = myGrade;
    }
    public void displayStudent()
    {
        Console.WriteLine("Details of the student are : " + "NAME:" + Name);
        Console.WriteLine(id + " is id " + department + "is dept " + grade + " is grade");
    }

    ~ClassExample()
    {
        Console.WriteLine("Destructor called");
    }

    static void Main(string[] args)
    {

        ClassExample myProgram = new ClassExample("Maha", 1, "EIE", 8.0f);
        myProgram.displayStudent();

    }

}