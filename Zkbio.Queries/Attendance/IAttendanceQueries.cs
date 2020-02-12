using System.Linq;
using Zkbio.Api.Model.Attendance;
using Zkbio.Data.Model.Attendance;

namespace Zkbio.Queries.Attendance
{
    public interface IAttendanceQueries
    {
        IQueryable<AccTransaction> GetStudentPucnhStatus(TransactionModel model);
    }
}
