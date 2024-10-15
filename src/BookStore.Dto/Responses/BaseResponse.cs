﻿namespace BookStore.Dto.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; } = default!;
    }
}