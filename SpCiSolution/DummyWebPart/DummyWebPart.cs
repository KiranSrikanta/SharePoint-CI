using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SpCiSolution
{
    [ToolboxItemAttribute(false)]
    public class DummyWebPart : WebPart
    {
        protected override void CreateChildControls()
        {
            var lblMessage = new LiteralControl(GetDummyMessage());
            this.Controls.Add(lblMessage);
        }

        public string GetDummyMessage()
        {
            return "Nothing to see here";
        }
    }
}
