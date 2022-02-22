using System.Linq;
using System.Threading.Tasks;
using System.Text;
using GameDemo.Abstract;

using GameDemo.Entities;
namespace GameDemo.Concrete
{
    public class UserManager : IUser
    {
        public UserManager()
        {

        }

        private IPersonCheckService personCheckService;
        public UserManager(IPersonCheckService personCheckService)
        {
            personCheckService = personCheckService;
        }
        void Save(User user)
        {
            if (personCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine(user.FirstName);
            }
            else
            {
                Console.WriteLine("Check your username or password");
            }
        }
        void Update(User user)
        {
        }
        void Delete(User user)
        {

        }
    }
}