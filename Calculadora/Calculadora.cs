namespace EspacioCalculadora;

public class Calculadora {
    private double dato;
    public double Resultado {get => dato;}

    public void Sumar(double termino)       {this.dato += termino;}
    public void Restar(double termino)      {this.dato -= termino;}
    public void Multiplicar(double termino) {this.dato *= termino;}
    public void Dividir(double termino)     {this.dato /= termino;}
    public void Limpiar()                   {this.dato = 0;}
}