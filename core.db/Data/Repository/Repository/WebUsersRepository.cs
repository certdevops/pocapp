using core.db.Data.Models;
using Data.Repository.GenericRepository;
using Data.Repository.IRepository;

public class WebUsersRepository: Repository<WebUsers>, IWebUserRepository
    {
        public WebUsersRepository()
        {
            RepoDb.SqlServerBootstrap.Initialize();
        }
        
        
    }