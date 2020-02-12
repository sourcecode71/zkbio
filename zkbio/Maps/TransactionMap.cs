using AutoMapper;
using Zkbio.Api.Model.Attendance;
using Zkbio.Data.Model.Attendance;

namespace zkbio.Maps
{
    public class TransactionMap : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<AccTransaction, TransactionModel>();
            map.ForMember(x => x.StudentId, x => x.MapFrom(y => y.pin));
            map.ForMember(x => x.ClassTime, x => x.MapFrom(y => y.event_time));
            map.ForMember(x => x.RoomId, x => x.MapFrom(y => y.dev_alias));
            map.ForMember(x => x.StudentName, x => x.MapFrom(y => y.name + " " + y.last_name));
            map.ForMember(x => x.AttendanceStatus, x => x.MapFrom(y => !string.IsNullOrEmpty(y.pin)));
        }
    }
}
