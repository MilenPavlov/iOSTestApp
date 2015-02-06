using System;
using System.Drawing;

using CoreFoundation;
using CoursesLibrary;
using UIKit;
using Foundation;

namespace testiOS1
{

    [Register("CoursePagerViewController")]
    public class CoursePagerViewController : UIViewController
    {
        private CourseManager courseManager;
        private UIPageViewController pageViewController;

        public CoursePagerViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {            
            base.ViewDidLoad();


            pageViewController = new UIPageViewController(UIPageViewControllerTransitionStyle.PageCurl, UIPageViewControllerNavigationOrientation.Horizontal, UIPageViewControllerSpineLocation.Min);

            pageViewController.View.Frame = this.View.Bounds;
            this.View.AddSubview(pageViewController.View);

            courseManager = new CourseManager();
            courseManager.MoveFirst();
                var dataSource = new CoursePagerViewControllerDataSource(courseManager);
            pageViewController.DataSource = dataSource;

            CourseViewController myFirstCourseViewController = dataSource.GetFirstViewController();

            pageViewController.SetViewControllers(new UIViewController[]{myFirstCourseViewController},UIPageViewControllerNavigationDirection.Forward, false,null);

        

            //pageViewController.GetNextViewController = GetNextViewController;
            //pageViewController.GetPreviousViewController = GetPreviousViewController;
        }

        //CourseViewController CreateCourseViewController()
        //{
        //    var controler = new CourseViewController();
        //    controler.Course = courseManager.Current;
        //    controler.CoursePosition = courseManager.CurrentPosition;

        //    return controler;
        //}

        //public UIViewController GetNextViewController(UIPageViewController pageViewController,
        //    UIViewController referenceViewController)
        //{
        //    CourseViewController returnCourseViewController = null;

        //    var referenceCourseViewController = referenceViewController as CourseViewController;

        //    if (referenceCourseViewController != null)
        //    {
        //        courseManager.MoveTo(referenceCourseViewController.CoursePosition);
        //        if (courseManager.CanMoveNext)
        //        {
        //            courseManager.MoveNext();

        //            returnCourseViewController = CreateCourseViewController();
        //        }
        //    }

        //    return returnCourseViewController;
        //}

        //public UIViewController GetPreviousViewController(UIPageViewController pageViewController,
        //    UIViewController referenceViewController)
        //{
        //    CourseViewController returnCourseViewController = null;

        //    var referenceCourseViewController = referenceViewController as CourseViewController;

        //    if (referenceCourseViewController != null)
        //    {
        //        courseManager.MoveTo(referenceCourseViewController.CoursePosition);
        //        if (courseManager.CanMovePrev)
        //        {
        //            courseManager.MovePrevious();

        //            returnCourseViewController = CreateCourseViewController();
        //        }
        //    }

        //    return returnCourseViewController;
       // }
    }
}