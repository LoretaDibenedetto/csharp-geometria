
using Geometria;

Console.WriteLine("Inserisci la base del rettangolo: ");
float baseRectangle = float.Parse(Console.ReadLine());


Console.WriteLine("Inserisci l'altezza del rettangolo: ");
float heightRectangle = float.Parse(Console.ReadLine());


Rectangle rettangolo1 = new Rectangle(baseRectangle, heightRectangle);
rettangolo1.stampRectangle();


Console.WriteLine("-----------------------------------------------------------");


Rectangle rettangolo2 = new Rectangle(15, 5);
rettangolo2.stampRectangle();