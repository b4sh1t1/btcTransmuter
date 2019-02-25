using System.Net.Http;

namespace BtcTransmuter.Extension.Webhook.Triggers.ReceiveWebRequest
{
    public class ReceiveWebRequestTriggerData
    {
        public HttpMethod Method { get; set; }
        public string RelativeUrl { get; set; }
        public string Body { get; set; }
        
        public dynamic BodyJson { get; set; }
        
    }
}