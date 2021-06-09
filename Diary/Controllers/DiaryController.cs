using Diary.Context;
using Diary.Models;
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
                   return  await _context.DiaryEntry.ToListAsync(); 
               }
        

    }
}
