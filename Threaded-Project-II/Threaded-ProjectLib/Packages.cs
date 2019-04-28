using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    public class Packages
    {
        /* Packages class member variables and constructor to add packages, delete packages and perform
         * other dml operations on packages data.
         * Author: Muhammad Islam
         * Created:Jan, 2019         
             */
       // public int packageId { get; set; }
        public string pkgName { get; set; }
        public DateTime pkgStartDate { get; set; }
        public DateTime pkgEndDate { get; set; }
        public string pkgDesc { get; set; }
        public decimal pkgBasePrice { get; set; }
        public decimal pkgAgencyComm { get; set; }
        
        public Packages() { }


    }
}
