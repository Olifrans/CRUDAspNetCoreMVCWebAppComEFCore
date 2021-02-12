using System;
using System.Collections.Generic;
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
        [Required]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Codigo { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Funcao { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string LocalizacaoEscritorio { get; set; }

    }
}
