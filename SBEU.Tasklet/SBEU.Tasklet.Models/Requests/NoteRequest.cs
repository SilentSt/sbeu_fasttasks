﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBEU.Tasklet.Models.Requests
{
    public class NoteRequest
    {
        [Required, NotNull]
        public string TaskId { get; set; }
        [Required, NotNull]
        public string Text { get; set; }
    }
}
