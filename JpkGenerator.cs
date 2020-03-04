using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using JPK_generator.Model;
using JPK_generator.XSD;

namespace JPK_generator
{
    class JpkGenerator
    {

        public IList<string> GenerateJpk(IList<invoice> invoices, DateTime dateFrom, DateTime dateTo)
        {
            List<string> errorMsgs = new List<string>();
            JPK jpk = new JPK();

            
            return errorMsgs;
        }

    }
}
