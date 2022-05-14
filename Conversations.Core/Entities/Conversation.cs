using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Conversations.Core.Entities
{
    public class Conversation
    {
        public Conversation()
        {
            Participants = new HashSet<Participant>();
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Participant> Participants { get; set; }
        [JsonIgnore]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
