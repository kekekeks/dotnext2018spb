using Xamarin.Forms;

namespace Ooui.Shared.Forms
{
    public class FormsApp
    {
        private static bool Initialized;
        public static Element GetFormsApp()
        {
            if (!Initialized)
            {
                Xamarin.Forms.Forms.Init();
                Initialized = true;
            }

            var root = new ContentPage();
            root.Content = new LoginView {BindingContext = new LoginViewModel(root)};
            return root.GetOouiElement();
        }
    }
}