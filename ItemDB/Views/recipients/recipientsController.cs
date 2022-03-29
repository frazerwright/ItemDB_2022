#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItemDB.Models;

namespace ItemDB.Views.recipients
{
    public class recipientsController : Controller
    {
        private readonly ItemDBContext _context;

        public recipientsController(ItemDBContext context)
        {
            _context = context;
        }

        // GET: recipients
        public async Task<IActionResult> Index()
        {
            var itemDBContext = _context.recipient.Include(r => r.Order);
            return View(await itemDBContext.ToListAsync());
        }

        // GET: recipients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipient = await _context.recipient
                .Include(r => r.Order)
                .FirstOrDefaultAsync(m => m.RecipientId == id);
            if (recipient == null)
            {
                return NotFound();
            }

            return View(recipient);
        }

        // GET: recipients/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.order, "OrderId", "OrderId");
            return View();
        }

        // POST: recipients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("recipientId,OrderId,Address,ItemOrdered")] recipient recipient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.order, "OrderId", "OrderId", recipient.OrderId);
            return View(recipient);
        }

        // GET: recipients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipient = await _context.recipient.FindAsync(id);
            if (recipient == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.order, "OrderId", "OrderId", recipient.OrderId);
            return View(recipient);
        }

        // POST: recipients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("recipientId,OrderId,Address,ItemOrdered")] recipient recipient)
        {
            if (id != recipient.RecipientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!recipientExists(recipient.RecipientId))
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
            ViewData["OrderId"] = new SelectList(_context.order, "OrderId", "OrderId", recipient.OrderId);
            return View(recipient);
        }

        // GET: recipients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipient = await _context.recipient
                .Include(r => r.Order)
                .FirstOrDefaultAsync(m => m.RecipientId == id);
            if (recipient == null)
            {
                return NotFound();
            }

            return View(recipient);
        }

        // POST: recipients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipient = await _context.recipient.FindAsync(id);
            _context.recipient.Remove(recipient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool recipientExists(int id)
        {
            return _context.recipient.Any(e => e.RecipientId == id);
        }
    }
}