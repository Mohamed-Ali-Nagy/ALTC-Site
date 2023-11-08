namespace ALTC_Website.Models
{
    public class AltcDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string TechnicalCollection { get; set; } = null!;
        public string JobCandidateCollection { get; set; } = null!;

        public string StaticCollection { get; set; } = null!;


        public string ComplainCollection { get; set; } = null!;
        public string RequestCollection { get; set; } = null!;
        

    }
}
