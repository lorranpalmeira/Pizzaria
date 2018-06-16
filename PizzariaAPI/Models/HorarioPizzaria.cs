using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class HorarioPizzaria
    {

        public int IdPizzaria { get; set; }

        public TimeSpan HorarioAbertura { get; set; }

        public TimeSpan HorarioFechamento{ get; set; }



    }
}
