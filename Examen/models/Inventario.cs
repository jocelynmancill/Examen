
using System.ComponentModel.DataAnnotations;
namespace Examen.models
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un entero positivo.")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El nombre no puede exceder 200 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        public string Departamento { get; set; } = string.Empty;
    }
}