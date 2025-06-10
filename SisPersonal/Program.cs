using EspacioEmpeado;
Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Pipo", "Girbau", new DateTime(2000, 4, 15), new DateTime(2015, 4, 15));
empleados[1] = new Empleado("Lala", "Girbau", new DateTime(1990, 4, 15), new DateTime(2010, 4, 15));
empleados[2] = new Empleado("Mora", "Girbau", new DateTime(1972, 4, 15), new DateTime(2000, 12, 15));

empleados[0].EstadoCivil = "Casado";
empleados[1].EstadoCivil = "Casado";
empleados[2].EstadoCivil = "Soltero";

double SalarioTotal = 0;
int masProximo = 0;

for (int i = 0; i < 3; i++)
{
    SalarioTotal += empleados[i].Salario();
    if (empleados[masProximo].FaltaParaJubilacion() > empleados[i].FaltaParaJubilacion())
    {
        masProximo = i;
    }
}

System.Console.WriteLine($"Monto Total a pagar a todos los empleados este mes: {SalarioTotal}");
System.Console.WriteLine($"Empleado más proximo a jubilarse: {empleados[masProximo].Nombre} {empleados[masProximo].Apellido} \n Antiguedad: {empleados[masProximo].Antiguedad()} \n Edad: {empleados[masProximo].Edad()} \n Cantidad de años faltantes para jubilarse: {empleados[masProximo].FaltaParaJubilacion()}\n Salario: {empleados[masProximo].Salario()}");








