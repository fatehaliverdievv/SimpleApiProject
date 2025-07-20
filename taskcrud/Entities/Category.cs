namespace taskcrud.Entities
{
    public class Category
    {
        public int Id {get; set;} 
        public string Name {get; set;} = null!;
        public bool IsEnable { get; set; } = true;
        public DateTime CreateDateTime { get; set; } = DateTime.UtcNow;
    }
}
