using System;
using Ooui.Shared;
using Ooui.Shared.Forms;

namespace Ooui.Browser
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            UI.Publish("/", new App().Element);
            UI.Publish("/forms", FormsApp.GetFormsApp());
        }
    }
}