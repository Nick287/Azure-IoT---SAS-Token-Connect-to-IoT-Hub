using Microsoft.Azure.Devices.Client;
using System;
using Token_Service;

namespace Device_SAS_Token
{
    class Program
    {
        // Select one of the following transports used by DeviceClient to connect to IoT Hub.
        private static TransportType s_transportType = TransportType.Amqp;
        //private static TransportType s_transportType = TransportType.Mqtt;
        //private static TransportType s_transportType = TransportType.Http1;
        //private static TransportType s_transportType = TransportType.Amqp_WebSocket_Only;
        //private static TransportType s_transportType = TransportType.Mqtt_WebSocket_Only;

        static int Main(string[] args)
        {
            string deviceID = "PNPdevice1";
            string hostName = "Bo-IoTHub.azure-devices.net";
            string endpoint = hostName + "/devices/" + deviceID;

            string key = "kFHUUwpwdsiTW3BtnEM15TLvUyo4v+kuwseHYqN/r/g=";
            string deviceLevelKey = "hRToHlK3K3IF+SvuZPm4A15rknkzFsu0TI5rRH5s0ck=";

            string policyName = "iothubowner";
            string policyNamedevice = "device";

            string SAStoken = GenerateSasToken.generateSasToken(endpoint, deviceLevelKey, policyNamedevice);

            DeviceAuthenticationWithToken DAT = new DeviceAuthenticationWithToken(deviceID, SAStoken);

            DeviceClient deviceClient = DeviceClient.Create(hostName, DAT);

            if (deviceClient == null)
            {
                Console.WriteLine("Failed to create DeviceClient!");
                return 1;
            }

            var sample = new MessageSample(deviceClient);
            sample.RunSampleAsync().GetAwaiter().GetResult();

            Console.WriteLine("Done.\n");
            return 0;
        }
    }
}
