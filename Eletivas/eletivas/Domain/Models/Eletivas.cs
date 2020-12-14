using System.ComponentModel.DataAnnotations;

namespace eletivas.Models
{
  public class Eletivas
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "Deve se informar um nome para o curso!")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Deve se informar um codigo para o curso!")]
    public string CodigoCurso { get; set; }

    [Required(ErrorMessage = "Deve se informar a carga horária do curso!")]
    public int CargaHoraria { get; set; }

#nullable enable
    public string? Professor = null;

  }
}