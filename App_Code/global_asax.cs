namespace ASP
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Web;
    using System.Web.Profile;

    [CompilerGlobalScope]
    public class global_asax : HttpApplication
    {
        private static bool __initialized;

        [DebuggerNonUserCode]
        public global_asax()
        {
            if (!__initialized)
            {
                __initialized = true;
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            CultureInfo info = new CultureInfo("en-US")
            {
                DateTimeFormat = {
                    ShortDatePattern = "dd/MM/yyyy",
                    DateSeparator = "/"
                }
            };
            Thread.CurrentThread.CurrentCulture = info;
            Thread.CurrentThread.CurrentUICulture = info;
        }

        private void Application_End(object sender, EventArgs e)
        {
            base.Application["ActiveUsers"] = null;
        }

        private void Application_Error(object sender, EventArgs e)
        {
        }

        private void Application_Start(object sender, EventArgs e)
        {
            base.Application["ActiveUsers"] = 0;
        }

        private void Session_End(object sender, EventArgs e)
        {
            base.Session.Abandon();
            base.Application.Lock();
            base.Application["ActiveUsers"] = Convert.ToInt32(base.Application["ActiveUsers"]) - 1;
            base.Application.UnLock();
        }

        private void Session_Start(object sender, EventArgs e)
        {
            base.Session.Timeout = 200;
            base.Session["Start"] = DateTime.Now;
            base.Application.Lock();
            base.Application["ActiveUsers"] = Convert.ToInt32(base.Application["ActiveUsers"]) + 1;
            base.Application.UnLock();
        }

        protected DefaultProfile Profile
        {
            get
            {
                return (DefaultProfile)base.Context.Profile;
            }
        }
    }
}
