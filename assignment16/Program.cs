using assignment16.Context;
using Microsoft.EntityFrameworkCore;

namespace assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            dbContext.Database.Migrate();
        }
    }
}
