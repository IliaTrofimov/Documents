using Documents_notifications;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Text;
using System.IO;

namespace Documents_notifier
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            DataContext db = new DataContext();
            DateTime now = DateTime.Now;
            Mailing.ExpireNotification(db.Documents.Include("Author").Where(d =>
                d.ExpireDate.HasValue && (DbFunctions.DiffDays(d.ExpireDate, now) == 0
                || DbFunctions.DiffDays(d.ExpireDate, now) == 1 || DbFunctions.DiffDays(d.ExpireDate, now) == 3
                || DbFunctions.DiffDays(d.ExpireDate, now) == 7 || DbFunctions.DiffDays(d.ExpireDate, now) == 30)
            ));

            var s = File.Open("C:\\Users\\iliat\\Desktop\\s.txt", FileMode.Append);
            using(var writter = new StreamWriter(s))
            {
                writter.WriteLine($"New item - {DateTime.Now}");
            }
        }
    }
}
