using System.Collections.Generic;
using System;

int opcion;
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();
do{
    Console.Clear();
    Console.WriteLine("1. Cargar Boxeador 1");
    Console.WriteLine("2. Cargar Boxeador 2");
    Console.WriteLine("3. Pelear!");
    Console.WriteLine("4. Salir");
    opcion = Funciones.IngresarEnteroEnRango("Ingrese la opcion deseada",1,4);
    switch (opcion)
        {
            case 1:
                boxeador1 = IngresarBoxeador();
                Console.Clear();
                break;
            case 2:
                boxeador2 = IngresarBoxeador();
                Console.Clear();
                break;
            case 3:
                if(boxeador1 != null && boxeador2 != null) Pelear(boxeador1, boxeador2);
                else Console.WriteLine("No se cargaron ambos boxeadores.");
                break;
            case 4:
                break;
            default:
                break;
        }
}while(opcion != 4);

static Boxeador IngresarBoxeador(){
    
    string nom = Funciones.IngresarTexto("Ingrese el nombre del Boxeador ");
    string pais = Funciones.IngresarTexto("Ingrese la nacionalidad del Boxeador ");
    int peso = Funciones.IngresarEnteroEnRango("Ingrese el peso del boxeador ", 40, 150);
    int pg = Funciones.GenerarEnteroRandom(1,100);
    int vp = Funciones.GenerarEnteroRandom(1,100);
    int inteligencia = Funciones.IngresarEnteroEnRango("Ingrese la inteligencia del peleador ", 1 , 100);

    Boxeador boxeador = new Boxeador(nom, pais, peso, pg, vp, inteligencia);
    return boxeador;
}
static void Pelear(Boxeador bx1, Boxeador bx2){
    double skill1 = bx1.ObtenerSkill();
    double skill2 = bx2.ObtenerSkill();

    if(skill1 > skill2) GanadorDiferencia(skill1, skill2, bx1.Nombre);
    else if (skill2 > skill1) GanadorDiferencia(skill2, skill1, bx2.Nombre);
    else Console.WriteLine("Empataron!!");   
}
static void GanadorDiferencia(double ganador, double perdedor, string nom){
    double diferencia = ganador - perdedor;
    if(diferencia >= 30) Console.WriteLine($"Ganó {nom} por KO");
    else if(diferencia >= 10) Console.WriteLine($"Ganó {nom} por puntos en fallo unánime");
    else Console.WriteLine($"Ganó {nom} por puntos en fallo dividido");
}