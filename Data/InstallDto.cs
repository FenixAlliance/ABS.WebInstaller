using System.ComponentModel.DataAnnotations;

namespace FenixAlliance.ABS.Installer.Data
{
    public class InstallDto
    {
        [Required]
        public int DBPort { get; set; } = 3306;
        [Required]
        public string DBHost { get; set; } = "localhost";
        [Required]
        public string DBName { get; set; }
        [Required]
        public string DBEngine { get; set; } = "MySQL";
        [Required]
        public string DBUserName { get; set; }
        [Required]
        public string DBUserSecret { get; set; }
        [Required]
        public string TenantName { get; set; }
        [Required]
        [EmailAddress]
        public string TenantEmail { get; set; }
        [Required]
        public string TenantCountry { get; set; } = "USA";
        [Required]
        public string TenantCurrency { get; set; } = "USD";
        [Required]
        public string PortalTitle { get; set; }
        [Required]
        public string PortalDescription { get; set; }
        [Required]
        public bool PortalVisibility { get; set; }
        [Required]
        public string HolderName { get; set; }
        [Required]
        [EmailAddress]
        public string HolderEmail { get; set; }
        [Required]
        public string HolderPassword { get; set; }
        [Required]
        public string HolderCurrency { get; set; } = "USD";
    }
}
