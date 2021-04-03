﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PG.ViewModels
{
    public class ImagesViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public IFormFile Photo { get; set; }
    }
}
