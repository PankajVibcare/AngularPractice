using System.Data.Entity;
using WebApplication1.Data;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class HomeService : HomeInterface
    {
        private readonly AngularProjectContext _projectContext;
        public HomeService(AngularProjectContext projectContext) 
        {
            _projectContext = projectContext;
        }

        public async Task<dynamic>Get()
        {
          var getUserData=_projectContext.Infos.ToList();
          var UserOutput=new List<dynamic>();
          UserOutput.AddRange(getUserData);
          return UserOutput;
        }
    }
}
