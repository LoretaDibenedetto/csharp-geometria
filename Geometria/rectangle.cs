﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangle
    {
        //attributi
        public float rectangleBase;
        public float rectangleHeight;




        //stati





        //costruttore

        public Rectangle(float rectangleBase, float rectangleHeight)
        {
            this.rectangleBase = rectangleBase;
            this.rectangleHeight = rectangleHeight;
        }






        //metodi

        public float CalculateAria() {

           return rectangleBase * rectangleHeight;

        }

        public float CalculatePerimeter()
        {
           

            return 2 *(rectangleBase + rectangleHeight);
        }

        public void stampRectangle()
        {
          Console.WriteLine("—— Rettangolo ——");
          Console.WriteLine("base: {0} cm", rectangleBase);
          Console.WriteLine("altezza: {0} cm", rectangleHeight);
          Console.WriteLine("Perimetro: {0} cm", CalculatePerimeter());
          Console.WriteLine("Area: {0} cm2", CalculatePerimeter());
        }
    }   

}
