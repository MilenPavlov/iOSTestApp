
using System;
using System.Drawing;
using CoursesLibrary;
using Foundation;
using UIKit;

namespace testiOS1
{
	public partial class CourseViewController : UIViewController
	{
        public Course Course { get; set; }
        public int CoursePosition { get; set; }
        //private CourseManager courseManager;
		public CourseViewController () : base ("CourseViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		    buttonNext.Hidden = true;
		    buttonPrev.Hidden = true;

		    UpdateUI();
		}


	    private void UpdateUI()
	    {
            labelTitle.Text = Course.Title;
            textDescription.Text = Course.Description;
            imageCourse.Image = UIImage.FromBundle(Course.Image);
	    }
	}
}

