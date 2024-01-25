using Examen.Models.Base;

namespace Examen.Models.Evenimente
{
    public class Evenimente : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<EvenimentParticipant> EvenimentParticipant { get; set; }
    }


}
