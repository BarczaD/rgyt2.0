using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Database
{
    public interface IDatabaseContext
    {
        void Open();
        void Close();
    }

}
