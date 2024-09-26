using Microsoft.EntityFrameworkCore;

namespace Memo.api.Context
{
    public class MemoContext : DbContext
    {

        public MemoContext(DbContextOptions<MemoContext> options) : base(options)
        {
            
        }

        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Memo> Memo { get; set; }

    }
}
