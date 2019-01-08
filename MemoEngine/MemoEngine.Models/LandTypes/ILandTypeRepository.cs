using System.Collections.Generic;

namespace MemoEngine.Models.LandTypes
{
    public interface ILandTypeRepository
    {
        List<LandTypeDto> GetLandTypes();
    }
}