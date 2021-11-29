using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concreate
{
    public class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DOGANPC\\SQLEXPRESS;database=coreblockdata;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.Sender)
                .WithMany(x => x.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.Receiver)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }



        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<NewsLatter> newsLatters { get; set; }
        public DbSet<BlogRayting> blogRaytings { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Message2> messages2 { get; set; }


    }
}



