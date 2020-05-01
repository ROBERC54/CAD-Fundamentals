using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CADFundamentalsWebAPI.Data;
using CADFundamentalsWebAPI.Models;

namespace CADFundamentalsWebAPI.Controllers
{
    public class UberCategoriesController : Controller
    {
        private readonly CADFundamentalsWebAPIContext _context;

        public UberCategoriesController(CADFundamentalsWebAPIContext context)
        {
            _context = context;
        }

        // GET: UberCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.UberCategory.ToListAsync());
        }
        public async Task<IActionResult> FullList()
        {
            return View(await _context.UberCategory.ToListAsync());
        }

        // GET: UberCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uberCategory = await _context.UberCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uberCategory == null)
            {
                return NotFound();
            }

            return View(uberCategory);
        }

        // GET: UberCategories/Create
        public IActionResult Create()
        {   
            return View();
        }

        // POST: UberCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,LatestReleaseDate,Genre,Complexity,Price")] UberCategory uberCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uberCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uberCategory);
        }

        // GET: UberCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uberCategory = await _context.UberCategory.FindAsync(id);
            if (uberCategory == null)
            {
                return NotFound();
            }
            return View(uberCategory);
        }

        // POST: UberCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,LatestReleaseDate,Genre,Complexity,Price")] UberCategory uberCategory)
        {
            if (id != uberCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uberCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UberCategoryExists(uberCategory.Id))
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
            return View(uberCategory);
        }

        // GET: UberCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uberCategory = await _context.UberCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uberCategory == null)
            {
                return NotFound();
            }

            return View(uberCategory);
        }

        // POST: UberCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uberCategory = await _context.UberCategory.FindAsync(id);
            _context.UberCategory.Remove(uberCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UberCategoryExists(int id)
        {
            return _context.UberCategory.Any(e => e.Id == id);
        }
    }
}
