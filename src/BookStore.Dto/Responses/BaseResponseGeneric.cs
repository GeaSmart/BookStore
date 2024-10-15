namespace BookStore.Dto.Responses
{
    public class BaseResponseGeneric<T> : BaseResponse
    {
        public T Data { get; set; } = default!;
    }
}