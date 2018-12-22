using System.Collections.Generic;

namespace MemoEngine.Controllers
{
    public interface IAnnualHeatingCostsRepository
    {
        List<HeatingCost> GetHeatingCosts();
    }
}
