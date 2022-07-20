using core.db.Data.Models;
using Data.Repository.GenericRepository;
// https://dotnetgenetics.blogspot.com/2021/05/create-aspnet-core-mvc-crud-website.html
public interface IUnitOfWork{
    IRepository<WebUsers> WebUserRepository{get;}
}