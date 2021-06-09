using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class DiaryModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [RegularExpression(@"^.*\S.*$", ErrorMessage ="Title cannot contains only white spaces!")]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [RegularExpression(@"^.*\S.*$", ErrorMessage = "Entry cannot contains only white spaces!")]
        public string Entry { get; set; }
        [Required]
        [Range(1,365)]
        public int Day { get; set; }

    }
}
