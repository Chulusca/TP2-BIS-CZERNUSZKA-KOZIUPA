class Boxeador{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    private int PotenciaGolpes{get;set;}
    private int VelocidadPiernas{get;set;}
    private int Inteligencia{get;set;}
    
    public Boxeador(string nom, string pais, int peso, int pg, int vp, int inteligencia){
        Nombre = nom;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
        Inteligencia = inteligencia;
    }
    public Boxeador(){

    }
    public double ObtenerSkill(){
        return VelocidadPiernas * 0.6 + PotenciaGolpes * 0.8 + Funciones.GenerarEnteroRandom(1, 10) + Inteligencia * 0.25;
    }
}