// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

Console.WriteLine("Hello, World!");


var pepe = new Persona {
     Nombres = "JOSE LUIS",
     Apellidos = "ESPINOSA",
     FechaNacimiento = new DateTime(1994, 08, 28),
     Estatura = 1.69,
     NroCedula = "1234567890"
};

var ana = new Persona
{
    Nombres = "ANA BELÈN",
    Apellidos = "CISNEROS",
    FechaNacimiento = new DateTime(1996, 9, 19),
    Estatura = 1.55,
    NroCedula = "0987654321"
};

var luis = new Persona
{
    Nombres = "LUIS ANIBAL",
    Apellidos = "CONTRERAS",
    FechaNacimiento = new DateTime(1985, 11, 23),
    Estatura = 1.72,
    NroCedula = "29028934"
};

var ceci = new Persona
{
    Nombres = "CECILIA DE LOURDES",
    Apellidos = "PINEDA",
    FechaNacimiento = new DateTime(1990, 5, 15),
    Estatura = 1.65,
    NroCedula = "7856348956"
};

var listaPersonas = new List<Persona> { 
    pepe, 
    ana, 
    luis, 
    ceci, 
    //null, 
    //null, 
    new Persona {
    Nombres = "JULIETA CRISTINA",
    Apellidos = "CEVALLOS",
    FechaNacimiento = new DateTime(1983, 8, 13),
    Estatura = 1.59,
    NroCedula = "2198390223"
}};

listaPersonas.Add(new Persona
{
    Nombres = "RICARDO",
    Apellidos = "SALAZAR",
    FechaNacimiento = new DateTime(1980, 6, 13),
    Estatura = 1.75,
    NroCedula = "892189090"
});

listaPersonas.Insert(2, new Persona
{
    Nombres = "JUAN CARLOS",
    Apellidos = "PATIÑO",
    FechaNacimiento = new DateTime(1987, 8, 23),
    Estatura = 1.70,
    NroCedula = "128390321"

});


listaPersonas.Remove(ceci);

var masAlto = listaPersonas.Max( p => p.Estatura);
var masBajo = listaPersonas.Min( p => p.Estatura);
var promedio = listaPersonas.Average( p => p.Estatura);

var rick = listaPersonas.Find(p => p.Nombres == "RICARDO");
var personaMasAlta = listaPersonas.Find(p => p.Estatura == masAlto);

foreach (var persona in listaPersonas)
{
    if (persona != null)
    {
        Console.WriteLine(persona.Datos());
    }
}

Console.ReadLine();