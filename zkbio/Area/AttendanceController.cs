using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using zkbio.Filter;
using zkbio.Maps;
using Zkbio.Api.Model.Attendance;
using Zkbio.Data.Model.Attendance;
using Zkbio.Queries.Attendance;

namespace zkbio.Area
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceQueries _query;
        private readonly IAutoMapper _mapper;
        public AttendanceController(IAttendanceQueries attendanceQueries , IAutoMapper autoMapper)
        {
            _query = attendanceQueries;
            _mapper = autoMapper;
        }

        [HttpGet("{roomid}/student")]
        [QueryableResult]
        public IQueryable<TransactionModel> Get(string roomid)
        {
            TransactionModel attendancePunchModel = new TransactionModel
            {
                RoomId = roomid,
                ClassTime = DateTime.Now
            };

            var StdAtt = _query.GetStudentPucnhStatus(attendancePunchModel);
            var model = _mapper.Map<AccTransaction, TransactionModel>(StdAtt);
            return model;
        }
    }
}