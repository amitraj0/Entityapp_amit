using System.Data.Common;
using Microsoft.EntityFrameworkCore;


namespace Entityapp.DataModel
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    }
}
