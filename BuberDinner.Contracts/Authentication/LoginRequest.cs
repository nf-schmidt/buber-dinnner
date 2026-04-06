using System;
using System.Collections.Generic;
using System.Text;

namespace BuberDinner.Contracts.Authentication
{
    public record LoginRequest (
        string Email,
        string Password);
}
