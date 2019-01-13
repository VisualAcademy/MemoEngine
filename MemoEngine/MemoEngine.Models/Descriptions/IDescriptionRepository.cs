using Dul.Data;

namespace MemoEngine.Models
{
    public interface IDescriptionRepository : IBreadShop<Description>
    {
        Description GetDescription();
        void PostDescription(Description model);
    }
}

