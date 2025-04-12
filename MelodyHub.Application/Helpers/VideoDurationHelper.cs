using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Helpers
{
    public static class AudioDurationHelper
    {
        public static string EstimateMp4Duration(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File not exists.");

            const double bitrate = 128000; 
            double fileSizeInBits = file.Length * 8; 
            double estimatedSeconds = fileSizeInBits / bitrate; 

            int minutes = (int)(estimatedSeconds / 60);
            int seconds = (int)(estimatedSeconds % 60);

            return $"{minutes:D2}:{seconds:D2}";
        }
    }
}
