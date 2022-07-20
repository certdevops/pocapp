

using core.db.Data.Models;

public class WebUserBL{
    WebUsersRepository _webUserRepository=null;
    public WebUserBL()
    {
        _webUserRepository=new WebUsersRepository();
    }

    public int InsertOrUpdate(WebUsers entity){
        _webUserRepository.Add(entity);
        return entity.id;
    }
}