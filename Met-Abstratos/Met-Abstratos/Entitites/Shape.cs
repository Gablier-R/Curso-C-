using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Met_Abstratos.Entitites.Enums;

namespace Met_Abstratos.Entitites
{
    abstract class Shape
    {
        public Color Color{ get; set; }


        public Shape(Color color) 
        {
            Color = color;
        }

        public abstract double Area();
    }
}
