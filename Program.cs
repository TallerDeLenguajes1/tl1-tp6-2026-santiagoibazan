Console.WriteLine("Calculadora V1");
int op, A, B, resultado;
double C, resultadoDouble;
float F;
do {
    Console.WriteLine("1 - Suma \n2 - Resta \n3 - Multiplicacion \n4 - Division \n" 
        + "5 - Valor Absoluto \n6 - Cuadrado de un numero \n7 - Raiz Cuadrada \n8 - Seno\n" 
        + "9 - Coseno \n10 - Parte entera de un float \n0 - Terminar programa");
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
            case 5:
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out A)) {
                    resultado = Math.Abs(A);
                    Console.Write($"Valor Absoluto de {A} = {resultado}");
                } else {
                    Console.WriteLine("Error al ingresar el numero");
                }
                break;
            case 6:
                Console.WriteLine("Ingrese un numero");
                if (double.TryParse(Console.ReadLine(), out C)) {
                    resultadoDouble = Math.Pow(C, 2.0d);
                    Console.Write($"{C} al cuadrado = {resultadoDouble}");
                } else {
                    Console.WriteLine("Error al ingresar el numero");
                }
                break;
            case 7:
                Console.WriteLine("Ingrese un numero");
                if (double.TryParse(Console.ReadLine(), out C)) {
                    resultadoDouble = Math.Sqrt(C);
                    Console.Write($"La raiz cuadrada de {C} = {resultadoDouble}");
                } else {
                    Console.WriteLine("Error al ingresar el numero");
                }
                break;
            case 8:
                Console.WriteLine("Ingrese un numero");
                if (double.TryParse(Console.ReadLine(), out C)) {
                    resultadoDouble = Math.Sin(C);
                    Console.Write($"Seno de {C} = {resultadoDouble}");
                } else {
                    Console.WriteLine("Error al ingresar el numero");
                }
                break;
            case 9:
                Console.WriteLine("Ingrese un numero");
                if (double.TryParse(Console.ReadLine(), out C)) {
                    resultadoDouble = Math.Cos(C);
                    Console.Write($"Coseno de {C} = {resultadoDouble}");
                } else {
                    Console.WriteLine("Error al ingresar el numero");
                }
                break;
            case 10:
                Console.WriteLine("Ingrese un numero");
                if (float.TryParse(Console.ReadLine(), out F)) {
                    A = (int) F;
                    Console.WriteLine($"Parte entera de {F} = {A}");
                } else {
                    Console.WriteLine("Error");
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