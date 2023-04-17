using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /* Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.*/
    public class Rectangle
    {
        //attributi
        public float rectangleBase;
        public float rectangleHeight;




        //stati





        //costruttore
        /*Aggiungere un opportuno costruttore con parametri.*/
        public Rectangle(float rectangleBase, float rectangleHeight)
        {
            this.rectangleBase = rectangleBase;
            this.rectangleHeight = rectangleHeight;
        }






        //metodi
        /*Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.*/

        public float CalculateArea()
        {

            float CalculateAriaUser = rectangleHeight * rectangleBase;
            return CalculateAriaUser;
        }

        public float CalculatePerimeter()
        {


            return 2 * (rectangleBase + rectangleHeight);
        }
        /*Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo cambiati)
         * e provate a stampare le loro proprietà ad esempio con un metodo*/
        public void stampRectangle()
        {
            Console.WriteLine("—— Rettangolo ——");
            Console.WriteLine("base: {0} cm", rectangleBase);
            Console.WriteLine("altezza: {0} cm", rectangleHeight);
            Console.WriteLine("Perimetro: {0} cm", CalculatePerimeter());
            Console.WriteLine("Area: {0} cm2", CalculateArea());
        }


        public void draw()
        {
            Console.WriteLine("disegno il rettangolo...");
            for (int i = 0; i < rectangleHeight; i++)
            {
                for (int j = 0; j < rectangleBase; j++)
                {
                        if (i == 0 || i == rectangleHeight -1 )
                        {
                            Console.Write("--");
                        }
                    else if (j == 0 || j == rectangleBase -1)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }

                    

                }

                Console.WriteLine();

            }

        }


    }
    
}
