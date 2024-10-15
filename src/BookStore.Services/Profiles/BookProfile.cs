using AutoMapper;
using BookStore.Dto.Requests;
using BookStore.Dto.Responses;
using BookStore.Entities;

namespace BookStore.Services.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookResponseDto>();
            CreateMap<BookRequestDto, Book>();
        }
    }
}
