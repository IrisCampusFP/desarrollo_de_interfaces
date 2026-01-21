var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones => {
    opciones.AddDefaultPolicy(politica =>
    politica.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500")
                .AllowAnyHeader()
                .AllowAnyMethod());
});

var app = constructor.Build();
app.UseCors();

var listaProductos = new List<Producto>
{
    new(1, "Camiseta básica", 12.99m, "Ropa", "https://picsum.photos/seed/prod1/400/300"),
    new(2, "Zapatillas deportivas", 59.90m, "Calzado", "https://picsum.photos/seed/prod2/400/300"),
    new(3, "Mochila urbana", 29.50m, "Accesorios", "https://picsum.photos/seed/prod3/400/300"),
    new(4, "Auriculares Bluetooth", 24.99m, "Tecnología", "https://picsum.photos/seed/prod4/400/300"),
    new(5, "Teclado mecánico", 79.00m, "Tecnología", "https://picsum.photos/seed/prod5/400/300"),
    new(6, "Botella térmica", 15.25m, "Hogar", "https://picsum.photos/seed/prod6/400/300"),
    new(7, "Libro de diseño", 18.80m, "Libros", "https://picsum.photos/seed/prod7/400/300"),
    new(8, "Lámpara LED", 22.40m, "Hogar", "https://picsum.photos/seed/prod8/400/300"),
    new(9, "Gorra clásica", 9.99m, "Accesorios", "https://picsum.photos/seed/prod9/400/300"),
    new(10, "Sudadera con capucha", 34.95m, "Ropa", "https://picsum.photos/seed/prod10/400/300"),
};


//RUTA QUE SALUDA
app.MapGet("/", () => Results.Ok("ESTA TODO CORRECTO"));


//RUTA PARA OBTENER TODOS LOS PRODUCTOS
app.MapGet("/productos", () => Results.Ok(listaProductos));


//RUTA QUE MUESTRA UN SOLO PRODUCTO
app.MapGet("/productos/{id:int}", (int id) =>
{
    var producto = listaProductos.FirstOrDefault(elementoDeLista => elementoDeLista.Id == id);
    return producto is null ? Results.NotFound("404, producto no encontrado") : Results.Ok(producto);    
});


app.MapPost("/productos", (ProductoCrear nuevoProducto) =>
{
    if(string.IsNullOrWhiteSpace(nuevoProducto.Nombre))
        return Results.BadRequest
})