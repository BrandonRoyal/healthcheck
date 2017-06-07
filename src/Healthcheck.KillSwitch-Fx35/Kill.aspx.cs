using System;
using System.IO;

namespace Healthcheck.KillSwitch
{
    public partial class Kill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Path.GetTempPath();
            var deadfile = Path.Combine(path, "dead");
            File.WriteAllText(deadfile, "I kicked the bucket");
            Message.Text = String.Format("deadfile writtent to: {0}", deadfile);
        }
    }
}