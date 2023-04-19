using Proj_Web_API.Models;

namespace Proj_Web_API.Repositories
{
    public interface IToolRepository
    {
        bool Insert(Tool tool);

        List<Tool> GetAll();
    }
}
