﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KAMANDAX.Models
{
    public class RefreshRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
