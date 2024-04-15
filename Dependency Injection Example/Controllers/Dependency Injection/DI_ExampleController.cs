using Dependency_Injection_Example._Loose_Coupling;
using Dependency_Injection_Example.DI_Service;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System;

namespace Dependency_Injection_Example.Controllers.Dependency_Injection
{
    public class DI_ExampleController : Controller
    {
        ITransientService _transientService1;
        ITransientService _transientService2;

        IScopedService _scopedService1;
        IScopedService _scopedService2;

        ISingletonService _singletonService1;
        ISingletonService _singletonService2;

        //Constructor Injection
        public DI_ExampleController(ITransientService transientService1,
            ITransientService transientService2, IScopedService scopedService1,
            IScopedService scopedService2, ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            ViewBag.TransientMessage1 = "First Instance => " + _transientService1.GetId();
            ViewBag.TransientMessage2 = "Second Instance => " + _transientService2.GetId();

            ViewBag.ScopedMessage1 = "First Instance => " + _scopedService1.GetId();
            ViewBag.ScopedMessage2 = "Second Instance => " + _scopedService2.GetId();

            ViewBag.SingletonMessage1 = "First Instance => " + _singletonService1.GetId();
            ViewBag.SingletonMessage2 = "Second Instance => " + _singletonService2.GetId();

            return View();
        }

        [Route("/DI/ActionMethodInjection")]

        //Action Method Injection using [FromService] attribute

        //Sometimes, we may only need a dependency object in a single action method.
        //In that case, we need to use the[FromServices] attribute with the service type parameter
        //in the action method.
        public JsonResult ActionMethodInjection([FromServices] ITransientService transientService)
        {
            var newId = transientService.GetId();
            return Json(newId);
        }

        [Route("DI/GetServiceManual")]

        //Get service manual
        public JsonResult GetServiceManual()
        {
            var services = this.HttpContext.RequestServices;
            IScopedService? transientService = (IScopedService?)services.GetService(typeof(IScopedService));
            var newId = transientService?.GetId().ToString();
            return Json(newId);
        }
    }
}
