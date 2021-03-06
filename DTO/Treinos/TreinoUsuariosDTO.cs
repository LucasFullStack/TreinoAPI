﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoAPI.DTO.Treinos
{
    [Table("TreinoUsuarios")]
    public class TreinoUsuariosDTO
    {
        [Key]
        public int IDTreinoUsuario { get; set; }

        public int IDUsuario { get; set; }

        public Nullable<int> IDSemanaDia { get; set; }

        public int IDSemana { get; set; }

        public int IDDivisao { get; set; }

        public bool Executado { get; set; }

        public int TempoTreino { get; set; }

        public Nullable<DateTime> DataExecucao { get; set; }

        public bool Ativo { get; set; }

        public Nullable<DateTime> CreationDate { get; set; }

        public Nullable<DateTime> LastEditDate { get; set; }

        public bool Treinando { get; set; }

    }
}
