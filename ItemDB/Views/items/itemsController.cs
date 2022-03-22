#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItemDB.Models;

namespace ItemDB.Views.items
{
    public class itemsController : Controller
    {
        private readonly ItemDBContext _context;

        public itemsController(ItemDBContext context)
        {
            _context = context;
        }

        // GET: items
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            var items = from s in _context.item
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
                                       
            }
            switch (sortOrder)
            {
                case "name_desc":
                    items = items.OrderByDescending(s => s.Name);
                    break;
                
                default:
                    items = items.OrderBy(s => s.Name);
                    break;
            }
            return View(await items.AsNoTracking().ToListAsync());
        }

        // GET: items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.item
                .Include(i => i.order)
                .FirstOrDefaultAsync(m => m.itemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: items/Create
        public IActionResult Create()
        {
            ViewData["orderId"] = new SelectList(_context.Set<order>(), "orderId", "orderId");
            return View();
        }

        // POST: items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("itemId,orderId,Name,Rarity,Description,Personal_Notes,Archetype")] item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["orderId"] = new SelectList(_context.Set<order>(), "orderId", "orderId", item.orderId);
            return View(item);
        }

        // GET: items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["orderId"] = new SelectList(_context.Set<order>(), "orderId", "orderId", item.orderId);
            return View(item);
        }

        // POST: items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("itemId,orderId,Name,Rarity,Description,Personal_Notes,Archetype")] item item)
        {
            if (id != item.itemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!itemExists(item.itemId))
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
            ViewData["orderId"] = new SelectList(_context.Set<order>(), "orderId", "orderId", item.orderId);
            return View(item);
        }

        // GET: items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.item
                .Include(i => i.order)
                .FirstOrDefaultAsync(m => m.itemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.item.FindAsync(id);
            _context.item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool itemExists(int id)
        {
            return _context.item.Any(e => e.itemId == id);
        }
    }
}
