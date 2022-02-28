using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DrivingClass.Data;
using DrivingClass.Models;

namespace DrivingClass.Controllers
{
    public class LearnersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LearnersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Learners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Learners.ToListAsync());
        }

        // GET: Learners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learner = await _context.Learners
                .FirstOrDefaultAsync(m => m.LearnerId == id);
            if (learner == null)
            {
                return NotFound();
            }

            return View(learner);
        }

        // GET: Learners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Learners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LearnerId,LearnerName,Age,Start,End,DriverName,Email")] Learner learner,int driverId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(learner);
                await _context.SaveChangesAsync();
                Console.WriteLine("Before adding appointment");

                //Add to Appointment table also here.
                Appointment appointment = new Appointment();
                if (learner == null)
                {
                    return NotFound();
                }

                //TODO: Add DoctorName as a dropdown in /patient/create.cshtml and assign the DocName parameter here, instead of the hardcoded srilu
                //String DoctorName = "Srilu";
                //String docValue = formCollection["DocNameId"];


                //Doctor doc = _context.Doctors.Where(d => d.DOctorName == patient.DoctorName).FirstOrDefault();


                //appointment.DriverId = int.Parse(learner.DriverName);
                //appointment.Learner= learner;

                _context.Add(appointment);
                await _context.SaveChangesAsync();
                Console.WriteLine("After adding appointment");
                return RedirectToAction(nameof(Index));
            }
            return View(learner);


        }
        public ActionResult GetDoctorId()
        {
            Appointment appointment = new Appointment();
            var drivers = (from Drivers in _context.Drivers select Drivers);


            _context.Add(appointment);


            return View(drivers);

        }

    

        // GET: Learners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learner = await _context.Learners.FindAsync(id);
            if (learner == null)
            {
                return NotFound();
            }
            return View(learner);
        }

        // POST: Learners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LearnerId,LearnerName,Age,Start,End,DriverName,Email")] Learner learner)
        {
            if (id != learner.LearnerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(learner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LearnerExists(learner.LearnerId))
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
            return View(learner);
        }

        // GET: Learners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learner = await _context.Learners
                .FirstOrDefaultAsync(m => m.LearnerId == id);
            if (learner == null)
            {
                return NotFound();
            }

            return View(learner);
        }

        // POST: Learners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var learner = await _context.Learners.FindAsync(id);
            _context.Learners.Remove(learner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LearnerExists(int id)
        {
            return _context.Learners.Any(e => e.LearnerId == id);
        }
    }
}
