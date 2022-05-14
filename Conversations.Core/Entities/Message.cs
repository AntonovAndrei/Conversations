using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Conversations.Core.Entities
{
    public class Message
    {
        public int Id { get;set; } 
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SentDateTime { get; set; }

        [JsonIgnore]
        public virtual Participant Participant { get; set; }
        [JsonIgnore]
        public virtual Conversation Conversation { get; set; }
    }
}
