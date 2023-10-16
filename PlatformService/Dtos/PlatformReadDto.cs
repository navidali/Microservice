namespace PlatformService.Dtos
{
    // dont include required because we are just returning data
    public class PlatformReadDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Publisher { get; set; }
        
        public string Cost { get; set; }
    }
}