﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InformationFIle.Models.Start
{
    public static class IFormFileExtensions
    {
        public static string GetFilename(this IFormFile file)
        {
            return ContentDispositionHeaderValue.Parse(
                            file.ContentDisposition).FileName.ToString().Trim('"');
        }
    }
}
