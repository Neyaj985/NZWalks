namespace NZWalks.API.Models.DTO
{
    public class UpdateRegionRequest
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Populattion { get; set; }
    }
}
