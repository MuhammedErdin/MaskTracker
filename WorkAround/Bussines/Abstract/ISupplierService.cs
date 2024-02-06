using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkAround.Entities.Concrete;

namespace WorkAround.Bussines.Abstract
{
    public interface ISupplierService
    {
        void GiveMask(Person person);
    }
}
