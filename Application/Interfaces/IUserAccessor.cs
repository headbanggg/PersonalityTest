using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.Interfaces
{
    public interface IUserAccessor
    {
        string GetUsername();
        string GetUserId();
        Task<AppUser> GetUserAsync();
    }
}