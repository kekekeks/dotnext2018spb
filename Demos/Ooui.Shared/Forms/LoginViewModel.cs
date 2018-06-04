using System.Windows.Input;
using Xamarin.Forms;

namespace Ooui.Shared.Forms
{
    public class LoginViewModel
    {
        private readonly ContentPage _root;

        public LoginViewModel(ContentPage root)
        {
            _root = root;
        }
        
        public string Login { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }
        public ICommand DoLogin => new Command(() =>
        {
            if (Login == "admin" && Password == "123")
                _root.Content = new MainView();
            else
                Error = "Invalid username or password";
        });
    }
}