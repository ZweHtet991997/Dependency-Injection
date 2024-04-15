using Dependency_Injection_Example._Tight_Coupling.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Example.Controllers.Tight_Coupling
{
    public class StudentController : Controller
    {
        [Route("/tightcoupling/studentlist")]
        public JsonResult GetAllStudent()
        {
            // tight coupling, direct call the instance of FresherStudentService

            //FresherStudentServices studentServices = new FresherStudentServices();
            TC_FinalStudentServices studentServices = new TC_FinalStudentServices();
            var studentList = studentServices.GetAllStudents();
            return Json(studentList);
        }

        [Route("/tightcoupling/getstudentbyid/{id}")]
        public JsonResult GetStudentById(int Id)
        {
            //FresherStudentServices studentServices = new FresherStudentServices();
            TC_FinalStudentServices studentServices = new TC_FinalStudentServices();
            var student = studentServices.GetStudentById(Id);
            return Json(student);
        }

        [Route("/tightcoupling/getstudentname")]
        public JsonResult StudentName()
        {
            TC_FinalStudentServices studentService = new TC_FinalStudentServices();
            return Json(studentService.StudentName());
        }

        #region Doc

        // GetAllStudent() and GetStudentById() methods inside the StudentController directly depend on the
        //instance of FreshStudentServices. If you want to show final year student information inside the 
        //GetAllStudent() method, you need to make changes from FresherStudentService to the new instance of
        //FinalStudentService.This is tight coupling between classes.

        #endregion
    }
}
