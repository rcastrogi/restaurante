using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.DAL.Entidades
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required(ErrorMessage ="Favor informar o nome do Restaurante.")]
        public string Nome { get; set; }

        public virtual ICollection<Prato> Pratos { get; set; }
    }
}
