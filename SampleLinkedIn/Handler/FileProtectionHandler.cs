using System;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Owin.Security.Providers.LinkedIn;

namespace SampleLinkedIn.Handler
{
    public class FileProtectionHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>

        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.
            switch (context.Request.HttpMethod)
            {
                case "GET":
                {
                    // Is the user logged-in?
                    if (!context.User.Identity.IsAuthenticated)
                    {
                          //FormsAuthentication.RedirectToLoginPage();
                        context.Response.Redirect("/Account/Login");
                            // return RedirectToLocal();
                            //return;
                        }
                    string requestedFile = context.Server.MapPath(context.Request.FilePath);
                    // Verify the user has access to the User role.
                    if (context.User.IsInRole("User"))
                    {
                        //SendContentTypeAndFile(context, requestedFile);
                    }
                    else
                    {
                        // Deny access, redirect to error page or back to login page.
                       // context.Response.Redirect("~/User/AccessDenied.aspx");
                    }
                    break;
                }
            }

            #endregion
        }

        
    }
}
