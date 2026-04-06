using System;
using System.Collections.Generic;
using System.Text;

namespace BuberDinner.Contracts.Authentication
{
    public record RegisterRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password);
}
