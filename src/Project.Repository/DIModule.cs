using Ninject;
using Project.Repository.Common;

namespace Project.Repository
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        public override void Load()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<ICompanyRepository>().To<CompanyRepository>();
        }

        #endregion Methods
    }
}