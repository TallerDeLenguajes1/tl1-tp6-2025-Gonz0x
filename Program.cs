// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//codigo CALCULADORAV2

double numero;
Console.WriteLine("Ingrese un numero:");
string bufff = Console.ReadLine();
if(double.TryParse(bufff, out numero)){
    double valorAbsoluto = Math.Abs(numero);
    double cuadrado = Math.Pow(numero, 2);
    double raizCuadrada = Math.Sqrt(Math.Abs(numero)); //para evitar raiz cuadrada de numero negativo
    double seno = Math.Sin(numero);
    double coseno = Math.Cos(numero);
    int parteEntera = (int)numero;

    // Mostrar resultados
    Console.WriteLine($"Valor absoluto: {valorAbsoluto}");
    Console.WriteLine($"Cuadrado: {cuadrado}");
    Console.WriteLine($"Raíz cuadrada: {raizCuadrada}");
    Console.WriteLine($"Seno: {seno}");
    Console.WriteLine($"Coseno: {coseno}");
    Console.WriteLine($"Parte entera: {parteEntera}");
}else{
    Console.WriteLine("DEBE INGRESAR UN NUMERO.");
}


//ejercio maximo y minimo

double numero1;
Console.WriteLine("Ingrese primer numero:");
string buff4 = Console.ReadLine();

double numero2;
Console.WriteLine("Ingrese segundo numero:");
string buff5 = Console.ReadLine();

if(double.TryParse(buff4, out numero1) && (double.TryParse(buff5, out numero2))){
    if(numero1 > numero2){
        Console.WriteLine("Maximo numero:"+ numero1);
        Console.WriteLine("Minimo numero:"+ numero2);
    }else{
        Console.WriteLine("Maximo numero:"+ numero2);
        Console.WriteLine("Minimo numero:"+ numero1);
    }
}else{
    Console.WriteLine("DEBE INGRESAR NUMEROS.");
}