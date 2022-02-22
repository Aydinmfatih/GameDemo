using System.Linq;
using System.Threading.Tasks;
using System.Text;
using GameDemo.Entities;
namespace GameDemo.Abstract
{
    public class IUser
    {
        
        void Save(User user);
        void Update(User user);
        void Delete(User user);
    }
}