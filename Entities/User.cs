using GameDemo.Abstract;
namespace GameDemo.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Name { get; set; }
        
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        
        
        
        

      




    }
}