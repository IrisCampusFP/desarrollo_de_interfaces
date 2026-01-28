using System.Reflection.Metadata;

var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politica =>
        politica.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500", "https://www.google.es") // agrego las ip que podrán hacer peticiones
            .AllowAnyHeader()
            .AllowAnyMethod() // Permite todos los métodos
            // Para permitir solo algunos métodos: .WithMethods("POST", "GET")
    );
});

var app = constructor.Build();

app.UseCors();


var listaPersonas = new List<Persona> // lista de personas 
{
    new(1, "Ramses", "Muñoz", 31, "8029559C", "Caracas"),
    new(2, "Iris", "Pérez", 20, "87543487C", "Madrid"),
    new(3, "Miguel", "Rodríguez Pérez", 45, "34567890C", "Valencia"),
    new(4, "Ana", "Fernández Gómez", 36, "45678901D", "Sevilla"),
    new(5, "Javier", "López Moreno", 41, "56789012E", "Zaragoza"),
    new(6, "María", "Ruiz Torres", 25, "67890123F", "Granada"),
    new(7, "David", "Hernández Castro", 39, "78901234G", "Bilbao"),
    new(8, "Elena", "Navarro Vidal", 33, "89012345H", "Alicante"),
    new(9, "Pablo", "Santos Romero", 29, "90123456J", "Salamanca"),
    new(10, "Lucía", "Ortega Molina", 47, "01234567K", "Murcia")
};


// Ruta de inicio
app.MapGet("/", () => Results.Ok("Api funcionando"));

// Retorna la lista completa
app.MapGet("/personas", () => Results.Ok(listaPersonas));

// Retorna una persona
app.MapGet("/personas/{id:int}", (int id) =>
{
    var persona = listaPersonas.FirstOrDefault(instanciaDeLista => instanciaDeLista.Id == id); // Busca la persona en la lista, si la encuentra la retorna, si no devuelve 
    
    if (persona == null)
    {
        return Results.NotFound("Persona no encontrada");
    }
    else
    {
        return Results.Ok(persona);
    }

    // return persona == null ? Results.NotFound("Persona no encontrada") : Results.Ok(persona); 
});


// Recibe una persona, valida sus campos, la crea y la agrega a la lista
app.MapPost("/personas", (Persona persona) =>
{
    // Validación de todos los campos

    if (string.IsNullOrWhiteSpace(persona.Nombre))
    {
        return Results.BadRequest("Debe tener un nombre");
    }
    if (string.IsNullOrWhiteSpace(persona.Apellidos))
    {
        return Results.BadRequest("Debe tener apellidos");
    }
    if (persona.Edad <= 0)
    {
        return Results.BadRequest("La persona no puede tener una edad menor o igual a cero");
    }
    if (string.IsNullOrWhiteSpace(persona.Dni))
    {
        return Results.BadRequest("Debe tener DNI");
    }
    if (persona.LugarNacimiento == null || persona.LugarNacimiento == "")
    {
        return Results.BadRequest("Debe tener lugar de nacimiento");
    }

    // Creación del nuevo id
    var nuevoId = listaPersonas.Max(elemento => elemento.Id) +1; // id nuevo correlativo a la lista

    // Creación de la persona con los datos recibidos
    var nuevaPersona = new Persona(nuevoId, persona.Nombre, persona.Apellidos, 
        persona.Edad, persona.Dni, persona.LugarNacimiento);

    // Se agrega la persona a la lista
    listaPersonas.Add(persona);

    // Retorna un mensaje de éxito
    return Results.Created("Persona creada: ", persona); 
});


app.Run(); // Arranca el servicio

public record Persona(int Id, string Nombre, string Apellidos, int Edad, string Dni, string LugarNacimiento);