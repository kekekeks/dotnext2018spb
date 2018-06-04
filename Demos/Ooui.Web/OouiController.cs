using Microsoft.AspNetCore.Mvc;
using Ooui.AspNetCore;
using Ooui.Shared;
using Ooui.Shared.Forms;

namespace Ooui.Web
{
    [Route("")]
    public class OouiController : Controller
    {

        [HttpGet("")]
        public object GetFreshUi() => new ElementResult(new App().Element);


        #region Part2
        [HttpGet("forms")]
        public object GetForms() => new ElementResult(FormsApp.GetFormsApp());


        #endregion
    }
}