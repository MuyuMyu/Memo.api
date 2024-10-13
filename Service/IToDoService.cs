using Memo.Shared.Parameters;
using Memo.Shared.Dtos;

namespace Memo.api.Service
{
    public interface IToDoService : IBaseService<ToDoDto>
    {
        Task<ApiResponse> GetAllAsync(ToDoParameter query);

        Task<ApiResponse> Summary();
    }
}
