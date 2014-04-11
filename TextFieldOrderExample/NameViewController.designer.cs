// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TextFieldOrderExample
{
	[Register ("NameViewController")]
	partial class NameViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField FirstNameField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField LastNameField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField MiddleNameField { get; set; }

		[Action ("DoneTapped:")]
		partial void DoneTapped (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstNameField != null) {
				FirstNameField.Dispose ();
				FirstNameField = null;
			}

			if (LastNameField != null) {
				LastNameField.Dispose ();
				LastNameField = null;
			}

			if (MiddleNameField != null) {
				MiddleNameField.Dispose ();
				MiddleNameField = null;
			}
		}
	}
}
