using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace client.Models
{
    public class MediaSearchResult
    {
        public string MediaName { get; set; }
        public IList<JObject> Results { get; set; }
    }
}
