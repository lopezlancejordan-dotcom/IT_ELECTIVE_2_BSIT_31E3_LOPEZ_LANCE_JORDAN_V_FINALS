using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_BSIT_31E3_LOPEZ_LANCE_JORDAN.Models;

namespace IT_ELECTIVE_2_BSIT_31E3_LOPEZ_LANCE_JORDAN.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Database Schema Mapping & Entity Configuration", Status = "Done", Type = "Backend" },
                new TaskItem { Id = 2, Title = "Document Request Form UI", Status = "Done", Type = "Frontend" },
                new TaskItem { Id = 3, Title = "SSO Authentication QA Validation", Status = "Done", Type = "QA" }
            };

            return View(tasks);
        }
    }
}