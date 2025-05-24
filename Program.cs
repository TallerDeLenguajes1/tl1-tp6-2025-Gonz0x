// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//codigo invertir num;

int num;
int numInvertido = 0;
Console.WriteLine("NUMERO A INVERTIR: ");
string buff = Console.ReadLine();
if(int.TryParse(buff, out num))
{
    while(num > 0){
        int aux = num % 10;
        numInvertido = numInvertido * 10 + aux;
        num /= 10;
    }
    Console.WriteLine("NUMERO INVERTIDO:"+ numInvertido);
}

//codigo CALCULADORAV1

int num1;
Console.WriteLine("Ingrese un numero:");
string buff1 = Console.ReadLine();
int.TryParse(buff1, out num1);

int num2;
Console.WriteLine("Ingrese el otro numero:");
string buff2 = Console.ReadLine();
int.TryParse(buff2, out num2);

int op;
Console.WriteLine("SELECCIONE OPERACION:");
Console.WriteLine("1.SUMA");
Console.WriteLine("2.RESTA");
Console.WriteLine("3.MULTIPLICACION.");
Console.WriteLine("4.DIVISION");
Console.WriteLine("0.SALIR");
string buff3 = Console.ReadLine();
int.TryParse(buff3, out op);
while(op != 0){
    switch(op){
        case 1:
            int suma = 0;
            suma = num1 + num2;
            Console.WriteLine("SUMA = "+ suma);
        break;
        case 2:

            int resta = 0;
            resta = num1 - num2;
            Console.WriteLine("RESTA = "+ resta);
        break;
        case 3:
            int multp = 0;
            multp = num1 * num2;
            Console.WriteLine("MULTIPLICACION = "+ multp);
            break;
        case 4:
            if(num2 != 0){
                float div = 0;
                div = num1 / num2;
                Console.WriteLine("DIVISION = "+ div);
            }else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR EN 0");
            }
        break;
        default:
            Console.WriteLine("FIN");
            op = 0;
        break;
    }

    Console.WriteLine("SELECCIONE OPERACION:");
    Console.WriteLine("1.SUMA");
    Console.WriteLine("2.RESTA");
    Console.WriteLine("3.MULTIPLICACION.");
    Console.WriteLine("4.DIVISION");
    Console.WriteLine("0.SALIR");
    buff3 = Console.ReadLine();
    int.TryParse(buff3, out op);
}



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