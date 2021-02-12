using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAspNetCoreMVCWebAppComEFCore.Models
{
    public class EmpregadosContext :DbContext
    {
        public EmpregadosContext(DbContextOptions<EmpregadosContext> options):base(options)
        {
        }
        public DbSet<Empregados> Empregados { get; set; }
    }
}

//Comandos nuget
//Update-Database
//Add-Migration "InitialCreate"