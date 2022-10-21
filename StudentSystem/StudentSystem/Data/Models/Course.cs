using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
  public  class Course
    {
        public Course()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        public int CourseId { get; set; }


        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate{ get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Resource> Resources{ get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
