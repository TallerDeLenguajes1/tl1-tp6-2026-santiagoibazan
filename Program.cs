Console.WriteLine("Num");
int a;

if (int.TryParse(Console.ReadLine(),out a) && a > 0) {
    Console.WriteLine("Numero ingresado: " + a);
    int aux = 0;
    while (a >= 10) {
        aux = aux + (a % 10);
        aux *= 10;
        a = a / 10;
    }
    aux = aux + a;
    Console.WriteLine("Numero invertido: " + aux);
} else {
    Console.WriteLine("Error");
}



