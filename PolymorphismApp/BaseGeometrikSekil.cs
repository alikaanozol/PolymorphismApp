using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    public class BaseGeometrikSekil   // BaseGeometrikSekil nesnelerinin tanımlanması ||Identifying BaseGeometricShape objects
    {
        public int Width { get; set; }
        public int Height { get; set; }

    public virtual void CalculateArea()
        {
           int area= Width * Height;
            Console.WriteLine($"Alan : {area}");
        }
    }

    public class Square : BaseGeometrikSekil 
    {
        public override void CalculateArea()
        {
            base.CalculateArea();
        }
    }
    public class Rectangle : BaseGeometrikSekil
    {
        public override void CalculateArea()
        {
            base.CalculateArea();
        }
    }

    public class RightTriangle : BaseGeometrikSekil
    {
        public override void CalculateArea()
        {
            int area = (Width * Height) / 2;
            Console.WriteLine($"Alan : {area}");

        }
    }

}
