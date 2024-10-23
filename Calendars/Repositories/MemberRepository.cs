using Calendars.Interfaces;
using Calendars.Models;
using Calendars.Utilities;
using Dapper;

namespace Calendars.Repositories
{
    public class MemberRepository : IMember
    {
        private readonly DbContext _dbContext;
        // 在建構子中初始化DbContext 服務
        public MemberRepository(DbContext dbContext)
        {
            // 注入DbContext 服務
            _dbContext = dbContext;
        }
        // 查詢所有Member資料的實作
        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            // 設定查詢用的SQL 語法
            string sqlQuery = "SELECT * FROM Member";
            // 建立資料庫連線
            using (var connection = _dbContext.CreateConnection())
            {
                // 執行查詢
                var members = await connection.QueryAsync<Member>(sqlQuery);
                return members.ToList();
            }
        }
    }
    }
