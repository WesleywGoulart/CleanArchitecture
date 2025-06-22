using AutoMapper;
using DomainUser = CleanArchitecture.Domain.Entities.User;

namespace CleanArchitecture.Application.UseCases.User.CreateUser
{
  public sealed class CreateUserMapper : Profile
  {
    public CreateUserMapper() 
    {
      CreateMap<CreateUserRequest, DomainUser>();
      CreateMap<DomainUser, CreateUserResponse>();
    }
  }
}