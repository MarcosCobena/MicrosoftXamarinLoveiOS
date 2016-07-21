using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Library
{
	public partial class XamarinFormsPage : ContentPage
	{
		Action _close;

		public XamarinFormsPage (Action close)
		{
			_close = close;

			InitializeComponent ();
		}

		void Handle_Clicked (object sender, System.EventArgs e)
		{
            _close();
		}
	}
}

