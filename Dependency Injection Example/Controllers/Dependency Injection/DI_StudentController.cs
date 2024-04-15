using Dependency_Injection_Example.Dependency_Injection;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Example.Controllers.Dependency_Injection
{
    public class DI_StudentController : Controller
    {
        private DI_StudentInterface _iStudentInterface;

        //constructor injection DI service,services are alredy registered in the program.cs
        public DI_StudentController(DI_StudentInterface iStudentInterface)
        {
            this._iStudentInterface = iStudentInterface;
        }

        [Route("/DI/studentlist")]
        public JsonResult GetAllStudent()
        {
            var studentList = _iStudentInterface.DI_GetAllStudents();
            return Json(studentList);
        }

        [Route("/DI/getstudentbyid/{id}")]
        public JsonResult GetStudentById(int Id)
        {
            var student = _iStudentInterface.DI_GetStudentById(Id);
            return Json(student);
        }
    }
}
