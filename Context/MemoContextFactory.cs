using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Memo.api.Context
{
    public class MemoContextFactory : IDesignTimeDbContextFactory<MemoContext>
    {
        public MemoContext CreateDbContext(string[] args)
        {
            // 获取配置文件路径
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // 从配置文件中读取连接字符串
            var connectionString = configuration.GetConnectionString("MemoConnection");

            var optionsBuilder = new DbContextOptionsBuilder<MemoContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new MemoContext(optionsBuilder.Options);
        }
    }
}
