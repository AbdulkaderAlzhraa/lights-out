using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace lights_out.Models
{
    public class Move
    {
        [JsonPropertyName("Row")]
        public int Row { get; set; }

        [JsonPropertyName("Column")]
        public int Column { get; set; }

    }
}
