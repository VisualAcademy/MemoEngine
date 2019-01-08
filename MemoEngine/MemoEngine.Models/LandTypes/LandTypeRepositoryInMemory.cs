using System.Collections.Generic;

namespace MemoEngine.Models.LandTypes
{
    public class LandTypeRepositoryInMemory : ILandTypeRepository
    {
        public List<LandTypeDto> GetLandTypes()
        {
            List<LandTypeDto> landTypes = new List<LandTypeDto>()
            {
                new LandTypeDto { Text = "밭", Value = "0" },
                new LandTypeDto { Text = "논", Value = "1" },
                new LandTypeDto { Text = "집", Value = "2" },
                new LandTypeDto { Text = "땅", Value = "3" },
            };

            return landTypes;
        }
    }
}
