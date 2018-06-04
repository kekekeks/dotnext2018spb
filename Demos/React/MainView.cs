using Bridge;
using Bridge.React;

namespace React
{
    public class MainView : ComponentBase<MainView.Props, MainView.State>
    {
        public class Props
        {
            
        }
        
        public class State
        {
            public bool LoggedIn { get; set; }
        }


        public override ReactElement Render()
        {
            if (state?.LoggedIn == true)
                return DOM.Div("Login successful!");
            return new LoginView(new LoginView.Props()
            {
                OnComplete = () =>
                    UpdateState(s => s.LoggedIn = true)
            });
        }

        public MainView(Props props, params Union<ReactElement, string>[] children) : base(props, children)
        {
        }
    }
}