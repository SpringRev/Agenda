using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace PersonalScheduleApi.Models
{
    public class PersonalScheduleContext: DbContext
    {
        public PersonalScheduleContext(DbContextOptions<PersonalScheduleContext> options) : base(options)
        { 
        }

        public DbSet<PersonalScheduleItem> PersonalScheduleItems { get; set; } = null!;
    }
}
