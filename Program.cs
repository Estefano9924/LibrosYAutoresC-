using Libro;
using Autor;
using manejador.contenedor;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<LibroDTO> BDlibro = new List<LibroDTO>();
List<AutorDTO> BDAutor = new List<AutorDTO>();
LibroManejador ManejadorLibro = new LibroManejador(BDlibro);
AutorManejador ManejadorAutor = new AutorManejador(BDAutor);

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/v1/libros/{id:Guid}", (Guid id) =>
{
    return Results.Ok(ManejadorLibro.Obtener(id));
});
app.MapPost("/api/v1/libros", (LibroDTO libro) =>
{
    ManejadorLibro.Crear(libro);
});
app.MapPut("/api/v1/libros/{id:Guid}", (Guid id, LibroDTO libro) =>
{
    ManejadorLibro.Actualizar(libro, id);
});

app.MapDelete("/api/v1/libros/{id:Guid}", (Guid id) =>
{
    ManejadorLibro.Eliminar(id);
});

app.MapGet("/api/v1/autores/{id:Guid}", (Guid id) =>
{
    return Results.Ok(ManejadorAutor.Obtener(id));
});
app.MapPost("/api/v1/autores", (AutorDTO autor) =>
{
    ManejadorAutor.Crear(autor);
});
app.MapPut("/api/v1/autores/{id:Guid}", (Guid id, AutorDTO autor) =>
{
    ManejadorAutor.Actualizar(autor, id);
});

app.MapDelete("/api/v1/autores/{id:Guid}", (Guid id) =>
{
    ManejadorAutor.Eliminar(id);
});

app.Run();

