using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Diretor { get; set; }  
        [StringLength(30, ErrorMessage = "O gênero passou de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1,600, ErrorMessage = "Duração de filme inválido")]
        public int Duracao { get; set; }
    }
}
