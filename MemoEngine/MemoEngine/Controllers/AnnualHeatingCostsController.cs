using System.Collections.Generic;
using System.Web.Http;

namespace MemoEngine.Controllers
{
    public class AnnualHeatingCostsController : ApiController
    {
        private readonly IAnnualHeatingCostsRepository _repository;

        public AnnualHeatingCostsController()
        {
            _repository = new AnnualHeatingCostsRepositoryInMemory();
        }

        // Route 특성을 사용하여 API 라우팅 재 정의: 특성 라우팅(어트리뷰트 라우팅)  
        [Route("api/Charts/AnnualHeatingCosts")]
        [HttpGet]
        public IEnumerable<HeatingCost> Get(string chartName = "heatingCosts")
        {
            return _repository.GetHeatingCosts(); 
        }
    }
}
