using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary.DTOs
{
    public class ProjectCreationResponseDTO
    {
        public string name { get; set; }
        public IFormFile Picture { get; set; }
    }
}
