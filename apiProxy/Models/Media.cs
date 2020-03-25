using Microsoft.AspNetCore.Http;
using System;

namespace apiProxy.Models
{
    public class Media
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Keywords { get; set; }
        public string ExternalLink { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IFormFile FilesubtitleFile { get; set; }
    }
}
