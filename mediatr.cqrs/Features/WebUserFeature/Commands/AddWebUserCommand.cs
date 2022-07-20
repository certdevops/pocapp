using core.db.Data.Models;
using mediatr.cqrs.Features.WebUserFeature.ViewModel;
using MediatR;

public class AddWebUserCommand : IRequest<int>
{
    public WebUserViewModel WebUsersModel { get; }
    public AddWebUserCommand(WebUserViewModel _webUsers)
    {
        this.WebUsersModel = _webUsers;
    }
}

public class AddWebUserCommandHandler :IRequestHandler<AddWebUserCommand, int>{
    public AddWebUserCommandHandler()
    {

    }
    public Task<int> Handle(AddWebUserCommand _webUserCommand,CancellationToken _cancellationToken){        
        return Task.FromResult( new WebUserBL().InsertOrUpdate(new WebUsers() { id = 0, CompanyCode = _webUserCommand.WebUsersModel.CompanyCode, EmailID = _webUserCommand.WebUsersModel.EmailID, Username = _webUserCommand.WebUsersModel.Username, UserPassword = _webUserCommand.WebUsersModel.UserPassword,Status=1 }));
    }
}
    