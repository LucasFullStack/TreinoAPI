﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoAPI.DTO.Treinos
{
    public class TreinoUsuarioEditDTO
    {
        [Required]
        public Nullable<int> IDSemanaDia { get; set; }

        [Required]
        public Nullable<bool> Executado { get; set; }
    }
}
