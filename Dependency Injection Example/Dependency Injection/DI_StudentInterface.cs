using Dependency_Injection_Example.Models;

namespace Dependency_Injection_Example.Dependency_Injection
{
    public interface DI_StudentInterface
    {
        List<StudentModel> DI_GetAllStudents();
        StudentModel DI_GetStudentById(int Id);
        string DI_StudentName();
    }
}
