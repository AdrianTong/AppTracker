using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CollegeTracker.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CollegeTracker.Models;
using CollegeTracker.Models.ChecklistModels;

namespace CollegeTracker.Controllers
{
    public class ChecklistTaskController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ChecklistTaskController(UserManager<ApplicationUser> manager)
        {
            _userManager = manager;
        }
        // GET: ChecklistTask
        public async Task<ActionResult> Index()
        {
            var AuthenticatedUser = await _userManager.GetUserAsync(User);

            using (var context = new ProjectDbContext(new DbContextOptions<ProjectDbContext>()))
            {
                var userTasks = context.ChecklistTasks.Where(t => t.user.Equals(AuthenticatedUser));
                return View(userTasks);
            };
        }

        // GET: ChecklistTask/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChecklistTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChecklistTask/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var AuthenticatedUser = await _userManager.GetUserAsync(User);
                    ChecklistTask checklistTask = new ChecklistTask { Content = collection["content"], user = AuthenticatedUser };

                   using (var context = new ProjectDbContext(new DbContextOptions<ProjectDbContext>()))
                   {
                        context.ChecklistTasks.Add(checklistTask);
                   };
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChecklistTask/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChecklistTask/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChecklistTask/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChecklistTask/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}