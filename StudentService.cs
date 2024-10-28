namespace _23octlab;

internal class StudentService : IStudentService
{
    private Student[] students = new Student[5];
    private int index = 0;



    public void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public Student[] GetAllStudents()
    {
        foreach (var i in students)
        {
            return 
        }
    }

    public Student GetStudentById(int id)
    {
        for (int i = 0; i < index; i++)
        {
            if (students[i].Id == id)
            return students[i];
            
        }
        return null;
    }

    public Student[] GetStudentsByName()
    {
        throw new NotImplementedException();
    }

    public void RemoveStudent(int id, bool isSoftDelete)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(int id)
    {
        throw new NotImplementedException();
    }
}
   
