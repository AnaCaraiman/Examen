using Examen.Models.Base;

namespace Examen.Models.Participanti
{
    public class Participanti : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<EvenimentParticipant> EvenimentParticipant
        {
            get; set;
        }
    }
}
