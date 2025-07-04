﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.CreateUser
{
  public sealed class CreateUserResponse
  {
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
  }
}