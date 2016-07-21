using Foundation;
using System;
using UIKit;

namespace NSCoderSevilla
{
    public partial class RealWorldAppsViewController : UIViewController
    {
        public RealWorldAppsViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			string [] tableItems = new string [] { "Dubai 360", "plainVR", "MySek", "HealthClinic.biz' Patients" };
			AppsTableView.Source = new TableSource (tableItems);
		}
    }

	public class TableSource : UITableViewSource
	{

		string [] TableItems;
		string CellIdentifier = "TableCell";

		public TableSource (string [] items)
		{
			TableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems [indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null) { cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}
	}
}