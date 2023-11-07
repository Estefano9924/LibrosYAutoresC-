namespace manejador.contenedor;
using Autor;
using Libro;

public class LibroManejador
{
    private List<LibroDTO> _libros;

    public LibroManejador(List<LibroDTO> libros)
    {
        this._libros = libros;
    }


    public LibroDTO Obtener(Guid id)
    {
        var libro = this._libros.Find(l => l.Id == id);
        if (libro != null)
        {
            return libro;
        }
        return null;
    }

    //     MOSTRAR
    // http://localhost:(aqui su puerto)/api/v1/libros/8f596166-7d19-11ee-b962-0242ac120002
    // http://localhost:(aqui su puerto)/api/v1/libros/a9ca9740-7d19-11ee-b962-0242ac120002
    // http://localhost:(aqui su puerto)/api/v1/libros/aedaf31a-7d19-11ee-b962-0242ac120002

    public void Crear(LibroDTO libro)
    {
        this._libros.Add(libro);
    }

    // CREAR
    // http://localhost:(aqui su puerto)/api/v1/libros/ POST

    //  {
    //    "Id": "8f596166-7d19-11ee-b962-0242ac120002",
    //    "Titulo": "El Gran Gatsby",
    //    "Resumen": "La historia de Jay Gatsby y su amor por Daisy Buchanan.",
    //    "AutorId": "a056b9fa-7d19-11ee-b962-0242ac120002"
    //  }
    // ----------------------------------------------------------------------------
    //  {
    //    "Id": "a9ca9740-7d19-11ee-b962-0242ac120002",
    //    "Titulo": "Cien años de soledad",
    //    "Resumen": "La saga de la familia Buendía en Macondo.",
    //    "AutorId": "aedaf31a-7d19-11ee-b962-0242ac120002"
    //  }
    // ------------------------------------------------------------------------------
    //  {
    //    "Id": "b461077a-7d19-11ee-b962-0242ac120002",
    //    "Titulo": "Matar a un ruiseñor",
    //    "Resumen": "La historia de la justicia y la moral en el sur de EE. UU.",
    //    "AutorId": "ba7ef248-7d19-11ee-b962-0242ac120002"
    //  }


    public void Actualizar(LibroDTO libro, Guid id)
    {
        var libroEncotrado = this._libros.Find(libro => libro.Id == id);
        if (libroEncotrado != null)
        {
            libroEncotrado.Titulo = libro.Titulo;
            libroEncotrado.Resumen = libro.Resumen;
            libroEncotrado.AutorId = libro.AutorId;
        }
    }

    //     ACTUALIZAR
    // http://localhost:(aqui su puerto)/api/v1/libros/a9ca9740-7d19-11ee-b962-0242ac120002 PUT


    //  {
    //    "Titulo": "Cien años",
    //    "Resumen": "Yna gran familia con grandes historias.",
    //    "AutorId": "aedaf31a-7d19-11ee-b962-0242ac120002"
    //  },
    public void Eliminar(Guid id)
    {
        var libroEncotrado = this._libros.Find(libro => libro.Id == id);
        if (libroEncotrado != null)
        {
            _libros.Remove(libroEncotrado);
        }
    }

    //     ELIMINAR
    // http://localhost:(aqui su puerto)/api/v1/libros/8f596166-7d19-11ee-b962-0242ac120002
    // http://localhost:(aqui su puerto)/api/v1/libros/a9ca9740-7d19-11ee-b962-0242ac120002
    // http://localhost:(aqui su puerto)/api/v1/libros/aedaf31a-7d19-11ee-b962-0242ac120002

}


public class AutorManejador
{
    private List<AutorDTO> _autores;

    public AutorManejador(List<AutorDTO> autores)
    {
        this._autores = autores;
    }

    public AutorDTO Obtener(Guid id)
    {
        var autorEncotrado = this._autores.Find(autor => autor.Id == id);
        if (autorEncotrado != null)
        {
            return autorEncotrado; ;
        }
        return null;

    }



    public void Crear(AutorDTO autor)
    {
        this._autores.Add(autor);
    }

    public void Actualizar(AutorDTO autor, Guid id)
    {
        var autorEncotrado = this._autores.Find(autor => autor.Id == id);
        if (autorEncotrado != null)
        {
            autorEncotrado.Nombre = autor.Nombre;
            autorEncotrado.Nacionalidad = autor.Nacionalidad;
        }
    }

    public void Eliminar(Guid id)
    {
        var autorEncotrado = this._autores.Find(autor => autor.Id == id);
        if (autorEncotrado != null)
        {
            _autores.Remove(autorEncotrado);
        }
    }

}