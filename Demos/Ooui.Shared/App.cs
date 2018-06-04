using System;

namespace Ooui.Shared
{
    public class App
    {
        public Div Element { get; }
        private Div Root { get; }
        public App()
        {
            Root = new Div()
            {
                Style =
                {
                    ["max-width"] = "600px",
                    MarginTop = "100px",
                }
            };
            Element = new Div();
            Element
                .AppendChild(new Center())
                .AppendChild(Root);
            Navigate(LoginPage());
        }

        void Navigate(Element element)
        {
            if (Root.FirstChild != null)
                Root.RemoveChild(Root.FirstChild);
            Root.AppendChild(element);
        }

        Element LoginPage()
        {
            
            var message = new Div();
            var login = new TextInput() {ClassName = "form-control"};
            var password = new TextInput() {Type = InputType.Password, ClassName = "form-control"};
            var button = new Button("Login") {IsDisabled = true, ClassName = "btn btn-primary", Style = { MarginTop = "5px"}};
            var form = new Div(
                message,
                new Label("Login"),
                login,
                new Div(),
                new Label("Password"),
                password,
                new Div(),
                button);

            void CheckEnable() => button.IsDisabled =
                string.IsNullOrWhiteSpace(login.Value) || string.IsNullOrWhiteSpace(password.Value);

            login.KeyUp += delegate { CheckEnable(); };
            password.KeyUp += delegate { CheckEnable(); };
            password.PropertyChanged += delegate { CheckEnable(); };
            login.PropertyChanged += delegate { CheckEnable(); };
            
            button.Click += delegate
            {
                if (login.Value == "admin" && password.Value == "123")
                    Navigate(MainPage());
                else
                {
                    message.Text = "Invalid username or password";
                    password.Value = "";
                    password.Focus();
                }
            };
            return form;
        }

        private Element MainPage()
        {
            var page = new Div();
            page.AppendChild(new TextNode("Login successful"));
            return page;
        }

    }
}