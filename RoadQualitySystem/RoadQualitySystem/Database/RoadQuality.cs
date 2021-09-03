namespace RoadQualitySystem.Database
{
    using System;
    public partial class RoadQuality
    {
        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public double Score { get; set; }
    }
}
