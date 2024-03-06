using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json.Serialization;

namespace StudsBlazorTest.Shared
{
	public class DropdownOption
	{
        [JsonPropertyName("label")]
        public string label { get; set; }

        [JsonPropertyName("value")]
        public string value { get; set; }
    }
}

