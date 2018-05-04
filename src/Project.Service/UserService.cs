using Project.DAL.Entities;
using Project.Repository;
using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class UserService : IUserService
    {
        #region Constructors

        public UserService(IUserRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        protected IUserRepository Repository { get; private set; }

        #endregion Properties

        #region Methods

        public List<User> Get()
        {
            return new List<User>();
            //return Repository.Get();
        }

        #endregion Methods
    }
}