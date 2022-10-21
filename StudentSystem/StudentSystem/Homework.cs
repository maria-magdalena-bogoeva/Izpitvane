using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Homework
    {
       
        public int HomeworkId { get; set; }


        [Required]
        public string Content { get; set; }
        [Required]
        public ContentType ContentType { get; set; }
        [Required]
        public DateTime SubmissionTime { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public Course Course { get; set; }

    }
}
