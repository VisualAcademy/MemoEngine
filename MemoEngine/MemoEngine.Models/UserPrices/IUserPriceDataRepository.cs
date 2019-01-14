using Dul.Data;
using System.Collections.Generic;

namespace MemoEngine.Models
{
    /// <summary>
    /// UserPrices 테이블에 대한 CRUD 정의 리포지토리 인터페이스 
    /// </summary>
    public interface IUserPriceDataRepository : IBreadShop<UserPriceData>
    {
        List<UserPriceData> GetAllByProjectId(int projectId);
        void AddOrUpdate(List<UserPriceData> datas);
        UserPriceData GetByCondition(UserPriceData model);
    }
}
