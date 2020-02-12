using System;
using System.Linq;
using Zkbio.Api.Model.Attendance;
using Zkbio.Data.Model.Attendance;

namespace Zkbio.Queries.Attendance
{
    public class AttendanceQueries : IAttendanceQueries
    {
        public IQueryable<AccTransaction> GetStudentPucnhStatus(TransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
