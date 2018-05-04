using Project.Repository;
using System.Collections.Generic;

namespace Project.Service
{
    public interface IUserService
    {
        List<User> Get();
    }
}
