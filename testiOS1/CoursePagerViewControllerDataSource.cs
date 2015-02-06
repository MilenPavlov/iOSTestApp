using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoursesLibrary;
using Foundation;
using UIKit;

namespace testiOS1
{
    public class CoursePagerViewControllerDataSource : UIPageViewControllerDataSource
    {
        private CourseManager _courseManager;

        public CourseViewController GetFirstViewController()
        {
            _courseManager.MoveFirst();

            return CreateCourseViewController();
        }
        public CoursePagerViewControllerDataSource(CourseManager courseManager)
        {
            _courseManager = courseManager;
        }
        public override UIViewController GetPreviousViewController(UIPageViewController pageViewController,
            UIViewController referenceViewController)
        {
            CourseViewController returnCourseViewController = null;

            var referenceCourseViewController = referenceViewController as CourseViewController;

            if (referenceCourseViewController != null)
            {
                _courseManager.MoveTo(referenceCourseViewController.CoursePosition);
                if (_courseManager.CanMovePrev)
                {
                    _courseManager.MovePrevious();

                    returnCourseViewController = CreateCourseViewController();
                }
            }

            return returnCourseViewController;
        }

        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            CourseViewController returnCourseViewController = null;

            var referenceCourseViewController = referenceViewController as CourseViewController;

            if (referenceCourseViewController != null)
            {
                _courseManager.MoveTo(referenceCourseViewController.CoursePosition);
                if (_courseManager.CanMoveNext)
                {
                    _courseManager.MoveNext();

                    returnCourseViewController = CreateCourseViewController();
                }
            }

            return returnCourseViewController;
        }

        CourseViewController CreateCourseViewController()
        {
            var controler = new CourseViewController();
            controler.Course = _courseManager.Current;
            controler.CoursePosition = _courseManager.CurrentPosition;

            return controler;
        }
    }
}