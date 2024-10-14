namespace BookStore.Dto.Requests
{
    public class BookRequestDto
    {        
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Status { get; set; }
    }
}
