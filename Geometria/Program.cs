
using Geometria;
/*Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console,
 * i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, 
 * stampate a video il perimetro e l’area del rettangolo che avete costruito.*/

Console.WriteLine("Inserisci la base del rettangolo: ");
float baseRectangle = float.Parse(Console.ReadLine());


Console.WriteLine("Inserisci l'altezza del rettangolo: ");
float heightRectangle = float.Parse(Console.ReadLine());


Rectangle rettangolo1 = new Rectangle(baseRectangle, heightRectangle);

Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("il Perimetro del rettangolo e': " + rettangolo1.CalculatePerimeter());
Console.WriteLine("l'aria del rettangolo e': " + rettangolo1.CalculateAria());
Console.WriteLine("-----------------------------------------------------------");

rettangolo1.stampRectangle();

rettangolo1.draw();



Rectangle rettangolo2 = new Rectangle(15, 5);
rettangolo2.stampRectangle();