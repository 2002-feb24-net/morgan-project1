using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Instrument_Store.Infrastructure.Model;

namespace Instrument_Store.Web.Controllers
{
    public class ProductOrdersController : Controller
    {
        private readonly StoreDbContext _context;

        public ProductOrdersController(StoreDbContext context)
        {
            _context = context;
        }

        // GET: ProductOrders
        public async Task<IActionResult> Index()
        {
            var storeDbContext = _context.ProductOrders.Include(p => p.Order).Include(p => p.Product);
            return View(await storeDbContext.ToListAsync());
        }

        // GET: ProductOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrders = await _context.ProductOrders
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductOrderId == id);
            if (productOrders == null)
            {
                return NotFound();
            }

            return View(productOrders);
        }

        // GET: ProductOrders/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Name");
            return View();
        }

        // POST: ProductOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductOrderId,ProductId,OrderId,Quantity")] ProductOrders productOrders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productOrders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", productOrders.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Name", productOrders.ProductId);
            return View(productOrders);
        }

        // GET: ProductOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrders = await _context.ProductOrders.FindAsync(id);
            if (productOrders == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", productOrders.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Name", productOrders.ProductId);
            return View(productOrders);
        }

        // POST: ProductOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductOrderId,ProductId,OrderId,Quantity")] ProductOrders productOrders)
        {
            if (id != productOrders.ProductOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productOrders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductOrdersExists(productOrders.ProductOrderId))
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
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", productOrders.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Name", productOrders.ProductId);
            return View(productOrders);
        }

        // GET: ProductOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrders = await _context.ProductOrders
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductOrderId == id);
            if (productOrders == null)
            {
                return NotFound();
            }

            return View(productOrders);
        }

        // POST: ProductOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productOrders = await _context.ProductOrders.FindAsync(id);
            _context.ProductOrders.Remove(productOrders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductOrdersExists(int id)
        {
            return _context.ProductOrders.Any(e => e.ProductOrderId == id);
        }
    }
}
