using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;        
        
namespace Apresentacao
{
    public class CapturaNrDeSerie
    {


        static string GetVolumeSerial(string strDriveLetter)
        {
            try
            {
                if (strDriveLetter == "" || strDriveLetter == null) strDriveLetter = "C";
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");

                disk.Get();
                return disk["VolumeSerialNumber"].ToString();

            }
            catch
            {
                return "0";
            }
        }

        static string GetCPUId()
        {
            string cpuInfo = String.Empty;
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            try
            {
                foreach (ManagementObject obj in objCol)
                {
                    if (cpuInfo == String.Empty)
                    {
                        cpuInfo = obj.Properties["ProcessorId"].Value.ToString();
                    }
                }
                return cpuInfo;
            }
            catch (Exception)
            {
                return cpuInfo;
            }
            
        }

        static string GetMoteherBoard()
        {
            string motherInfo = string.Empty;
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            mbsList = mbs.Get();
            try
            {
                foreach (ManagementObject mo in mbsList)
                {
                    if (motherInfo == string.Empty)
                    {
                        motherInfo = mo["SerialNumber"].ToString();
                    }

                }
                return motherInfo;
            }
            catch(Exception)
            {
                return motherInfo;
            }

        }

        public static String retornaSeriais()
        {
            string nrsdeserie = CapturaNrDeSerie.GetVolumeSerial("C") + "-" + CapturaNrDeSerie.GetCPUId() + "-" + CapturaNrDeSerie.GetMoteherBoard();
            return nrsdeserie;
        }

    }

}


