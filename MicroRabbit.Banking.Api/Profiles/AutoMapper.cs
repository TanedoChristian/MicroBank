using AutoMapper;
using MicroRabbit.Banking.Api.DTO;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Api.Profiles
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Account, AccountDto>().ReverseMap();
        }
    }
}
