using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Bank.Todos
{
    public interface ITodoAppService
    {
        Task<PagedResultDto<TodoDto>> GetListAsync();
    }
}