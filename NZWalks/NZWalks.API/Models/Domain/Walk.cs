namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public String Name{ get; set; }
        public double Length { get; set; }
        public Guid WalkDifficultyId { get; set; }
        public Guid regionId { get; set; }
    }
}
