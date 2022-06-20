using System;

namespace lab3_trang.Controllers
{
    internal class ApplicationDdContext
    {
        public object Attendances { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}