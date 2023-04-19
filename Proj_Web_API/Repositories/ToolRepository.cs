using System.Data.SqlClient;
using Proj_Web_API.Models;
using Dapper;

namespace Proj_Web_API.Repositories
{
    public class ToolRepository : IToolRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Documents\Exercicios_Treino\Proj_Web_API\Proj_Web_API\Mdf\dbTool.mdf";
        public List<Tool> GetAll()
        {
            List<Tool> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var tools = db.Query<Tool>(Tool.GETALL);
                list = (List<Tool>)tools;
            }
            return list;
        }

        public bool Insert(Tool tool)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Tool.INSERT, tool);
            }
            return true;
        }
    }
}
