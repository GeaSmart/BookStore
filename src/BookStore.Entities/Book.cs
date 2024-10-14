namespace BookStore.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Status { get; set; }
    }
}
