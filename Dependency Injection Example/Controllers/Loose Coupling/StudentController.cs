using Dependency_Injection_Example._Loose_Coupling;
using Dependency_Injection_Example._Loose_Coupling.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Example.Controllers.Loose_Coupling
{
    public class StudentController : Controller
    {
        private IStudentInterface _iStudentInterface;
        public StudentController()
        {
            _iStudentInterface = new LC_FinalStudentServices();//you can switch method here that you need to use
        }

        [Route("/loosecoupling/studentlist")]
        public JsonResult GetAllStudent()
        {
            //loose coupling , only need to change inside the constructor

            var studentList = _iStudentInterface.GetAllStudents();
            return Json(studentList);
        }

        [Route("/loosecoupling/getstudentbyid/{id}")]
        public JsonResult GetStudentById(int Id)
        {
            var student = _iStudentInterface.GetStudentById(Id);
            return Json(student);
        }

        [Route("/loosecoupling/getstudentname")]
        public JsonResult StudentName()
        {
            return Json(_iStudentInterface.StudentName());
        }

        #region Doc

        //GetAllStudent() and GetStudentById methods inside the StudentController call the interface named
        //IStudentInterface , it does not need to call FresherStudentServices or FinalStudentServices directly.
        //we can only need to switch service name in the StudentController constructor depends on our requirement

        #endregion
    }
}
