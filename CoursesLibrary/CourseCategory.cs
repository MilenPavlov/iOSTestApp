using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseCategory
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
