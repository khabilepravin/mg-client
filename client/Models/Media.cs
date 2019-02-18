using System;

namespace client.Models
{
    public class Media
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int season { get; set; }
        public int Episode { get; set; }
        public string Keywords { get; set; }
        public string ExternalLink { get; set; }
        public DateTime ReleaseDate { get; set; }
        public dynamic FilesubtitleFile { get; set; }
    }
}
