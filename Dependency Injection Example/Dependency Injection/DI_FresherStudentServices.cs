using Dependency_Injection_Example.Models;

namespace Dependency_Injection_Example.Dependency_Injection
{
    public class DI_FresherStudentServices
    {
        public List<StudentModel> DataSource()
        {
            List<StudentModel> lstStudent = new List<StudentModel>();
            lstStudent.Add(new StudentModel { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" });
            lstStudent.Add(new StudentModel { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" });
            lstStudent.Add(new StudentModel { StudentId = 103, Name = "David", Branch = "CST", Section = "C", Gender = "FeMale" });
            lstStudent.Add(new StudentModel { StudentId = 104, Name = "Sara", Branch = "CST", Section = "D", Gender = "FeMale" });
            lstStudent.Add(new StudentModel { StudentId = 105, Name = "Pam", Branch = "CSE", Section = "E", Gender = "FeMale" });
            return lstStudent;
        }

        public List<StudentModel> DI_GetAllStudents()
        {
            return DataSource();
        }

        public StudentModel DI_GetStudentById(int Id)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == Id) ?? new StudentModel();
        }
    }
}
