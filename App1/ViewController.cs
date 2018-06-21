using Foundation;
using System;
using UIKit;

namespace App1
{
    public partial class ViewController : UIViewController
    {
        //public System.Threading.Tasks.Task DisplayAlert(string title, string message, string cancel);

        public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        partial void Dugme_TouchUpInside(UIButton sender)
        {
            //System.Threading.Tasks.Task DisplayAlert(string title, string message, string cancel);
           // DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}