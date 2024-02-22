using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_and_Fluent_Builder
{
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(HeaderPart)
            .Append(BodyPart)
            .Append(FooterPart)
            .ToString();
    }
}
