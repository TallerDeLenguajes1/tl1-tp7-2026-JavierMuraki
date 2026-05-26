using EspacioCalculadora;

string? Input = "";
bool Continuar = true;
int Operacion = 0;
double Numero = 0;

Calculadora Calc = new Calculadora();

do {
    Console.WriteLine("Seleccione una Operacion:");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicacion");
    Console.WriteLine("4 - Divicion");
    do { // Control de ingreso de tipo de operacion
        Console.Write("Ingrese Operacion (Q para terminar): ");
        Input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Input))           Console.WriteLine("No se ingreso nada, intente de nuevo...");
        else if (Input.ToLower() == "q")                {Console.WriteLine("Calculadora terminada."); return;}
        else if (!int.TryParse(Input, out Operacion))   Console.WriteLine($"Ingreso incorrecto [{Input}], se esperaba un Numero, intente de nuevo...");
        else if (Operacion < 1 || Operacion > 4)        Console.WriteLine("Operacion invalida, intente de nuevo...");
        else break; // Ya completado los controles el break termina el bucle
    } while (true);


    do { // Control de ingreso de tipo de numero
        Console.Write("Ingrese Numero (Q para terminar): ");
        Input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Input))           Console.WriteLine("No se ingreso nada, intente de nuevo...");
        else if (Input.ToLower() == "q")                {Console.WriteLine("Calculadora terminada."); return;}
        else if (!double.TryParse(Input, out Numero))   Console.WriteLine($"Ingreso incorrecto [{Input}], se esperaba un Numero, intente de nuevo...");
        else break; // Ya completado los controles el break termina el bucle
    } while (true);


    Calc.Limpiar();
    switch (Operacion) {
        case 1:
            Calc.Sumar(Numero);
            break;
        case 2:
            Calc.Restar(Numero);
            break;
        case 3:
            Calc.Multiplicar(Numero);
            break;
        case 4:
            Calc.Dividir(Numero);
            break;
    }

    Console.WriteLine($"Resultado de la operacion: {Calc.Resultado}\n");
} while (Continuar);