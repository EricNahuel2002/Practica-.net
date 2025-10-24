using System.ComponentModel.DataAnnotations;

namespace prueba_EF.Models
{

    [MetadataType(typeof(AutorModelMetaData))]
    public partial class Autore
    {

    }
    public class AutorModelMetaData
    {
        public int AutorId { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;

        public string? Pais { get; set; }
    }
}
