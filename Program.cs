// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
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
 */
//codigo ejercicio 4

string texto;
Console.WriteLine("Ingrese un texto:");
texto = Console.ReadLine();

//longitud string
int longitud = texto.Length;
Console.WriteLine($"La longitud del string es: {longitud}");

string texto1;
Console.WriteLine("Ingrese otro texto:");
texto1 = Console.ReadLine();

//concatenar dos strings
string interpolacion = $"{texto}{texto1}!";
string concat = texto + texto1;

Console.WriteLine(interpolacion);
Console.WriteLine(concat);

//para hacer la subcadena a partir de dos numeros de parametros
int inicio;
Console.WriteLine("Ingrese la posición de inicio:");
string bufff3 = Console.ReadLine();
int.TryParse(bufff3, out inicio);

int longitud1;
Console.WriteLine("Ingrese la longitud de la subcadena:");
string bufff4 = Console.ReadLine();
int.TryParse(bufff4, out longitud1);


if (inicio >= 0 && longitud1 >= 0 && inicio + longitud1 <= texto.Length)
{
    string subcadena = texto.Substring(inicio, longitud1);  //para hacer la subcadena a partir de dos numeros de parametros
    Console.WriteLine($"Subcadena: {subcadena}");
    int posicion = texto.IndexOf(subcadena);  //para la ocurrencia de la palabra a partir de una subcadena
    if (posicion != -1)
    {
        Console.WriteLine($"La palabra \"{subcadena}\" fue encontrada en la posición {posicion}.");
    }
    else
    {
        Console.WriteLine($"La palabra \"{subcadena}\" no fue encontrada en el texto.");
    }
}
else
{
    Console.WriteLine("Posición o longitud inválida.");
}

//Console.WriteLine($"la suma de:" {num1.ToString(num1)} y de {num2.ToString()} es = {suma.ToString()});   //tostring

foreach (char c in texto) //Recorrer la cadena de texto con un ciclo Foreach e ir mostrando
{
    Console.WriteLine(c);
}

//cadena a mayúsculas y luego a minúsculas.

Console.WriteLine("Ingrese una cadena de texto:");
string texto3 = Console.ReadLine();

string mayusculas = texto3.ToUpper();
string minusculas = texto3.ToLower();

Console.WriteLine($"En mayúsculas: {mayusculas}");
Console.WriteLine($"En minúsculas: {minusculas}");


//separador
string frase = "uno,dos,tres,cuatro";
string[] palabras = frase.Split(',');

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

//ultimo ej
Console.WriteLine("Ingrese una ecuación ej: 582+2:");
string ecuacion = Console.ReadLine();

char operador = ' ';
int posicion = -1;

// Busco el operador en la cadena
foreach (char c in ecuacion)
{
    if (c == '+' || c == '-' || c == '*' || c == '/')
    {
        operador = c;
        posicion = ecuacion.IndexOf(c);
    }
}

if (posicion == -1)
{
    Console.WriteLine("No se encontro el operador");
}

// Separar los operandos
string parte1 = ecuacion.Substring(0, posicion);
string parte2 = ecuacion.Substring(posicion + 1);

// Convertir a números
if (int.TryParse(parte1, out int num1) && int.TryParse(parte2, out int num2))
{
    int resultado = 0;
    CALCULADORAV1(parte1, parte2, operador);
}
