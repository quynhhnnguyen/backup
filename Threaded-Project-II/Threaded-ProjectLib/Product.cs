using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThreadedProjectLib
{
    public class Product
    {
        /* Author: Jeremiah Lobo
         * Date: Jan - 5 - 2018
         */
        public int ProductId;
        public string ProductName;

        public override string ToString() => "" + this.ProductName;

    }
}
