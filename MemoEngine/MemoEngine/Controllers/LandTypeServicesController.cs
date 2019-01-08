using MemoEngine.Models.LandTypes;
using System.Collections.Generic;
using System.Web.Http;

namespace MemoEngine.Controllers
{
    public class LandTypeServicesController : ApiController
    {
        private readonly LandTypeRepositoryInMemory _repository;

        public LandTypeServicesController()
        {
            _repository = new LandTypeRepositoryInMemory();
        }

        [HttpPost]
        [Route("api/LandTypeServices/GetLandTypes")]
        public List<LandTypeDto> GetLandTypes()
        {
            #region +
            //List<LandTypeDto> landTypes = new List<LandTypeDto>()
            //{
            //    new LandTypeDto { Text = "밭", Value = "0" },
            //    new LandTypeDto { Text = "논", Value = "1" },
            //    new LandTypeDto { Text = "집", Value = "2" },
            //};

            //return landTypes; 
            #endregion
            return _repository.GetLandTypes();
        }
    }
}
