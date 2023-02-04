namespace AspDotNetAPI.Models.Domains
{
    public class Walk
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string Length { get; set; }

        public Guid RegionId { get; set; }

        public Guid WalkDifficultyId { get; set; }

        //Navigation Property

        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
