using System.Collections.Generic;

namespace MemoEngine.Controllers
{
    public class AnnualHeatingCostsRepository: IAnnualHeatingCostsRepository
    {
        public List<HeatingCost> GetHeatingCosts()
        {
            List<HeatingCost> costs = new List<HeatingCost>();

            // 여기는 실제 데이터베이스에서 특정 조건에 맞는 연간 난방 비용이 저장되는 곳

            // 1월부터 12월까지의 난방 비용 리스트 채우기: DB, 인-메모리(테스트)
            costs.Add(new HeatingCost { Month = 1, Cost = 10000 });
            costs.Add(new HeatingCost { Month = 2, Cost = 9000 });
            costs.Add(new HeatingCost { Month = 3, Cost = 8000 });
            costs.Add(new HeatingCost { Month = 4, Cost = 7000 });
            costs.Add(new HeatingCost { Month = 5, Cost = 5000 });
            costs.Add(new HeatingCost { Month = 6, Cost = 3000 });

            return costs;
        }
    }
}
