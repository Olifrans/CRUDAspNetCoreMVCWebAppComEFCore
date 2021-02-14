using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAspNetCoreMVCWebAppComEFCore.Models
{
    public class Empregados
    {
        [Key]
        public int EmpregadosId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "O brigatório digitar o nome!")]
        public string Nome { get; set; }

        //[Display(Name = "Código do Empregado")]
        [DisplayName("Código do Empregado")]
        [Column(TypeName = "varchar(20)")]
        public string Codigo { get; set; }

        [Display(Name = "Funcão")]
        [Column(TypeName = "varchar(10)")]
        public string Funcao { get; set; }

        [Display(Name = "Localizacao do Escritorio")]
        [Column(TypeName = "varchar(100)")]
        public string LocalizacaoEscritorio { get; set; }

    }
}
