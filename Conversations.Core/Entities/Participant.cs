using System.Text.Json.Serialization;

namespace Conversations.Core.Entities
{
    public class Participant
    {
        public Participant()
        {
            Conversations = new HashSet<Conversation>();
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? PersonalInformation { get; set; }

        [JsonIgnore]
        public virtual ICollection<Conversation> Conversations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Message> Messages { get; set; }

    }
}
