using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoursesLibrary;
using Foundation;
using UIKit;

namespace testiOS1
{
    public class CategoryViewSource: UITableViewSource
    {
        private const string cellID = "CategoryCell";
        private readonly CourseCategoryManager _courseCategoryManager;

        public CategoryViewSource(CourseCategoryManager courseCategoryManager)
        {
            _courseCategoryManager = courseCategoryManager;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellID);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellID);
            }

            _courseCategoryManager.MoveTo(indexPath.Row);

            cell.TextLabel.Text = _courseCategoryManager.Current.Title;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _courseCategoryManager.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var coursePageViewController = new CoursePagerViewController();
            AppDelegate appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;
            appDelegate.RootNavigationController.PushViewController(coursePageViewController, true);
        }
    }
}