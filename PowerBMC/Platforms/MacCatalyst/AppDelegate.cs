using Foundation;

namespace PowerBMC {
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
