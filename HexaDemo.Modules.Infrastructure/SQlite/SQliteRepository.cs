using HexaDemo.Modules.Domain.Entities;
using HexaDemo.Modules.Domain.Interfaces;
using HexaDemo.Modules.Domain.QueryObjects;

namespace HexaDemo.Modules.Infrastructure.SQlite;

public class SQliteRepository : ITodoRepository
{
    //Todo: Implement the repository
    private ITodoRepository _todoRepositoryImplementation;
    public Task<User> GetUser(Guid userId)
    {
        return _todoRepositoryImplementation.GetUser(userId);
    }

    public Task CreateUser(User user)
    {
        return _todoRepositoryImplementation.CreateUser(user);
    }

    public Task<Card> GetCard(Guid cardId)
    {
        return _todoRepositoryImplementation.GetCard(cardId);
    }

    public Task CreateCard(CreateCardQueryObject card)
    {
        return _todoRepositoryImplementation.CreateCard(card);
    }
}