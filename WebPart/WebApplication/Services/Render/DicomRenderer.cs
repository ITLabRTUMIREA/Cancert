﻿using DicomParser;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services.Render
{
    public class DicomRenderer : IRenderer
    {
        public Task<Stream> Render(Stream dicomStream)
        {
            var decoder = new DicomDecoder();
            decoder.Init(dicomStream);
            var stream = new MemoryStream();
            decoder.CreateImage16().Save(stream, ImageFormat.Png);
            stream.Position = 0;
            return Task.FromResult<Stream>(stream);
        }
    }
}
