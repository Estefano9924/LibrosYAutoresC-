namespace Libro;

public class LibroDTO
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Resumen { get; set; }
    public Guid AutorId { get; set; }
}