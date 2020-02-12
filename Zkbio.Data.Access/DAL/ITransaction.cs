using System;
using System.Collections.Generic;
using System.Text;

namespace Zkbio.Data.Access.DAL
{
   public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
