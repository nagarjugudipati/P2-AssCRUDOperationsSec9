using System;
using System.Collections.Generic;

namespace CRUDOperationsSec9.Controllers
{
    internal class School1Entities1 : IDisposable
    {
        public IEnumerable<object> Students { get; internal set; }

        internal object Entry(object student)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}