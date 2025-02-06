namespace Domain
{
    public class Personality
    {
        public Guid Id { get; set; }
        public MBTIType? MBTIType { get; set; }
        public bool IsTurbulent { get; set; }
        public string Content { get; set; }
        public List<AppUser> Users { get; set; }

    }
}

public enum MBTIType
{
    ISTJ, // Logistician
    ISFJ, // Defender
    INFJ, // Advocate
    INTJ, // Architect
    ISTP, // Virtuoso
    ISFP, // Adventurer
    INFP, // Mediator
    INTP, // Logician
    ESTP, // Entrepreneur
    ESFP, // Entertainer
    ENFP, // Campaigner
    ENTP, // Debater
    ESTJ, // Executive
    ESFJ, // Consul
    ENFJ, // Protagonist
    ENTJ  // Commander
}