using Bridge.Html5;

namespace RazorReact
{
    public class Program
    {

        public static void Main()
        {
            var root = SetupPage();
            Bridge.React.React.Render(new MainView(new MainView.Props()), root);
        }


        static HTMLElement SetupPage()
        {
            AddStyle("lib/bootstrap/css/bootstrap.css");
            var center = Document.CreateElement("center");
            Document.Body.AppendChild(center);
            var root = Document.CreateElement("div");
            root.Style.MaxWidth = "500px";
            center.AppendChild(root);
            return root;
        }
        
        static void AddStyle(string href)
        {
            var style = Document.CreateElement("link");
            style.SetAttribute("rel", "stylesheet");
            style.SetAttribute("type", "text/css");
            style.SetAttribute("href", href);
            Document.Head.AppendChild(style);
        }
    }
}