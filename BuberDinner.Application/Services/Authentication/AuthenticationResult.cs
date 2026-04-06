using System;
using System.Collections.Generic;
using System.Text;

namespace BuberDinner.Application.Services.Authentication
{
    public record AuthenticationResult(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token);    
}
