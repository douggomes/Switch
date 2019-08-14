﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Amigo
    {
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioAmigoId { get; set; }
        public virtual Usuario UsuarioAmigo { get; set; }

    }
}
