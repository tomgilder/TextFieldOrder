using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TextFieldOrderExample
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            this.Window = new UIWindow(UIScreen.MainScreen.Bounds);
            this.Window.MakeKeyAndVisible();

            var vc = new NameViewController();
            this.Window.RootViewController = vc;

            return true;
        }
    }
}

