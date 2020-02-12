using System;

namespace Zkbio.Api.Model.Attendance
{
    public class TransactionModel
    {
        public string RoomId { get; set; }
        public DateTime ClassTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public bool AttendanceStatus { get; set; }
    }
}
