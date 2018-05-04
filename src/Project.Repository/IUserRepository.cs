using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public interface IUserRepository
    {
        #region Methods

        List<IUser> Get();

        #endregion Methods
    }
}
