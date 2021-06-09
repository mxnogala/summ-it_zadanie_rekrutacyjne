using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class DiaryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Entry { get; set; }
        public int Day { get; set; }

    }
}
