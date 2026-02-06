// Inicio los constructores y arranco la app
var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politica =>
        politica.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500") // agrego las ip que podrán hacer peticiones
            .AllowAnyHeader()
            .AllowAnyMethod()
    );
});

var app = constructor.Build();
app.UseCors();


// Lista
var listaPersona = new List<Persona>
{
    new(1, "Andrés", "Salazar Gómez", 29, "V12345678", "Caracas", "Venezuela", "Av. Libertador, Edif. Sol", "Universitario"),
    new(2, "Mariana", "Pinto Rodríguez", 34, "E23456789", "Madrid", "España", "Calle Gran Vía 120", "Postgrado"),
    new(3, "José", "Márquez León", 41, "M34567890", "Ciudad de México", "México", "Col. Roma Norte", "Universitario"),
    new(4, "Valentina", "Ríos Herrera", 22, "C45678901", "Bogotá", "Colombia", "Chapinero Alto", "Bachiller"),
    new(5, "Carlos", "Medina Torres", 37, "A56789012", "Buenos Aires", "Argentina", "Av. Corrientes 540", "Universitario"),
    new(6, "Paula", "Navarro Díaz", 26, "V44556677", "Mérida", "Venezuela", "Av. Las Américas, Apt. 3B", "Universitario"),
    new(7, "Ricardo", "Figueroa Silva", 45, "P67890123", "Lima", "Perú", "Miraflores, Calle 9", "Técnico Superior"),
    new(8, "Camila", "Suárez Pacheco", 31, "C78901234", "Medellín", "Colombia", "El Poblado", "Universitario"),
    new(9, "Daniel", "Peña Castillo", 28, "U89012345", "Montevideo", "Uruguay", "Barrio Pocitos", "Universitario"),
    new(10, "Lucía", "Ortega Morales", 39, "E90123456", "Barcelona", "España", "Calle Aragón 88", "Postgrado"),
    new(11, "Miguel", "Ramos Contreras", 24, "V10111213", "Guatire", "Venezuela", "Sector El Ingenio", "Universitario"),
    new(12, "Natalia", "Vera Montoya", 33, "C14151617", "Cali", "Colombia", "Barrio Granada", "Universitario"),
    new(13, "Óscar", "Luna Cabrera", 48, "B18192021", "La Paz", "Bolivia", "Zona Sopocachi", "Técnico Superior"),
    new(14, "Gabriela", "Mendoza Ruiz", 27, "H22232425", "Tegucigalpa", "Honduras", "Col. Morazán", "Universitario"),
    new(15, "Héctor", "Bautista Flores", 52, "C26272829", "Santiago", "Chile", "Providencia", "Bachiller")
};


// Ruta de inicio
app.MapGet("/", () => Results.Ok("Api funcionando"));


// Endpoint GET para obtener toda la lista
app.MapGet("/personas", () => Results.Ok(listaPersona));


// Endpoint GET para obtener un elemento de la lista (por su DNI)
app.MapGet("/personas/{dni}", (string dni) =>
{
    var persona = listaPersona.FirstOrDefault(elementos => elementos.Dni == dni);

    if (persona != null)
    {
        return Results.Ok(persona);
    }
    else
    {
        return Results.NotFound("NO ENCONTRADO");    
    }
});


// Endpoint POST para crear un nuevo elemento en la lista
app.MapPost("/personas", (Persona nuevaPersona) =>
{
    // Validación de todos los campos

    if (string.IsNullOrWhiteSpace(nuevaPersona.Nombre))
    {
        return Results.BadRequest("Debe tener un nombre");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.Apellidos))
    {
        return Results.BadRequest("Debe tener apellidos");
    }
    if (nuevaPersona.Edad <= 0)
    {
        return Results.BadRequest("La persona no puede tener una edad menor o igual a cero");
    }
        if (nuevaPersona.Edad < 18)
    {
        return Results.BadRequest("La persona debe ser mayor de edad");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.Dni))
    {
        return Results.BadRequest("Debe tener DNI");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.LugarNacimiento))
    {
        return Results.BadRequest("Debe tener lugar de nacimiento");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.PaisNacimiento))
    {
        return Results.BadRequest("Debe tener país de nacimiento");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.Direccion))
    {
        return Results.BadRequest("Debe tener dirección");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.UltimoEstudio))
    {
        return Results.BadRequest("Debe tener último estudio");
    }

    // Creación del nuevo id
    var nuevoId = listaPersona.Max(elemento => elemento.Id) +1;

    // Creación de la persona con los datos recibidos
    var persona = new Persona(
        nuevoId, 
        nuevaPersona.Nombre, 
        nuevaPersona.Apellidos, 
        nuevaPersona.Edad, 
        nuevaPersona.Dni, 
        nuevaPersona.LugarNacimiento,
        nuevaPersona.PaisNacimiento,
        nuevaPersona.Direccion,
        nuevaPersona.UltimoEstudio
    );

    // Agrego la persona a la lista
    listaPersona.Add(persona);

    // Devuelve un mensaje de éxito
    return Results.Created("CREADO", persona); 
});


// Endpoint PUT para actualizar un elemento de la lista
app.MapPut("/personas", (Persona personaActualizada) =>
{
    // buscamos la persona
    var persona = listaPersona.FirstOrDefault(elementoLista => elementoLista.Dni == personaActualizada.Dni);
    
    // verificamos que existe
    if (persona == null)
    {
        // retornamos un 404 en caso de que no la encuentre
        return Results.NotFound("Persona no encontrada");
    }
    else
    {
        // obtenemos el indice en lista de la persona que recibimos y vamos a actualizar
        var index = listaPersona.FindIndex(elementoLista => elementoLista.Id == personaActualizada.Id);

        // actualizamos la persona
        listaPersona[index]=personaActualizada;

        return Results.Ok(personaActualizada);
    }
});


// Endpoint DELETE para eliminar un elemento de la lista (por su id)
app.MapDelete("/personas/{id:int}", (int id) =>
{
    var persona = listaPersona.FirstOrDefault(elementoLista => elementoLista.Id == id);

    if (persona != null)
    {
        listaPersona.Remove(persona);
        return Results.Ok("Persona eliminada");
    } 
    else
    {
        return Results.NotFound("No encontrada");
    }
});



app.Run();


// Clase record
public record Persona(int Id, string Nombre, string Apellidos, int Edad, string Dni, string LugarNacimiento, string PaisNacimiento, string Direccion, string UltimoEstudio);