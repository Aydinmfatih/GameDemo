using GameDemo.Entities;
namespace GameDemo.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}