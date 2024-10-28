using System.Xml.Linq;

namespace _23octlab;

internal class Program
{
    static void Main(string[] args)
    {
        
    }
}
/*IStudentService Interface
Student GetStudentById(int id); - İd ilə axtarış edəcək və geriyə həmin İd-li Student obyektini qaytaracaq
Student[] GetAllStudents(); - Bütün Student obyektlərini qaytaracaq
Student[] GetStudentsByName(); -  Name ilə axtarış edəcək və geriyə həmin name-ə sahib Student obyektlərini qaytaracaq
Void AddStudent(Student student)
Void UpdateStudent(int id);
Void RemoveStudent(int id, bool isSoftDelete);
Not: RemoveStudent method-un açıqlaması - SoftDelete parametr true olduğu halda sadəcə Status Removed olacaq.Əks təqdirdə(Hard delete) bir başa olaraq Student silinəcək.

StudentService Class
IStudentService interface-dən implement edəcək və Method-ların daxili düzgün şəkildə doldurulacaq.*/