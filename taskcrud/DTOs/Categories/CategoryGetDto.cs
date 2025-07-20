namespace taskcrud.DTOs.Categories
{
    public class CategoryGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEnable {  get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
