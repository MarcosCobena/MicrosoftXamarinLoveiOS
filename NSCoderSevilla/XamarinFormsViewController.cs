using Foundation;
using System;
using UIKit;
using Library;
using Xamarin.Forms;

namespace NSCoderSevilla
{
    public partial class XamarinFormsViewController : UIViewController
    {
        public XamarinFormsViewController (IntPtr handle) : base (handle)
        {
        }

		partial void ShowXamarinFormsPage (UIButton sender)
		{
			var xamarinFormsPage = new XamarinFormsPage (() => { NavigationController.DismissModalViewController (true); });
			var viewController = xamarinFormsPage.CreateViewController ();
			NavigationController.PresentModalViewController (viewController, true);
		}
	}
}