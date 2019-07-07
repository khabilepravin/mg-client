using System.Collections.Generic;

namespace client.ViewModel
{
    public class MediaResultViewModel
    {
        public IEnumerable<apiProxy.Models.MediaText> MediaTextResult { get; set; }
        public string MediaId { get; set; }
        public string MediaName { get; set; }
    }
}
