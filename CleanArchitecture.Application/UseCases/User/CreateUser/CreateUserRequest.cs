﻿using MediatR;

namespace CleanArchitecture.Application.UseCases.User.CreateUser
{
  public sealed record CreateUserRequest(string Email, string Name) : 
                                    IRequest<CreateUserResponse>;
}
