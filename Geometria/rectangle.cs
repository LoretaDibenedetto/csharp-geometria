using System;
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

        public float RectangleAria(float rectangleBase, float rectangleHeight) {

         float ariaRectangle = rectangleBase * rectangleHeight;
        
         return ariaRectangle;
        
        }

        public float Perimeter(float rectangleBase, float rectangleHeight)
        {
           float perimeterRectangle = rectangleBase + rectangleHeight * 2 ;

           return perimeterRectangle;
        }


    }   

}
