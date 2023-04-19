using Proj_Web_API.Models;
using Proj_Web_API.Repositories;

namespace Proj_Web_API.Services
{
    public class ToolService
    {
        private IToolRepository _toolRepository;

        public ToolService()
        {
            _toolRepository = new ToolRepository();
        }
        public bool Insert(Tool tool)
        {
            return _toolRepository.Insert(tool);
        }

        public List<Tool> GetAll()
        {
            return _toolRepository.GetAll();
        }
    }
}
