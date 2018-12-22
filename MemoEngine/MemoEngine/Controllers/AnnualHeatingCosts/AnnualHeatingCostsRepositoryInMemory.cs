using System.Collections.Generic;

namespace MemoEngine.Controllers
{
    public class AnnualHeatingCostsRepositoryInMemory : IAnnualHeatingCostsRepository
    {
        public List<HeatingCost> GetHeatingCosts()
        {
            List<HeatingCost> costs = new List<HeatingCost>();

            // 1월부터 12월까지의 난방 비용 리스트 채우기: DB, 인-메모리(테스트)
            costs.Add(new HeatingCost { Month = 1, Cost = 10000 });
            costs.Add(new HeatingCost { Month = 2, Cost = 9000 });
            costs.Add(new HeatingCost { Month = 3, Cost = 8000 });
            costs.Add(new HeatingCost { Month = 4, Cost = 7000 });
            costs.Add(new HeatingCost { Month = 5, Cost = 5000 });
            costs.Add(new HeatingCost { Month = 6, Cost = 3000 });
            costs.Add(new HeatingCost { Month = 7, Cost = 1000 });
            costs.Add(new HeatingCost { Month = 8, Cost = 0 });
            costs.Add(new HeatingCost { Month = 9, Cost = 2000 });
            costs.Add(new HeatingCost { Month = 10, Cost = 5000 });
            costs.Add(new HeatingCost { Month = 11, Cost = 9000 });
            costs.Add(new HeatingCost { Month = 12, Cost = 12000 });

            return costs;
        }
    }
}
