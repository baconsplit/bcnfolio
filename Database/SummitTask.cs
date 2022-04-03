namespace Bcnfolio.Database
{
    public class SummitTask
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; }
    }
}