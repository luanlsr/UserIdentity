using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAParser;

namespace UsersApp.Domain.Entities
{
    public class UserAgentInfo
    {
        #region Properties
        public string? UserAgentFamily { get; set; }
        public string? UserAgentMajor { get; set; }
        public string? UserAgentMinor { get; set; }
        public string? UserAgentPatch { get; set; }
        public string? UserAgentString { get; set; }

        public string? DeviceBrand { get; set; }
        public string? DeviceFamily { get; set; }
        public string? DeviceIsSpider { get; set; }
        public string? DeviceModel { get; set; }

        public string? OSFamily { get; set; }
        public string? OSMajor { get; set; }
        public string? OSMinor { get; set; }
        public string? OSPatch { get; set; }
        public string? OSPatchMinor { get; set; }

        #endregion
        public UserAgentInfo() { }
        public UserAgentInfo(ClientInfo client)
        {
            UserAgentFamily = client?.UA.Family;
            UserAgentMajor = client?.UA.Major;
            UserAgentMinor = client?.UA.Minor;
            UserAgentPatch = client?.UA.Patch;
            UserAgentString = client?.String;
            DeviceBrand = client?.Device.Brand;
            DeviceFamily = client?.Device.Family;
            DeviceIsSpider = client?.Device.IsSpider.ToString();
            DeviceModel = client?.Device.Model;
            OSFamily = client?.OS.Family;
            OSMajor = client?.OS.Major;
            OSMinor = client?.OS.Minor;
            OSPatch = client?.OS.Patch;
            OSPatchMinor = client?.OS.PatchMinor;
        }
    }
}
