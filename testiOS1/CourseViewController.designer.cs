// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace testiOS1
{
	[Register ("CourseViewController")]
	partial class CourseViewController
	{
		[Outlet]
		UIKit.UIButton buttonNext { get; set; }

		[Outlet]
		UIKit.UIButton buttonPrev { get; set; }

		[Outlet]
		UIKit.UIImageView imageCourse { get; set; }

		[Outlet]
		UIKit.UILabel labelTitle { get; set; }

		[Outlet]
		UIKit.UITextView textDescription { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonNext != null) {
				buttonNext.Dispose ();
				buttonNext = null;
			}

			if (buttonPrev != null) {
				buttonPrev.Dispose ();
				buttonPrev = null;
			}

			if (imageCourse != null) {
				imageCourse.Dispose ();
				imageCourse = null;
			}

			if (labelTitle != null) {
				labelTitle.Dispose ();
				labelTitle = null;
			}

			if (textDescription != null) {
				textDescription.Dispose ();
				textDescription = null;
			}
		}
	}
}
