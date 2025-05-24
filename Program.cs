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

