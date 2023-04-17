
using Geometria;

Console.WriteLine("Inserisci la base del rettangolo: ");
int baseRectangle = int.Parse(Console.ReadLine());


Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int heightRectangle = int.Parse(Console.ReadLine());


Rectangle rettangolo1 = new Rectangle(baseRectangle, heightRectangle);
rettangolo1.stampRectangle();