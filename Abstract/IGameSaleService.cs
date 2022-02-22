using GameDemo.Entities;
namespace GameDemo.Abstract
{
    public interface IGameSaleService
    {
       void Sale(Game game, User gamer, Campaign campaign);
    }
}