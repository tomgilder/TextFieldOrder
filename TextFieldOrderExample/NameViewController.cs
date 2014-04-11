using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TextFieldOrderExample
{
    public partial class NameViewController : UIViewController
    {
        public NameViewController() : base("NameViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.SetupFieldOrder(new [] { FirstNameField, MiddleNameField, LastNameField }, SubmitName);
        }

        void SubmitName()
        {
            string message = string.Format("Hi, {0} {1} {2}!", FirstNameField.Text, MiddleNameField.Text, LastNameField.Text);
            var alert = new UIAlertView("Nice to meet you", message, null, "Spiffing", null);
            alert.Show();
        }

        partial void DoneTapped(NSObject sender)
        {
            SubmitName();
        }
    }
}

