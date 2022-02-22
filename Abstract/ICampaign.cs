using GameDemo.Entities;
namespace GameDemo.Abstract
{
    public interface ICampaign
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}