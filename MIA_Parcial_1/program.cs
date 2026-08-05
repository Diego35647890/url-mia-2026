
class Program
{

    static void Main()
{

Console.Write("Ingrese su nombre");
        string nombre = Console.ReadLine();

        
Console.Write("Ingrese la ruta del archivo");
        string ruta = Console.ReadLine();

if (!File.Exists(ruta))
        {
            Console.WriteLine("El archivo no existe");
            return;
        }

        
string[] lineas = File.ReadAllLines(ruta);
string texto = File.ReadAllText(ruta);

int numLineas = lineas.Length;
int numPalabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;int numCaracteres = texto.Length;

using (StreamWriter sw = new StreamWriter(archivoCSV))
{
    sw.WriteLine("Usuario,Archivo,Lineas,Palabras,Caracteres");
    sw.WriteLine(nombre + "," + ruta + "," + numLineas + "," + numPalabras + "," + numCaracteres);
}

Console.WriteLine();
Console.WriteLine("Usuario: " + nombre);
Console.WriteLine("Archivo: " + ruta);
Console.WriteLine("El archivo contiene: " + numLineas + " lineas, " +
                  numPalabras + " palabras, " +
                  numCaracteres + " caracteres");
Console.WriteLine("Resultados guardados en " + archivoCSV);
 }
 }
