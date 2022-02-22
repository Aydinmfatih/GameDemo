using GameDemo.Entities;
using GameDemo.Abstract;
namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaign
    {
        void Add(Campaign campaign)
        {
            System.Console.WriteLine("Added campaign : " + campaign.CompaignName);
        }
        void Update(Campaign campaign)
        {
            System.Console.WriteLine("Updated campaign : " + campaign.CompaignName);
        }
        void Delete(Campaign campaign)
        {
            System.Console.WriteLine("Deleted campaign : " + campaign.CompaignName);
        }
    }
}