class Boxeador {

public string Nombre{get;set;}
public string Pais{get;set;}
public int Peso{get;set;}
public int PotenciaGolpes{get; set;}
public int VelocidadPiernas{get;set;}


public Boxeador(string nombre, string pais, int peso, int pG, int vP){
    Nombre = nombre;
    Pais = pais;
    Peso = peso;
    if(pG >= 1 && pG <= 100){
        PotenciaGolpes = pG; 
    }   
    if(vP > 0 && vP <= 100){
        VelocidadPiernas = vP;
    }
}

public double ObtenerSkill(){
    double suma = 0;
    suma = VelocidadPiernas*0.6;
    suma += PotenciaGolpes * 0.8;
    Random r = new Random();
    int randomNum = r.Next(1,10);
    suma += randomNum;
    return suma;
}

}