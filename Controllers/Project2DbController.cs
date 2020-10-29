using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dimension.Data;
using Dimension.Models;

namespace Dimension.Controllers
{
    public class Project2DbController : Controller
    {
        private readonly project2dataContext _context;

        public Project2DbController(project2dataContext context)
        {
            _context = context;
        }

        // GET: Project2Db
        public async Task<IActionResult> Index()
        {
            return View(await _context.Project2Db.ToListAsync());
        }

        // GET: Project2Db/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project2Db = await _context.Project2Db
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (project2Db == null)
            {
                return NotFound();
            }

            return View(project2Db);
        }

        // GET: Project2Db/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project2Db/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Project2Db project2Db)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project2Db);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project2Db);
        }

        // GET: Project2Db/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project2Db = await _context.Project2Db.FindAsync(id);
            if (project2Db == null)
            {
                return NotFound();
            }
            return View(project2Db);
        }

        // POST: Project2Db/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Project2Db project2Db)
        {
            if (id != project2Db.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project2Db);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Project2DbExists(project2Db.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(project2Db);
        }

        // GET: Project2Db/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project2Db = await _context.Project2Db
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (project2Db == null)
            {
                return NotFound();
            }

            return View(project2Db);
        }

        // POST: Project2Db/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var project2Db = await _context.Project2Db.FindAsync(id);
            _context.Project2Db.Remove(project2Db);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Project2DbExists(string id)
        {
            return _context.Project2Db.Any(e => e.EmployeeNumber == id);
        }
    }
}
