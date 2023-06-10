using HexaDemo.Modules.Domain.Entities;
using HexaDemo.Modules.Domain.QueryObjects;

namespace HexaDemo.Modules.Domain.Interfaces;

public interface ITodoRepository
{
    Task<User> GetUser(Guid userId);
    Task CreateUser(User user);
    Task<Card> GetCard(Guid cardId);
    Task CreateCard(CreateCardQueryObject card);
}