using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Capstone4.Controllers
{
    public class TaskListController : Controller
    {
        private readonly TaskListDbContext _context;

        public TaskListController(TaskListDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TaskList newTask)
        {
            AspNetUsers thisUser = _context.AspNetUsers.Where(u => u.UserName == User.Identity.Name).First();
            newTask.Desciption = thisUser.Id;

            
            _context.TaskList.Add(newTask);
            _context.SaveChanges();
            return RedirectToAction("TaskList");
        }
        public IActionResult TaskList()
        {
            List<TaskList> userTasks = _context.TaskList.Find();
            return View();
        }
    }
}