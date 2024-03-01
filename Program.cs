using System.Diagnostics.Contracts;

static void PuntoUnoCalculadoraFracciones(){
    int resultadoNumerador;
    int resultadoDenominador;

    Console.WriteLine("Ingrese lo datos de la primera fraccion (Deben ser numero enteros): ");
    Console.WriteLine("Numerador primera fraccion: ");
    int numeradorUno = int.Parse(Console.ReadLine());
    Console.WriteLine("denominador primera fraccion: ");
    int denominadorUno = int.Parse(Console.ReadLine());

    if (denominadorUno == 0){
        Console.WriteLine("El denominador no puede ser = " + denominadorUno);
        Environment.Exit(0);
    }

    Console.WriteLine("Ingrese la operacion que desea realizar (+,-,/,*)");
    string operador = Console.ReadLine();

    Console.WriteLine("Numerador segunda fraccion: ");
    int numeradorDos = int.Parse(Console.ReadLine());
    Console.WriteLine("denominador segunda fraccion: ");
    int denominadorDos = int.Parse(Console.ReadLine());

    if (denominadorDos == 0){
        Console.WriteLine("El denominador no puede ser = " + denominadorDos);
        Environment.Exit(0);
    }

    if (operador == "+"){
        if (denominadorUno == denominadorDos){
            resultadoNumerador = (numeradorUno + numeradorDos);
            Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + denominadorDos);
        }else{
            resultadoNumerador = (numeradorUno * denominadorDos) + (numeradorDos * denominadorUno);
            resultadoDenominador = (denominadorUno * denominadorDos);
            Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + resultadoDenominador);
        }
    }else if (operador == "-"){
        if (denominadorUno == denominadorDos){
            resultadoNumerador = (numeradorUno - numeradorDos);
            Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + denominadorDos);
        }else{
            resultadoNumerador = (numeradorUno * denominadorDos) - (numeradorDos * denominadorUno);
            resultadoDenominador = (denominadorUno * denominadorDos);
            Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + resultadoDenominador);
        }
    }else if (operador == "*"){
        resultadoNumerador = (numeradorUno * numeradorDos);
        resultadoDenominador = (denominadorUno * denominadorDos);
        Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + resultadoDenominador);
    }else if (operador == "/"){
        resultadoNumerador = (numeradorUno * denominadorDos);
        resultadoDenominador = (denominadorUno * numeradorDos);
        Console.WriteLine("El resultado es: " + resultadoNumerador + "/" + resultadoDenominador);
    }
}

static void PuntoDosNumeroEspecial(){
    Console.WriteLine("Ingrese un numero entero: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 5 == 0 && numero % 2 != 0 && numero % 3 != 0){
        Console.WriteLine($"el {numero} es un numero especial.");
    }else{
        Console.WriteLine($"el {numero} no es un numero especial.");
    }
}

static void PuntoTresDiaYSemana(){
    Console.WriteLine("Ingrese su edad: ");
    int Edad = int.Parse(Console.ReadLine());
    int AñosViciesto = Edad / 4;
    int DiasTrancurridos = (Edad * 365) + AñosViciesto;
    int SemanasTrascurridas = Edad * 52;

    Console.WriteLine($"Han Tracurrido {DiasTrancurridos} dias y {SemanasTrascurridas} semanas");
}

static void PuntoCuatroInicioDeSeccion(){
    string Usuario = "juan";
    string Contraseña = "janus1d";
    int Contador = 3;
    while (Contador != 0){
        Console.WriteLine("==============================");
        Console.WriteLine($"Tiene {Contador} intentos");
        Console.WriteLine("Ingrese el usario");
        string UsuarioConsole = Console.ReadLine();
        Console.WriteLine("Ingrese la contraseña");
        string ContraseñaConsole = Console.ReadLine();

        if (Usuario == UsuarioConsole){
            if(Contraseña == ContraseñaConsole){
                Console.WriteLine("Acceso concedido");
                Environment.Exit(0);
            }else{
                Console.WriteLine("Contraseña incorrecta");
                Contador --;
            }
        }else{
            Console.WriteLine("Usuario incorrecto");
            Contador --;
        }
    }

    if(Contador == 0){
        Console.WriteLine("Acceso denegado");
    }
}

Console.WriteLine("======================MENU============================");
Console.WriteLine("Selecciones que punto desea revisar (1,2,3,4):");
Console.WriteLine("1. Calculara De Fracciones");
Console.WriteLine("2. Numeros especiales");
Console.WriteLine("3. Calcular Dias y Semanas");
Console.WriteLine("4. Inicio de seccion");
int opcion = int.Parse(Console.ReadLine());

switch (opcion){
    case 1:
        PuntoUnoCalculadoraFracciones();
    break;
    case 2:
        PuntoDosNumeroEspecial();
    break;
    case 3:
        PuntoTresDiaYSemana();
    break;
    case 4:
        PuntoCuatroInicioDeSeccion();
    break;
}