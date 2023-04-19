namespace Proj_Web_API.Models
{
    public class Tool
    {
        public static readonly string GETALL = "SELECT Id, Description FROM Tool";
        public static readonly string INSERT = "INSERT INTO Tool (Description) VALUES (@Description)";

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
