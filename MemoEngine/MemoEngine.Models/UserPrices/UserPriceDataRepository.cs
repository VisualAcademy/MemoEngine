using Dul.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MemoEngine.Models
{
    /// <summary>
    /// UserPrices 테이블에 대한 CRUD 정의 리포지토리 클래스
    /// </summary>
    public class UserPriceDataRepository : IUserPriceDataRepository
    {
        private readonly IDbConnection db;

        public UserPriceDataRepository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

        public UserPriceData Add(UserPriceData model)
        {
            throw new NotImplementedException();
        }

        public UserPriceData Browse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(UserPriceData model)
        {
            throw new NotImplementedException();
        }

        public int Has()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserPriceData> Ordering(OrderOption orderOption)
        {
            throw new NotImplementedException();
        }

        public List<UserPriceData> Paging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<UserPriceData> Read()
        {
            throw new NotImplementedException();
        }

        public List<UserPriceData> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
