internal class Program
{
    private static void Main(string[] args)
    {
        int numMenu = IngresarEntero("1. Cargar los datos del sujeto 1. | 2. Cargar los datos del sujeto 2. | 3. Iniciar la pelea. | 4. Salir. ");
        
        switch(){
            case 1: 
                string nombre = IngresarString("Ingrese el nombre del boxeador: ");
                string pais = IngresarString("Ingrese el país de origen del sujeto: ");
                int peso = IngresarEntero("Ingrese el peso: ");
                int pG = IngresarEntero("Ingrese la potencia de los golpes de " + nombre + ":");
                int vP = IngresarEntero("Ingrese la velocidad de las piernas de "+nombre+":");
                
                Boxeador boxeador1 = new Boxeador(nombre, pais, peso, pG, vP);
                Console.WriteLine($"Se ha creado el boxeador {nombre} ");

            break;

            case 2: 
                //Boxeador p2 = new Boxeador(nombre, pais, peso, pG, vP);
            break;

            case 3: 
            break;

            case 4: 
            break;                  
        }
    }
    static int IngresarEntero(string mensaje){
        int num = 0;
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
        return num;
    }
    static string IngresarString(string mensaje){
        string palabra; 
        Console.WriteLine(mensaje);
        palabra = Console.ReadLine();
        return palabra;
    }
}