using Microsoft.EntityFrameworkCore;

namespace Bulkyweb;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options)
    {
        
    }

}
