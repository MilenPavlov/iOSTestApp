using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseCategoryManager
    {
        private readonly CourseCategory[] categories;
        private int currentIndex = 0;
        private readonly int lastIndex;

        public CourseCategoryManager()
        {
            categories = InitCategories();
            lastIndex = categories.Length - 1;
        }

        private CourseCategory[] InitCategories()
        {
            var initCategories = new CourseCategory[]
            {
                new CourseCategory()
                {
                    Title = "Android",
                    Description = "Android Programming courses"
                },
                new CourseCategory()
                {
                    Title = "iOS",
                    Description = "iOS Programming courses"
                },
                new CourseCategory()
                {
                    Title = "Windows Phone",
                    Description = "Windows Phone Programming courses"
                }
            };

            return initCategories;
        }

        public int Length 
        {
            get { return categories.Length; }
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrevious()
        {
            if (currentIndex > 0)
            {
                --currentIndex;
            }
        }


        public void MoveNext()
        {
            if (currentIndex < lastIndex)
            {
                ++currentIndex;
            }
        }

        public void MoveTo(int position)
        {
            if (position >= 0 && position <= lastIndex)
            {
                currentIndex = position;
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format("{0} is an invalid position", position));
            }
        }

        public Boolean CanMovePrev
        {
            get { return currentIndex > 0; }
        }

        public Boolean CanMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
        public CourseCategory Current
        {
            get { return categories[currentIndex]; }
        }

        public int CurrentPosition
        {
            get { return currentIndex; }
        }
    }


}
