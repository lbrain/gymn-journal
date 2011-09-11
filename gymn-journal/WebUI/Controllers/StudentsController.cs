using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace WebUI.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentRepository repository;

        public StudentsController(IStudentRepository studentRepository) {
            repository = studentRepository;
        }

        public ActionResult Index() {
            return View(repository.Students);
        }

    }
}
