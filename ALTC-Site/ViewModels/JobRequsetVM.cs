namespace ALTC_Website.ViewModels
{
    public class JobRequsetVM
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public IFormFile? File { get; set; }
    }
}
