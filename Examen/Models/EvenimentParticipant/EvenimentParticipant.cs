namespace Examen.Models.EvenimentParticipant
{
    public class EvenimentParticipant
    {
        public Guid EvenimenteId { get; set; }
        public Evenimente Evenimente { get; set; }
        public Guid ParticipantiId{ get; set; }
        public Participanti Participanti { get; set; }
    }
}
