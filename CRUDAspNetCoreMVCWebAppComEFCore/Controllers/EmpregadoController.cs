using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDAspNetCoreMVCWebAppComEFCore.Models;

namespace CRUDAspNetCoreMVCWebAppComEFCore.Controllers
{
    public class EmpregadoController : Controller
    {
        private readonly EmpregadosContext _context;

        public EmpregadoController(EmpregadosContext context)
        {
            _context = context;
        }



        // GET: Empregado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empregados.ToListAsync());
        }


        /*

        // GET: Empregado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregados = await _context.Empregados
                .FirstOrDefaultAsync(m => m.EmpregadosId == id);
            if (empregados == null)
            {
                return NotFound();
            }

            return View(empregados);
        }

        */



        // GET: Empregado/Create
        public IActionResult AddOrEdit(int id=0)
        {
           if(id==0)
            return View(new Empregados());
           else
                return View(_context.Empregados.Find(id));
        }

        // POST: Empregado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("EmpregadosId,Nome,Codigo,Funcao,LocalizacaoEscritorio")] Empregados empregados)
        {
            if (ModelState.IsValid)
            {
                if (empregados.EmpregadosId == 0)
                    _context.Add(empregados);
                else
                _context.Update(empregados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empregados);
        }




        /*

        // GET: Empregado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregados = await _context.Empregados.FindAsync(id);
            if (empregados == null)
            {
                return NotFound();
            }
            return View(empregados);
        }

        // POST: Empregado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpregadosId,Nome,Codigo,Funcao,LocalizacaoEscritorio")] Empregados empregados)
        {
            if (id != empregados.EmpregadosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empregados);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpregadosExists(empregados.EmpregadosId))
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
            return View(empregados);
        }


        */



        // GET: Empregado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var empregados = await _context.Empregados.FindAsync(id);
            _context.Empregados.Remove(empregados);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var empregados = await _context.Empregados
            //    .FirstOrDefaultAsync(m => m.EmpregadosId == id);
            //if (empregados == null)
            //{
            //    return NotFound();
            //}

            //return View(empregados);
        }



        /*

        // POST: Empregado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empregados = await _context.Empregados.FindAsync(id);
            _context.Empregados.Remove(empregados);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpregadosExists(int id)
        {
            return _context.Empregados.Any(e => e.EmpregadosId == id);
        }

        */

    }
}
