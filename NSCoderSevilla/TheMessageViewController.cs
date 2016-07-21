using Foundation;
using System;
using UIKit;

namespace NSCoderSevilla
{
    public partial class TheMessageViewController : UIViewController
    {
        public TheMessageViewController (IntPtr handle) : base (handle)
        {
        }

		partial void CrashWithNoLimitsAndLetMeSeeThatBeautyOfCallStack (UIButton sender)
		{
			object obj = null;
			obj.ToString ();
			// Stop the app, open Application Output pad and BOOM "magic"
		}
	}
}