using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abtract
{
    public interface IProductService
    {

        List<Product> GetAll();
    }
}
