using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace Log4NetSampleWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private void Page_Init(System.Object sender, System.EventArgs e)
        {
            Log.Info("Page_Init...");
        }

        private void Page_Load(System.Object sender, System.EventArgs e)
        {
            Log.Info("Page_Load...");
        }

        protected void Refresh_Click(System.Object sender, System.EventArgs e)
        {
            Log.Info("Refresh_Click...");
        }

        protected void ThrowError_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Log.Info("ThrowError_Click...");
                throw new ApplicationException("An application error has occurred!", new Exception("Inner Exception"));
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
    }
}