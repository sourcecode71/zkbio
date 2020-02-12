using Microsoft.EntityFrameworkCore;

namespace Zkbio.Data.Access.Maps
{
    public interface IMap
    {
        void Visit(ModelBuilder builder);
    }
}
