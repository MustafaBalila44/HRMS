﻿using ModelCore.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModelCore.FA.BK.Master
{
    public class CurrencyViewModel
    {
    }

    [NotMapped]
    public class CurrencyIndex
    {
        [Key]
        [Required]

        [Required]

        [Required]

        [Required]

        [Required]

        [Required]

        public Int64 TotalPages { get; set; }
        public Int64 TotalRecords { get; set; }


    }

    [NotMapped]
    public class CurrencyEntry
    {
        [Key]
        [Required]

        [Required]

        [Required]

        [Required]

        [Required]

        [Required]

        [Required]
        public AuditColumns AuditColumns { get; set; }

    }


}