using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Dul.Data;
using System.Linq; 

namespace MemoEngine.Models
{
    public class DescriptionRepository : IDescriptionRepository
    {
        private readonly IDbConnection db;

        public DescriptionRepository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

        /// <summary>
        /// 현재 사용하고 있는 설명서 데이터 전체 가져오기 
        /// </summary>
        /// <returns></returns>
        public Description GetDescription()
        {
            string sql = "Select Top 1 * From Descriptions Order By Id Desc";
            return db.Query<Description>(sql).SingleOrDefault();
        }

        /// <summary>
        /// 설명서 데이터가 변경되면 새로운 레코드 추가 
        /// </summary>
        /// <param name="model">설명서 데이터</param>
        public void PostDescription(Description model)
        {
            string sql = "Insert Into Descriptions (SiteName, SiteDescription, UserGuide) Values (@SiteName, @SiteDescription, @UserGuide)";
            db.Execute(sql, model);
        }

        public Description Add(Description model)
        {
            throw new System.NotImplementedException();
        }

        public Description Browse(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Description model)
        {
            throw new System.NotImplementedException();
        }

        public int Has()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Description> Ordering(OrderOption orderOption)
        {
            throw new System.NotImplementedException();
        }

        public List<Description> Paging(int pageNumber, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public List<Description> Read()
        {
            throw new System.NotImplementedException();
        }

        public List<Description> Search(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}

