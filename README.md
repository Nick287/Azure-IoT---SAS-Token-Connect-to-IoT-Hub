# Azure IoT – Use SAS Token Connect to IoT Hub

This is a sample code to show how to use SAS token to send and receive information to IoT Hub. For this project, I refer to the modification made by [Azure IoT Hub official SDK](https://github.com/Azure-Samples/azure-iot-samples-csharp). If you need to face this scenario, I hope this code can help to you.


![enter image description here](https://docs.microsoft.com/en-us/azure/iot-hub/media/iot-hub-devguide-security/tokenservice.png)

## Prerequisites

-   .NET Core SDK 2.1.0 or greater on your development machine. You can download the .NET Core SDK for multiple platforms from  [.NET](https://www.microsoft.com/net/download/all). You can verify the current version of C# on your development machine using 'dotnet --version'.

## reference
- [# Control access to IoT Hub](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-security)
- [# Generate SAS token](https://docs.microsoft.com/en-us/rest/api/eventhub/generate-sas-token)
- [Azure-iot-sdk-csharp](https://github.com/Azure/azure-iot-sdk-csharp): contains the source code for Azure IoT C# SDK.
- [Azure IoT Hub Documentation](https://docs.microsoft.com/azure/iot-hub/)
-   [Get-started](https://docs.microsoft.com/en-us/azure/iot-hub/quickstart-send-telemetry-dotnet)
