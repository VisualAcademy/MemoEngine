using Dapper;
using Dul.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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

        public List<UserPriceData> GetAllByProjectId(int projectId)
        {
            string sql = "Select * From UserPrices Where ProjectId = @ProjectId";
            return db.Query<UserPriceData>(sql, new { ProjectId = projectId }).ToList();
        }

        public void AddOrUpdate(List<UserPriceData> datas)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i] != null)
                {
                    string countQuery = "Select Count(*) From UserPrices Where ProjectId = @ProjectId And [Year] = @Year And Num = @Num";
                    int cnt = db.Query<int>(countQuery, 
                        new { ProjectId = datas[i].ProjectId, Year = datas[i].Year, Num = datas[i].Num }).SingleOrDefault();
                    if (cnt > 0)
                    {
                        // Update
                        string updateQuery = "Update UserPrices Set StandardPrice = @StandardPrice, UserPrice = @UserPrice " +
                            "Where ProjectId = @ProjectId And [Year] = @Year And Num = @Num";
                        db.Execute(updateQuery, datas[i]);
                    }
                    else
                    {
                        // Insert
                        string insertQuery = "Insert Into UserPrices (ProjectId, Num, [Year], StandardPrice, UserPrice) " +
                            "Values (@ProjectId, @Num, @Year, @StandardPrice, @UserPrice)";
                        db.Execute(insertQuery, datas[i]);
                    }
                }
            }
        }

        public UserPriceData GetByCondition(UserPriceData model)
        {
            string sql = "Select * From UserPrices Where ProjectId = @ProjectId And Num = @Num And [Year] = @Year";
            return db.Query<UserPriceData>(sql, model).SingleOrDefault(); 
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
