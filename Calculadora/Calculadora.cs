namespace EspacioCalculadora;
public class Calculadora
{
    private double dato;
    public double Resultado {get => dato;}

    public void Sumar(double Dato){
        dato += Dato;
    }
    public void Restar(double Dato){
        dato -= Dato;
    }
    public void Multiplicar(double Dato){
        dato *=Dato;
    }
    public void Dividir(double Dato){
        if (Dato != 0){
            dato /= Dato;
        }else{
            Console.WriteLine("ERROR no se puede dividir en 0");
        }
    }

    public void Limpiar(){
        dato = 0;
    }
}