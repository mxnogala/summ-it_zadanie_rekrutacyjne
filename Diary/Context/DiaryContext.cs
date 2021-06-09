using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diary.Models;

namespace Diary.Controllers
{
    public class DiaryContext : DbContext
    {
            public DbSet<DiaryModel> DiaryEntry { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite(@"Data Source=diary.db");

    }
}
