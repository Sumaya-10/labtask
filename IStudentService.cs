using System.Xml.Linq;

namespace _23octlab;

internal interface IStudentService
{
    public  Student GetStudentById(int id); // İd ilə axtarış edəcək və geriyə həmin İd-li Student obyektini qaytaracaq
    public Student[] GetAllStudents(); // Bütün Student obyektlərini qaytaracaq
    public Student[] GetStudentsByName(); // Name ilə axtarış edəcək və geriyə həmin name-ə sahib Student obyektlərini qaytaracaq
    public void AddStudent(Student student);
    public void UpdateStudent(int id);
    public void RemoveStudent(int id, bool isSoftDelete);
}
