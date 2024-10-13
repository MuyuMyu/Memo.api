using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.api.Context.Repository
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(MemoContext dbContext) : base(dbContext)
        {
        }
    }
}