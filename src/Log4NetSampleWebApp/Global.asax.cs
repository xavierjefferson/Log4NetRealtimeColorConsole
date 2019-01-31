using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Log4NetSampleWebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Global() : base()
        {
        }

        public void Application_Start(object sender, EventArgs e)
        {
            Log.Info("Application_Start...");
        }

        public void Session_Start(object sender, EventArgs e)
        {
            Log.Info("Session_Start: " + Session.SessionID);
        }

        public void Application_BeginRequest(object sender, EventArgs e)
        {
            Log.Debug("Application_BeginRequest: " + Request.Url.ToString());
        }
    }
}