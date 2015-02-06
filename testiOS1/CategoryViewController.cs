using System;
using System.Drawing;

using CoreFoundation;
using CoursesLibrary;
using UIKit;
using Foundation;

namespace testiOS1
{

    [Register("CategoryViewController")]
    public class CategoryViewController : UITableViewController
    {
        private CourseCategoryManager courseCategoryManager;
        public CategoryViewController()
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

            courseCategoryManager = new CourseCategoryManager();

            var tableView = this.View as UITableView;
            tableView.Source = new CategoryViewSource(courseCategoryManager);

            // Perform any additional setup after loading the view
        }
    }
}