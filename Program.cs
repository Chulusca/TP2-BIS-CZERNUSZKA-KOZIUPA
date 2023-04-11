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
                if(boxeador1 != null && boxeador2 != null){
                    Pelear(boxeador1, boxeador2);
                }
                else Console.WriteLine("No se cargaron ambos boxeadores.");
                break;
            case 4:
                break;
            default:
                break;
        }
}while(opcion != 4);

static Boxeador IngresarBoxeador(){
    
    string nom = Funciones.IngresarTexto("Ingrese el nombre del Boxeador");
    string pais = Funciones.IngresarTexto("Ingrese la nacionalidad del Boxeador");
    int peso = Funciones.IngresarEnteroEnRango("Ingrese el peso del boxeador", 40, 150);
    int pg = Funciones.IngresarEnteroEnRango("Ingrese la potencia de golpe", 1, 100);
    int vp = Funciones.IngresarEnteroEnRango("Ingrese la velocidad de las piernas", 1 , 100);

    Boxeador boxeador = new Boxeador(nom, pais, peso, pg, vp);
    return boxeador;
}
static void Pelear(Boxeador bx1, Boxeador bx2){

}