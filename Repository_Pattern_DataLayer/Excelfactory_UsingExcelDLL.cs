using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Pattern_DataLayer.Interfaces;

namespace Repository_Pattern_DataLayer
{
    using Excel;

    public class Excelfactory_UsingExcelDLL : IExcelFactory
    {

        public T GetExcelData<T>()
        {
            throw new NotImplementedException();
        }

        public bool AddExcelData()
        {
            throw new NotImplementedException();
        }

        public bool RemoveExcelData()
        {
            throw new NotImplementedException();
        }
    }
}
