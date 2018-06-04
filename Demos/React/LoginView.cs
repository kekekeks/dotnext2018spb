using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace React
{
    public class LoginView : ComponentBase<LoginView.Props, LoginView.State>
    {
        public class Props
        {
            public Action OnComplete { get; set; }
        }
        
        public class State
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Message { get; set; }
        }

        public LoginView(Props props, params Union<ReactElement, string>[] children) : base(props, children)
        {
        }

        public override ReactElement Render()
        {
            return DOM.Div(new Attributes(),
                DOM.Div(state?.Message),
                DOM.Label("Login"),
                DOM.Input(new InputAttributes()
                {
                    OnChange = ev => UpdateState(s => s.Login = ev.CurrentTarget.Value),
                    ClassName = "form-control"
                }),
                DOM.Label("Password"),
                DOM.Input(new InputAttributes()
                {
                    OnChange = ev => UpdateState(s => s.Password = ev.CurrentTarget.Value),
                    Type = InputType.Password,
                    ClassName = "form-control"
                }),
                DOM.Button(new ButtonAttributes()
                {
                    Disabled = string.IsNullOrWhiteSpace(state?.Login)
                               || string.IsNullOrWhiteSpace(state?.Password),
                    OnClick = ev =>
                    {
                        if (state?.Login == "admin" && state?.Password == "123")
                            props.OnComplete();
                        else
                        UpdateState(s =>
                        {
                            s.Message = "Invalid username or password";
                        });
                    },
                    Style = new ReactStyle()
                    {
                        MarginTop = "15px",
                    },
                    ClassName = "btn btn-primary"
                }, "Login"));
        }
    }
}