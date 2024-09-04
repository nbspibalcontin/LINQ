using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.LINQ.Interface
{
    public interface IProduct
    {
        IEnumerable<string> GetProductNamesAbovePrice(double minPrice);
    }
}
