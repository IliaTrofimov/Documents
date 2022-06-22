using System;
using System.Data.Entity;
using System.Linq;

namespace Documents_notifications
{
    public class Program
    {
        public static void Main()
        {
            DataContext db = new DataContext();
            DateTime now = DateTime.Now;
            int count = Mailing.ExpireNotification(db.Documents.Include("Author").Where(d =>
                d.ExpireDate.HasValue && (DbFunctions.DiffDays(d.ExpireDate, now) == 0
                || DbFunctions.DiffDays(d.ExpireDate, now) == 1 || DbFunctions.DiffDays(d.ExpireDate, now) == 3
                || DbFunctions.DiffDays(d.ExpireDate, now) == 7 || DbFunctions.DiffDays(d.ExpireDate, now) == 30)
            ));
            Console.WriteLine($"Sent {count} emails");
            Console.ReadKey();
        }
    }
}
