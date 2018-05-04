using System;

namespace Project.Repository
{
    public class User : IUser
    {
      public string Description { get; set; }
      public string FirstName { get; set; }
      public Guid Id { get; set; }
      public string LastName { get; set; }
      public string UserName { get; set; }
    }
}
