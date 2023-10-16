using System.ComponentModel.DataAnnotations;
namespace Models.Entities
{
    public class Serie 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La fecha de estreno es obligatoria.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEstreno { get; set; }
        [Required(ErrorMessage = "Las estrellas son obligatorias.")]
        [Range(1, 5, ErrorMessage = "Las estrellas deben estar entre 1 y 5.")]
        public int Estrellas { get; set; }
        [Required(ErrorMessage = "El género es obligatorio.")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El precio de alquiler es obligatorio.")]
        [Range(0.01, 1000, ErrorMessage = "El precio de alquiler debe estar entre 0.01 y 1000.")]
        public decimal PrecioAlquiler { get; set; }
        [Required(ErrorMessage = "El campo ATP es obligatorio.")]
        public bool ATP { get; set; }
        [Required(ErrorMessage = "El estado es obligatorio.")]
        [RegularExpression("^(AN|AC)$", ErrorMessage = "El estado debe ser 'AN' o 'AC'.")]
        public string Estado { get; set; } = "AC"; // Por defecto en "AC"
    }
}
