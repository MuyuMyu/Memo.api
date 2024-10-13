using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.api.Context.Repository
{
    public class MemoRepository : Repository<Context.Memo>, IRepository<Context.Memo>
    {
        public MemoRepository(MemoContext dbContext) : base(dbContext)
        {

        }
    }
}