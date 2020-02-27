using System.ComponentModel.DataAnnotations;

namespace BtcTransmuter.Data.Entities.U2F
{
    public class U2FDeviceAuthenticationRequest
    {
        public string KeyHandle { get; set; }

        [Required] public string Challenge { get; set; }

        [Required] [StringLength(200)] public string AppId { get; set; }

        [Required] [StringLength(50)] public string Version { get; set; }
    }
}