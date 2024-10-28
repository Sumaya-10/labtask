namespace _23octlab;

 class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public double GPA{ get; set; }
    //public string Status{ get; set; }
    public string Major { get; set; }
    public Student(int id, string firstName, string lastName, string email, string phoneNumber, double gpa, string major)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        GPA = gpa;
        Major = major;
    }
}
