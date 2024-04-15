using Dependency_Injection_Example.Models;

namespace Dependency_Injection_Example._Loose_Coupling
{
    public interface IStudentInterface
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int Id);
        string StudentName();
    }
}
