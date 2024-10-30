namespace DIYManagementAPI.Models.DTO
{
    public class DIYCustomerHistoryDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Reparations { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Feedback { get; set; }
    }
}
