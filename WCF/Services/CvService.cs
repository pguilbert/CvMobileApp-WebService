using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common.Interfaces;
using WCF.Interfaces;
using Cv = Common.Cv;

namespace WCF.Services
{
    public partial class Service : ICvService
    {
        public IEnumerable<Cv> GetCvs()
        {
            IReader<Cv> bussiness = new CvBusiness();
            return bussiness.Get();
        }
    }
}
