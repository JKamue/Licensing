using System.Windows.Forms;

namespace Licensing.Client.Hardware
{
    public class HardwareId
    {
        public static string GenerateHardwareId(TreeView trv)
        {
            var output = "";
            
            var processorInformationCollection = WmiApi.QueryWin32Class("Win32_Processor");
            trv.Nodes.Add("CPU");
            foreach (var processorObject in processorInformationCollection)
            {
                output += processorObject.GetProperty<string>("Name").Trim();
                trv.Nodes[0].Nodes.Add(processorObject.GetProperty<string>("Name").Trim());
            }

            var videoControllerCollection = WmiApi.QueryWin32Class("Win32_VideoController");
            trv.Nodes.Add("GPU");
            foreach (var videoControllerObject in videoControllerCollection)
            {
                output += videoControllerObject.GetProperty<string>("Caption");
                trv.Nodes[1].Nodes.Add(videoControllerObject.GetProperty<string>("Caption"));
            }

            var physicalMemoryInformationCollection = WmiApi.QueryWin32Class("Win32_PhysicalMemory");
            trv.Nodes.Add("RAM");
            foreach (var physicalMemoryStick in physicalMemoryInformationCollection)
            {
                output += physicalMemoryStick.GetProperty<string>("PartNumber").Trim();
                trv.Nodes[2].Nodes.Add(physicalMemoryStick.GetProperty<string>("PartNumber").Trim());
            }

            var mainBoardInfos = WmiApi.QueryWin32Class("Win32_BaseBoard");
            trv.Nodes.Add("Mainboard");
            foreach (var mainboard in mainBoardInfos)
            {
                output += mainboard.GetProperty<string>("SerialNumber");
                trv.Nodes[3].Nodes.Add(mainboard.GetProperty<string>("SerialNumber"));
            }


            var outputBytes = System.Text.Encoding.UTF8.GetBytes(output);
            return System.Convert.ToBase64String(outputBytes);
        }
    }
}
