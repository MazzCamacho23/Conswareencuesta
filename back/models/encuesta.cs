using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Encuesta
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string TipoPersona { get; set; } // Natural | Empresa

    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }

    public string Pais { get; set; }
    public string Ciudad { get; set; }

    public string Comentario { get; set; } // opcional

    // SOLO EMPRESA
    public string NombreEmpresa { get; set; }
    public string Cargo { get; set; }

    public string MedioContacto { get; set; }
}