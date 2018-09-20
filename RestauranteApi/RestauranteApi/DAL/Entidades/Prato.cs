using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.DAL.Entidades
{
    public class Prato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Favor informar o nome do prato.")]
        [MaxLength(30)]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Favor informar o preço do prato.")]
        [DisplayFormat(ApplyFormatInEditMode =false, DataFormatString = "{0:f2}", NullDisplayText ="0,00")]
        public decimal Preco { get; set; }

        public virtual int? RestauranteId { get; set; }

        public virtual Restaurante Restaurante { get; set; }
    }
}
