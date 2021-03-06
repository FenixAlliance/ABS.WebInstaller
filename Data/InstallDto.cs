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
        public string HolderCurrency { get; set; } = "USD";
        [Required]
        public string IdentityProvider { get; set; } = "Default";


        public string HolderName { get; set; }
        [EmailAddress]
        public string HolderEmail { get; set; }
        public string HolderPassword { get; set; }

        public bool EnableTelemetry { get; set; }

        public string AadDomain { get; set; }
        public string AadInstance { get; set; } = "https://login.microsoftonline.com/tfp/";
        public string AadClientId { get; set; }
        public string AadGraphTenant { get; set; }
        public string AadGraphClientId { get; set; }
        public string AadCallbackPath { get; set; } = "/signin-oidc";
        public string AadBotSignUpSignInPolicyId { get; set; }
        public string AadGraphClientSecret { get; set; }
        public string AadAdminsSecurityGroup { get; set; }
        public string AadB2cSignUpSignInPolicyId { get; set; }
        public string AadB2cResetPasswordPolicyId { get; set; }
        public string AadB2cEditProfilePolicyId { get; set; }
        public string AzureAppInsightsInstrumentationKey { get; set; }
        public string StorageProvider { get; set; }
        public string AzureStorageAccountKey { get; set; }
        public string AzureStorageAccountName { get; set; }
        public string OpenExchangeRatesAppId { get; set; }
        public bool EnableOpenExchangeRates { get; set; }
    }
}
