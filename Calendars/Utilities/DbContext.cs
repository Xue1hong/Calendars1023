using System.Data;
namespace Calendars.Utilities
{
    public class DbContext
    {
        // 用於儲存DI(Dependency Injection）的IConfiguration 實例
        private readonly IConfiguration _configuration;
        // 用來儲存資料庫連接字串
        private readonly string _connectionString;
        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            // 讀取名稱為CalendarContext 的連接字串
            // 將其儲存在_connectionString 變數中
            _connectionString = _configuration.GetConnectionString("CalendarContext");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
