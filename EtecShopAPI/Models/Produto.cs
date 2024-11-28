using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShopAPI.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(40)]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }


      
}