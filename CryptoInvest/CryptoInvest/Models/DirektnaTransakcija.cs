﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class DirektnaTransakcija: Transakcija
    {
        [Required]
        public int tipDirektneTransakcije;
    }
}
