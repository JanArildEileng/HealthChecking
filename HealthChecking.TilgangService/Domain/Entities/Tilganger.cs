namespace HealthChecking.TilgangService.Domain.Entities
{
    public class Tilganger
    {
        public string Navn { get; set; }
        public string Role { get; set; }

        public DateTime Opprettet { get; init; } = DateTime.Now;
    }
}