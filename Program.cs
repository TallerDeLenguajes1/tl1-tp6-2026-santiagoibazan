Console.WriteLine("Calculadora V1");
int op, A, B, resultado;
do {
    Console.WriteLine("1 - Suma \n2 - Resta \n3 - Multiplicacion \n4 - Division \n0 - Terminar programa");
    if (int.TryParse(Console.ReadLine(), out op)) {
        switch (op) {
            case 0:
                break;
            case 1:
                Console.WriteLine("Ingrese el primer valor");
                if (int.TryParse(Console.ReadLine(), out A)) {
                    Console.WriteLine("Ingrese el segundo valor");
                    if (int.TryParse(Console.ReadLine(), out B)) {
                        resultado = A + B;
                        Console.WriteLine($"Suma: {A} + {B} = {resultado}");
                    } else {
                        Console.WriteLine("Error al ingresar el valor B");
                    }
                } else {
                    Console.WriteLine("Error al ingresar el valor A");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese el primer valor");
                if (int.TryParse(Console.ReadLine(), out A)) {
                    Console.WriteLine("Ingrese el segundo valor");
                    if (int.TryParse(Console.ReadLine(), out B)) {
                        resultado = A - B;
                        Console.WriteLine($"Resta: {A} - {B} = {resultado}");
                    } else {
                        Console.WriteLine("Error al ingresar el valor B");
                    }
                } else {
                    Console.WriteLine("Error al ingresar el valor A");
                }
                break;
            case 3:
                Console.WriteLine("Ingrese el primer valor");
                if (int.TryParse(Console.ReadLine(), out A)) {
                    Console.WriteLine("Ingrese el segundo valor");
                    if (int.TryParse(Console.ReadLine(), out B)) {
                        resultado = A * B;
                        Console.WriteLine($"Multiplicacion: {A} * {B} = {resultado}");
                    } else {
                        Console.WriteLine("Error al ingresar el valor B");
                    }
                } else {
                    Console.WriteLine("Error al ingresar el valor A");
                }
                break;
            case 4:
                Console.WriteLine("Ingrese el primer valor");
                if (int.TryParse(Console.ReadLine(), out A)) {
                    Console.WriteLine("Ingrese el segundo valor");
                    if (int.TryParse(Console.ReadLine(), out B)) {
                        if (B != 0) {
                            resultado = A / B;
                            Console.WriteLine($"Division: {A} / {B} = {resultado}");
                        } else {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                    } else {
                        Console.WriteLine("Error al ingresar el valor B");
                    }
                } else {
                    Console.WriteLine("Error al ingresar el valor A");
                }
                break;
            default:
                Console.WriteLine("Ingrese una opcion valida");
                break;
        }
    } else {
        Console.WriteLine("Error: ingrese una opcion nuevamente");
        op = -1;
    }
    Console.WriteLine();
} while (op != 0);