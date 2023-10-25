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

// tarea: agregar 2 personas (hombre y mujer)
//        encontrar las personas que empiecen con R y J
//        de la lista de personas que empiezan con R y J encontrar la persona mas joven y mas adulta
//        IMPRIMIR los datos de estas dos personas (joven y adulto)
//        localizar a la persona cuya cedula es "128390321" y cambiar sus apellidos por CEVALLOS RODRIGUEZ
//        cambiar la cedula de la 4ta persona en la lista por el valor 1002149290

var mujer = new Persona { 
    Nombres = "XIMENA",
    Apellidos = "BENAVIDES",
    FechaNacimiento = new DateTime(1990, 3, 17),
    Estatura = 1.66,
    NroCedula = "8908908990"
};

var hombre = new Persona {
    Nombres = "CALIXTO",
    Apellidos = "ORELLANA",
    FechaNacimiento = new DateTime(1988, 2, 27),
    Estatura = 1.76,
    NroCedula = "718979312"
};

listaPersonas.Add(hombre);
listaPersonas.Add(mujer);

var personasAyC = listaPersonas.Where(p => p.Nombres.StartsWith("R") || p.Nombres.StartsWith("J")).ToList();
var edadJoven = personasAyC.Max(p => p.FechaNacimiento);
var edadAdulta = personasAyC.Min( p => p.FechaNacimiento);
var personaJoven = personasAyC.Find(p => p.FechaNacimiento == edadJoven);
var personaAdulta = personasAyC.Find(p => p.FechaNacimiento == edadAdulta);

var persona128390321 = listaPersonas.Find(p => p.NroCedula == "128390321");
persona128390321.Apellidos = "CEVALLOS RODRIGUEZ";

var persona4ta = listaPersonas[3].NroCedula = "1002149290";

Console.WriteLine("--------------------");
Console.WriteLine("LISTA TOTAL DE PERSONAS");
Console.WriteLine("--------------------");

foreach (var persona in listaPersonas)
{
    if (persona != null)
    {
        Console.WriteLine(persona.Datos());
    }
}

Console.WriteLine("--------------------");
Console.WriteLine("PERSONAS CUYO NOMBRE EMPEIZA CON J y R");
Console.WriteLine("--------------------");

foreach (var persona in personasAyC)
{
    if (persona != null)
    {
        Console.WriteLine(persona.Datos());
    }
}

Console.WriteLine("--------------------");
Console.WriteLine("PERSONA MAS JOVEN");
Console.WriteLine("--------------------");
Console.WriteLine(personaJoven.Datos());

Console.WriteLine("--------------------");
Console.WriteLine("PERSONA MAS ADULTA");
Console.WriteLine("--------------------");
Console.WriteLine(personaAdulta.Datos());
Console.WriteLine("--------------------");


Console.ReadLine();