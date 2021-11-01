using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JardineriaGrupo.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace JardineriaGrupo.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly jardineriaContext _context;
        public int tam_pagina = 15;
        public ProductController(jardineriaContext context)
        {
            _context = context;
        }

        // GET: Product
        /*public async Task<IActionResult> Index()
        {
            var jardineriaContext = _context.Productos.OrderByDescending(p => p.GamaNavigation);
            return View(await jardineriaContext.Take(15).ToListAsync());
        }*/
        [AllowAnonymous]
        public IActionResult Index(string gama,string busqueda_actual,
        string buscado, int? nueva_pagina)
        {
            if (gama != null)
            {

                var product = _context.Productos.OrderByDescending(p => p.GamaNavigation).Where(p => p.Gama == gama);
                if (buscado != null)
                {
                    nueva_pagina = 1;
                }
                else
                {
                    buscado = busqueda_actual;
                }
                if (!String.IsNullOrEmpty(buscado))
                {
                    product = product.Where(x
                    => x.Nombre.StartsWith(buscado) || buscado == null);
                }

                ViewData["busqueda_actual"] = buscado;

                return View(product.ToList().ToPagedList(nueva_pagina ?? 1, tam_pagina));
            }
            else
            {

                var jardineriaContext = _context.Productos.OrderByDescending(p => p.GamaNavigation);
                if (buscado != null)
                {
                    nueva_pagina = 1;
                }
                else
                {
                    buscado = busqueda_actual;
                }
                if (!String.IsNullOrEmpty(buscado))
                {
                    jardineriaContext = (IOrderedQueryable<Producto>)jardineriaContext.Where(x
                    => x.Nombre.StartsWith(buscado) || buscado == null);
                }

                ViewData["busqueda_actual"] = buscado;
                return View(jardineriaContext.ToList().ToPagedList(nueva_pagina ?? 1, tam_pagina));
            }

            
            
        }


        // GET: Product/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.GamaNavigation)
                .FirstOrDefaultAsync(m => m.CodigoProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoProducto,Nombre,Gama,Dimensiones,Proveedor,Descripcion,CantidadEnStock,PrecioVenta,PrecioProveedor")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodigoProducto,Nombre,Gama,Dimensiones,Proveedor,Descripcion,CantidadEnStock,PrecioVenta,PrecioProveedor")] Producto producto)
        {
            if (id != producto.CodigoProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.CodigoProducto))
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
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.GamaNavigation)
                .FirstOrDefaultAsync(m => m.CodigoProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(string id)
        {
            return _context.Productos.Any(e => e.CodigoProducto == id);
        }
    }
}
