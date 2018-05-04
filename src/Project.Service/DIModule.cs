using Ninject;
using Project.Service.Common;

namespace Project.Service
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        public override void Load()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<ICompanyService>().To<CompanyService>();
        }

        #endregion Methods
    }
}