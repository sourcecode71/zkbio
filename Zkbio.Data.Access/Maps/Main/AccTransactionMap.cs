using Microsoft.EntityFrameworkCore;
using Zkbio.Data.Model.Attendance;

namespace Zkbio.Data.Access.Maps.Main
{
    public class AccTransactionMap : IMap
    {
        public void Visit(ModelBuilder builder)
        {
            builder.Entity<AccTransaction>()
                 .ToTable("acc_transaction")
                 .HasKey(x => x.Id);
        }
    }
}
