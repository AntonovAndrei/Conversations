using Conversations.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Conversations.Data
{
    public class ConversationDbContext: DbContext
    {
        public ConversationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
