using Dependency_Injection_Example.Models;

namespace Dependency_Injection_Example.Dependency_Injection
{
    public class DI_FinalStudentServices : DI_StudentInterface
    {
        public List<StudentModel> DataSource()
        {
            List<StudentModel> lstStudent = new List<StudentModel>();
            lstStudent.Add(new StudentModel { StudentId = 501, Name = "James Peter", Branch = "CSE", Section = "A", Gender = "Male" });
            lstStudent.Add(new StudentModel { StudentId = 502, Name = "Mikal Smith", Branch = "ETC", Section = "B", Gender = "Male" });
            lstStudent.Add(new StudentModel { StudentId = 503, Name = "David Leon", Branch = "CST", Section = "C", Gender = "FeMale" });
            lstStudent.Add(new StudentModel { StudentId = 504, Name = "Sar Jay", Branch = "CST", Section = "D", Gender = "FeMale" });
            lstStudent.Add(new StudentModel { StudentId = 505, Name = "Pam Otu", Branch = "CSE", Section = "E", Gender = "FeMale" });
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

        public string DI_StudentName()
        {
            return "Zwe Htet";
        }
    }
}
