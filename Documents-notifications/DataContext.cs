using Documents_Entities.Entities;
using System.Data.Entity;

namespace Documents_notifications
{
    internal class DataContext : DbContext
    {
        public virtual DbSet<Document> Documents { get; set; }
    }
}
