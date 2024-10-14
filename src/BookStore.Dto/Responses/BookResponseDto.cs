namespace BookStore.Dto.Responses
{
    public class BookResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Status { get; set; }
    }
}
