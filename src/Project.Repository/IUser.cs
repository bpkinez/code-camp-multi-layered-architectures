using System;

namespace Project.Repository
{
    public interface IUser
    {
        string Description { get; set; }
        string FirstName { get; set; }
        Guid Id { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
    }
}
