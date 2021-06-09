using Diary.Context;
using Diary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Controllers
{
    public class DiaryController : Controller
    {
        private readonly DiaryContext _context;
        public DiaryController(DiaryContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<DiaryModel>>> Index()
        {
            return View(await _context.DiaryEntry.ToListAsync());
        }


        [HttpGet("/Diary/Show/{id}")]
        public async Task<ActionResult<DiaryModel>>Show(int id)
        {
            var entry = await _context.DiaryEntry.FindAsync(id);

            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        [HttpGet("Diary/Delete/{id}")]
        public async Task<ActionResult<DiaryModel>> Delete(int id)
        {
            var entry = await _context.DiaryEntry.FindAsync(id);
           if (entry == null)
            {
                return NotFound();
            }

            _context.DiaryEntry.Remove(entry);
            await _context.SaveChangesAsync();
         
            return View(entry);
        }

        [HttpGet("/Diary/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<DiaryModel>> Save(DiaryModel diaryModel)
        {
            _context.DiaryEntry.Add(diaryModel);
            await _context.SaveChangesAsync();

            return View(diaryModel);
        }






    }
}
