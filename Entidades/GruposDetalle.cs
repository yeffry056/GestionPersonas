﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.Entidades
{
    public class GruposDetalle
    {
        //Id, GrupoId,PersonaId,Orden
        [Key]
        public int Id { get; set; }
        public int GrupoId { get; set; }
        public int PersonaId { get; set; }
        public string Orden { get; set; }
        public GruposDetalle(int grupoId, int personaId, string orden)
        {
            Id = 0;
            GrupoId = grupoId;
            PersonaId = personaId;
            Orden = orden;
        }
    }
}
