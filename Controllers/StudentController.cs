using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult Index()
        {
            var studentList = new StudentListViewModel();
#pragma warning disable IDE0017 // Simplify object initialization
            var student = new StudentViewModel();
#pragma warning restore IDE0017 // Simplify object initialization
            student.FirstName = "John";
            student.LastName = "Cena";
            student.Grade = "B";

#pragma warning disable IDE0017 // Simplify object initialization
            var student1 = new StudentViewModel();
#pragma warning restore IDE0017 // Simplify object initialization
            student1.FirstName = "Betty";
            student1.LastName = "Crocker";
            student1.Grade = "C";

#pragma warning disable IDE0017 // Simplify object initialization
            var student2 = new StudentViewModel();
#pragma warning restore IDE0017 // Simplify object initialization
            student2.FirstName = "Jose";
            student2.LastName = "Cuervo";
            student2.Grade = "A";

            studentList.Students.Add(student);
            studentList.Students.Add(student2);
            studentList.Students.Add(student1);
            return View(studentList);
        }

    }
}