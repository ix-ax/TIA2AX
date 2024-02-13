using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Tia2Ax.DTOs;
using Tia2Ax.Utils;
using Tia2Ax.Setup;
using System.Net;
using System.Runtime.InteropServices;

namespace Tia2Ax.Interfaces
{

    public class TraceWriter
    {
        public TraceWriter() { }
        public void Write(string message)
        {
            Console.Write(message);
        }
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ApiWrapper : INotifyPropertyChanged
    {
        #region fields

        private IList<TiaPortalProcess> _tiaPortalProcessList;
        private readonly TraceWriter _traceWriter;
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion // Fields

        #region ctor

        public ApiWrapper(TraceWriter traceWriter, [CallerMemberName] string caller = "")
        {
            _traceWriter = traceWriter;
            var methodBase = MethodBase.GetCurrentMethod();
            _traceWriter.WriteLine(methodBase.Name + " called from " + caller + "\n");
        }

        #endregion // ctor

        #region properties

        public TiaPortalProcess CurrentTiaPortalProcess
        {
            get;
            set;
        }

        public TiaPortal TiaPortal
        {
            get;
            set;
        }

        public bool TiaPortalIsDisposed
        {
            get;
            set;
        }

        public Project CurrentProject
        {
            get;
            set;
        }

        public Project AvailableProject
        {
            get;
            set;
        }

        #endregion // properties

        #region methods

        #region common

        #endregion // common

        #region TIA Portal

        /// <summary>
        /// Open a TIA Portal instance
        /// </summary>
        /// <param name="caller"></param>
        public void DoOpenTiaPortal([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            TiaPortal = new TiaPortal(TiaPortalMode.WithoutUserInterface);
            TiaPortalIsDisposed = false;
        }

        /// <summary>
        /// Connect to a open TIA Portal instance
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="caller"></param>
        public void DoConnectTiaPortal(int processId, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var portal = TiaPortal.GetProcess(processId, 5000).Attach();
            if (portal != null)
            {
                TiaPortal?.Dispose();
                TiaPortalIsDisposed = true;
                CurrentProject = null;
                TiaPortal = portal;
                TiaPortalIsDisposed = false;
            }
        }

        /// <summary>
        /// Connect to a open TIA Portal instance
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="caller"></param>
        public void DoDisconnectTiaPortal(int processId, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var portal = TiaPortal.GetProcess(processId, 5000).Attach();
            if (portal != null)
            {
                TiaPortal?.Dispose();
                TiaPortalIsDisposed = true;
                CurrentProject = null;
                TiaPortal = null;
            }
        }

        /// <summary>
        /// Close a TIA Portal instance
        /// </summary>
        /// <param name="caller"></param>
        public void DoCloseTiaPortal([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            TiaPortal.GetCurrentProcess().Dispose();
            TiaPortalIsDisposed = true;
            CurrentProject = null;
        }

        /// <summary>
        /// Get all TIA Portal processes on the local machine
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public IList<TiaPortalProcess> DoGetTiaPortalProcesses([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            CurrentTiaPortalProcess = TiaPortal?.GetCurrentProcess();
            _tiaPortalProcessList = new List<TiaPortalProcess>();
            _tiaPortalProcessList = TiaPortal.GetProcesses();

            return _tiaPortalProcessList;
        }

        /// <summary>
        /// Get the current process id
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string DoGetCurrentTiaProcessId([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            return CurrentTiaPortalProcess != null ? CurrentTiaPortalProcess.Id.ToString() : string.Empty;
        }

        #endregion // TIA Portal

        #region TIA Portal Project

        /// <summary>
        /// Open a project
        /// </summary>
        /// <param name="path"></param>
        /// <param name="caller"></param>
        /// <returns></returns>
        public bool DoOpenProject(string path, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var processId = -1;
            var result = false;
            var loadOpenProject = false;
            var accessGranted = true;
            DoCloseProject();
            _tiaPortalProcessList = new List<TiaPortalProcess>();
            _tiaPortalProcessList = TiaPortal.GetProcesses();
            if (_tiaPortalProcessList.Count > 0)
            {
                foreach (var item in _tiaPortalProcessList)
                {
                    if (item.ProjectPath != null && item.ProjectPath.FullName.ToString().Replace(@"\", "").Equals(path.Replace(@"\", "")))
                    {
                        processId = item.Id;
                        loadOpenProject = true;     
                        accessGranted = true;                        
                        break;
                    }
                }
            }
            if (!loadOpenProject)
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Extension.Equals(".ap18"))
                {
                    DoOpenTiaPortal();
                    var newProject = TiaPortal.Projects.Open(new FileInfo(path));
                    _traceWriter.WriteLine($"TiaPortal.Projects.Open({path}");
                    if (newProject != null)
                    {
                        CurrentProject = newProject;
                        result = true;
                    }
                }
                else
                {
                    _traceWriter.WriteLine(path + " version not supported.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }
            if (loadOpenProject && accessGranted && processId != -1)
            {
                DoConnectTiaPortal(processId);
                DoLoadProject();
                result = true;
            }
            return result;           
        }

        /// <summary>
        /// Load a project from connected instance -> see 'DoConnectTiaPortal'
        /// </summary>
        /// <param name="caller"></param>
        public void DoLoadProject([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            CurrentProject = TiaPortal.Projects.FirstOrDefault();
            if (CurrentProject.IsModified)
            {
                _traceWriter.WriteLine(CurrentProject.Path + " has been modified. Save it and run this tool then again.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }


        /// <summary>
        /// Closes the first and only open project of the connected TIA portal instance 
        /// </summary>
        /// <param name="caller"></param>
        public void DoCloseProject([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            if (!TiaPortalIsDisposed && TiaPortal?.Projects.Count > 0)
            {
                var project = TiaPortal.Projects.FirstOrDefault();
                project?.Close();
            }
            CurrentProject = null;
        }

        #endregion // TIA Portal Project

        #region Device

        /// <summary>
        /// Get the list of the device groups from current project
        /// </summary>
        public void GetPlcList(ProjectItem projectItem)
        {
            if(projectItem != null && projectItem.PlcItems != null)
            {
                projectItem.PlcItems.Clear();
            }
            else if (projectItem != null )
            {
                projectItem.PlcItems = new List<PlcItem>();
            }


            foreach (Device device in CurrentProject.Devices)
            {
                string name;
                if (CheckIfIsPlc(device, out name))
                {
                    PlcItem plc = new PlcItem() {Name = name, DeviceName = device.Name, Classification = "CPU", GroupPathInProject = "" , ConfiguredSubnets = GetAllNetworkInterfaces(device), LocalModules = GetAllLocalModules(device, name) };
                    projectItem.PlcItems.Add(plc);
                    IList<HwIdentifierItem> hwIdentifiers = GetAllHwIdentifiers(device, name);
                    AssignToPlc(hwIdentifiers, projectItem);
                }
            }

            string path = "";
            foreach (var deviceGroup in CurrentProject.DeviceGroups)
            {
                GetGroupedPlcList(deviceGroup, path, projectItem);
            }

            foreach (Device device in CurrentProject.Devices)
            {
                string name;
                if (CheckIfIsHM(device, out name))
                {
                    IList<ModuleItem> localModules = GetAllLocalModules(device, name);
                    AssignToPlc(localModules, projectItem);
                    IList<HwIdentifierItem> hwIdentifiers = GetAllHwIdentifiers(device, name);
                    AssignToPlc(hwIdentifiers, projectItem);
                }
            }

            foreach (Device device in CurrentProject.UngroupedDevicesGroup.Devices)
            {
                string name;
                if (CheckIfIsHM(device, out name))
                {
                    IList<ModuleItem> localModules = GetAllLocalModules(device , name);
                    AssignToPlc(localModules, projectItem);
                    IList<HwIdentifierItem> hwIdentifiers = GetAllHwIdentifiers(device, name);
                    AssignToPlc(hwIdentifiers, projectItem);
                }
            }

            path = "";
            foreach (var deviceGroup in CurrentProject.DeviceGroups)
            {
                GetGroupedHMs(deviceGroup, path, projectItem);
            }
        }

        /// <summary>
        /// Get the list of the device groups from current project
        /// </summary>
        public void GetGroupedPlcList(DeviceUserGroup deviceGroup, string path, ProjectItem projectItem)
        {
            path = String.IsNullOrEmpty(path) ? deviceGroup.Name : path + "." + deviceGroup.Name;

            foreach (Device device in deviceGroup.Devices)
            {
                string name = "";
                if (CheckIfIsPlc(device, out name))
                {
                    PlcItem plc = new PlcItem() { Name = name, DeviceName = device.Name, Classification = "CPU", GroupPathInProject = path, ConfiguredSubnets = GetAllNetworkInterfaces(device) , LocalModules = GetAllLocalModules(device, name), DistributedModules = new List<ModuleItem>() };
                    projectItem.PlcItems.Add(plc);
                    IList<HwIdentifierItem> hwIdentifiers = GetAllHwIdentifiers(device, name);
                    AssignToPlc(hwIdentifiers, projectItem);
                }
            }

            foreach (var deviceSubGroup in deviceGroup.Groups)
            {
                GetGroupedPlcList(deviceSubGroup, path, projectItem);
            }
        }

        /// <summary>
        /// Check if th device is a PLC
        /// </summary>
        public bool CheckIfIsPlc(Device device, out string name)
        {
            foreach (var deviceItem in device.DeviceItems)
            {
                if (deviceItem.Classification.ToString().Equals("CPU"))
                {
                    name = deviceItem.Name;

                    return true;
                }
            }
            name = "";
            return false;
        }

        /// <summary>
        /// Check if the device is a HeadModule
        /// </summary>
        public bool CheckIfIsHM(Device device, out string name)
        {
            foreach (var deviceItem in device.DeviceItems)
            {
                Debug.WriteLine(deviceItem.Name);
                Debug.WriteLine(deviceItem.Classification.ToString());
                if (deviceItem.Classification.ToString().Equals("HM"))
                {
                    name = deviceItem.Name;

                    return true;
                }
            }
            name = "";
            return false;
        }

        /// <summary>
        /// Get the list of the device groups from current project
        /// </summary>
        public void GetGroupedHMs(DeviceUserGroup deviceGroup, string path, ProjectItem projectItem)
        {
            path = String.IsNullOrEmpty(path) ? deviceGroup.Name : path + "." + deviceGroup.Name;

            foreach (Device device in deviceGroup.Devices)
            {
                string name = "";
                if (CheckIfIsHM(device, out name))
                {
                    IList<ModuleItem> localModules = GetAllLocalModules(device, name);
                    AssignToPlc(localModules, projectItem);
                    IList<HwIdentifierItem> hwIdentifiers = GetAllHwIdentifiers(device, name);
                    AssignToPlc(hwIdentifiers, projectItem);
                }
            }

            foreach (var deviceSubGroup in deviceGroup.Groups)
            {
                GetGroupedHMs(deviceSubGroup, path, projectItem);
            }
        }

        /// <summary>
        /// Assigned addressed items to the master PLC
        /// </summary>
        private void AssignToPlc(IList<ModuleItem> localModules, ProjectItem projectItem)
        {
            foreach (ModuleItem localModule in localModules )
            {
                foreach (var plcItem in projectItem.PlcItems)
                {
                    ModuleItem module = new ModuleItem() { Name = localModule.Name, FullName = localModule.FullName, OrderNumber = localModule.OrderNumber, FirmwareVersion = localModule.FirmwareVersion, PositionNumber = localModule.PositionNumber, AddressItems = new List<AddressItem>() };

                    foreach (AddressItem addressItem in localModule.AddressItems)
                    {

                        if (plcItem.Name.Equals(addressItem.Controller))
                        {
                            module.AddressItems.Add(addressItem);
                        }
                    }

                    if (module.AddressItems.Count > 0)
                    {
                        int index = projectItem.PlcItems.IndexOf(plcItem);
                        if(projectItem.PlcItems[index].DistributedModules != null)
                        {
                            projectItem.PlcItems[index].DistributedModules.Add(module);
                        }
                        else
                        {
                            IList<ModuleItem> deviceItems = new List<ModuleItem>();
                            deviceItems.Add(module);
                            projectItem.PlcItems[index].DistributedModules = deviceItems;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Assigned HwIdentifier items to the master PLC
        /// </summary>
        private void AssignToPlc(IList<HwIdentifierItem> HwIdentifiers, ProjectItem projectItem)
        {
            foreach (HwIdentifierItem HwIdentifier in HwIdentifiers)
            {
                foreach (var plcItem in projectItem.PlcItems)
                {

                    if (plcItem.Name.Equals(HwIdentifier.Controller))
                    {
                        int index = projectItem.PlcItems.IndexOf(plcItem);
                        if (projectItem.PlcItems[index].HwIdentifiers != null)
                        {
                            projectItem.PlcItems[index].HwIdentifiers.Add(HwIdentifier);
                        }
                        else
                        {
                            List<HwIdentifierItem> hwIdentifierItems = new List<HwIdentifierItem>
                            {
                                HwIdentifier
                            };
                            projectItem.PlcItems[index].HwIdentifiers = hwIdentifierItems;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Get NetworkInterfaces
        /// </summary>
        public IList<string> GetAllNetworkInterfaces(Device device)
        {
            IList<string> networkInterfaces = new List<string>();

            foreach (DeviceItem deviceItem in device.DeviceItems)
            {
                if (deviceItem.Classification.ToString().Equals("CPU"))
                {
                    foreach (DeviceItem deviceSubItem in deviceItem.DeviceItems)
                    {
                        NetworkInterface coupler_Itf = deviceSubItem.GetService<NetworkInterface>();
                        if (coupler_Itf != null && coupler_Itf.IoControllers != null && coupler_Itf.IoControllers.FirstOrDefault() != null && coupler_Itf.IoControllers.FirstOrDefault().IoSystem != null)
                        {
                            string interfaceName = coupler_Itf.IoControllers.FirstOrDefault().IoSystem.Subnet.GetAttribute("Name").ToString();
                            networkInterfaces.Add(interfaceName);
                        }
                    }
                }
            }
            return networkInterfaces;
        }

        /// <summary>
        /// Get all local modules
        /// </summary>
        public IList<ModuleItem> GetAllLocalModules(Device device, string name)
        {
            IList<ModuleItem> localModules = new List<ModuleItem>();

            foreach (DeviceItem deviceItem in device.DeviceItems)
            {
                try
                {
                    if (deviceItem != null)
                    {
                        string _classification = "";
                        string _orderNumber = "";
                        string _firmware = "";
                        string deviceItemName = deviceItem.Name;
                        string deviceSubItemName = "";
                        string deviceSubSubItemName = "";
                        try
                        {
                            _classification = deviceItem.GetAttribute("Classification").ToString();
                        }
                        catch (Exception ex) {; }
                        try
                        {
                            _orderNumber = deviceItem.GetAttribute("OrderNumber").ToString();
                        }
                        catch (Exception ex) {; }
                        try
                        {
                            _firmware = deviceItem.GetAttribute("FirmwareVersion").ToString();
                        }
                        catch (Exception ex) {; }

                        foreach (var deviceSubItem in deviceItem.DeviceItems)
                        {
                            deviceSubItemName = deviceSubItem.Name;
                            deviceSubSubItemName = "";
                            //ModuleItem localModule = new ModuleItem() { Name = deviceSubItem.Name, FullName = name + "_" + deviceSubItem.Name, OrderNumber = _orderNumber, FirmwareVersion = _firmware, PositionNumber = deviceSubItem.PositionNumber, AddressItems = new List<AddressItem>() };
                            ModuleItem localModule = new ModuleItem() { Name = deviceItem.Name, FullName = name + "_" + deviceItem.Name, OrderNumber = _orderNumber, FirmwareVersion = _firmware, PositionNumber = deviceItem.PositionNumber, AddressItems = new List<AddressItem>() };

                            foreach (Address address in deviceSubItem.Addresses)
                            {
                                if (address != null && (address.IoType.Equals(AddressIoType.Input) || address.IoType.Equals(AddressIoType.Output)))
                                {
                                    if (address.AddressControllers != null && address.AddressControllers.FirstOrDefault() != null)
                                    {
                                        string _controller = address.AddressControllers.FirstOrDefault().GetAttribute("Name").ToString();

                                        AddressItem addressItem = new AddressItem() { Controller = _controller, IoType = address.IoType, StartAddress = address.StartAddress, BitLength = address.Length, ByteLength = address.Length / 8 };
                                        localModule.AddressItems.Add(addressItem);
                                    }
                                }
                            }

                            foreach (DeviceItem deviceSubSubItem in deviceSubItem.Items)
                            {
                                deviceSubSubItemName = deviceSubSubItem.Name;
                                localModule = new ModuleItem() { Name = deviceSubSubItem.Name, FullName = name + "_" + deviceSubItem.Name + "_" + deviceSubSubItem.Name, OrderNumber = _orderNumber, FirmwareVersion = _firmware, PositionNumber = deviceSubItem.PositionNumber, AddressItems = new List<AddressItem>() };

                                foreach (Address address in deviceSubSubItem.Addresses)
                                {
                                    if (address != null && (address.IoType.Equals(AddressIoType.Input) || address.IoType.Equals(AddressIoType.Output)))
                                    {
                                        if (address.AddressControllers != null && address.AddressControllers.FirstOrDefault() != null)
                                        {
                                            string _controller = address.AddressControllers.FirstOrDefault().GetAttribute("Name").ToString();

                                            AddressItem addressItem = new AddressItem() { Controller = _controller, IoType = address.IoType, StartAddress = address.StartAddress, BitLength = address.Length, ByteLength = address.Length / 8 };
                                            localModule.AddressItems.Add(addressItem);
                                        }
                                    }
                                }
                                if (localModule.AddressItems.Count > 0 )
                                {
                                    localModules.Add(localModule);
                                }
                            }
                            if (localModule.AddressItems.Count > 0 && deviceSubItem.Items.Count == 0) 
                            {
                                localModules.Add(localModule);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw;
                }
            }
            return localModules.OrderBy(p => p.PositionNumber).ToList();
        }

        /// <summary>
        /// Get all local modules
        /// </summary>
        public IList<HwIdentifierItem> GetAllHwIdentifiers(Device device, string name)
        {
            IList<HwIdentifierItem> HwIdentifiers = new List<HwIdentifierItem>();

            foreach (DeviceItem deviceItem in device.DeviceItems)
            {
                try
                {
                    if (deviceItem != null)
                    {
                        string controller = "";

                        if (deviceItem.HwIdentifiers != null && deviceItem.HwIdentifiers.Count > 0 && deviceItem.HwIdentifiers[0] != null)
                        {
                            HwIdentifier HwIdentifier = deviceItem.HwIdentifiers[0];
                            controller = HwIdentifier.HwIdentifierControllers != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault() != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name") != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name").ToString() : "" : "" : "";
                            HwIdentifierItem hwIdentifierItem = new HwIdentifierItem() { Controller = controller, Name = name.Equals(deviceItem.Name) ? name : name + "_" + deviceItem.Name, Identifier = HwIdentifier.Identifier };
                            if (IsNewHardwareId(hwIdentifierItem.Name, HwIdentifiers))
                            {
                                HwIdentifiers.Add(hwIdentifierItem);
                            }
                        }

                        foreach (var deviceSubItem in deviceItem.DeviceItems)
                        {
                            foreach (HwIdentifier HwIdentifier in deviceSubItem.HwIdentifiers)
                            {
                                controller = HwIdentifier.HwIdentifierControllers != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault() != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name") != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name").ToString() : "" : "" : "";
                                string _name = name.Equals(deviceItem.Name) ? name + "_" + deviceSubItem.Name : name + "_" + deviceItem.Name;
                                HwIdentifierItem hwIdentifierItem = new HwIdentifierItem() { Controller = controller, Name = _name, Identifier = HwIdentifier.Identifier };
                                if (IsNewHardwareId(hwIdentifierItem.Name, HwIdentifiers))
                                {
                                    HwIdentifiers.Add(hwIdentifierItem);
                                }
                            }
                            foreach (DeviceItem deviceSubSubItem in deviceSubItem.Items)
                            {
                                foreach (HwIdentifier HwIdentifier in deviceSubSubItem.HwIdentifiers)
                                {
                                    controller = HwIdentifier.HwIdentifierControllers != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault() != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name") != null ? HwIdentifier.HwIdentifierControllers.FirstOrDefault().GetAttribute("Name").ToString() : "" : "" : "";
                                    string _name = name.Equals(deviceItem.Name) ? deviceItem.Name + "_" + deviceSubItem.Name + "_" + deviceSubSubItem.Name : deviceItem.Name + "_" + deviceSubItem.Name + "_" + deviceSubSubItem.Name;
                                    HwIdentifierItem hwIdentifierItem = new HwIdentifierItem() { Controller = controller, Name = _name, Identifier = HwIdentifier.Identifier };
                                    if (IsNewHardwareId(hwIdentifierItem.Name, HwIdentifiers))
                                    {
                                        HwIdentifiers.Add(hwIdentifierItem);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw;
                }
            }
            return HwIdentifiers;
        }
        public bool IsNewHardwareId(string name, IList<HwIdentifierItem> HwIdentifiers)
        {
            bool isNew = true;
            foreach (HwIdentifierItem hwIdentifierItem in HwIdentifiers)
            {
                if (hwIdentifierItem.Name.Equals(name))
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }

        /// <summary>
        /// Export all PLCs
        /// </summary>
        public void ExportAllPLCs(string exportDirectory, bool IO, bool HWID, ProjectItem projectItem)
        {
            DeleteFolder(exportDirectory);
            Directory.CreateDirectory(exportDirectory);
            foreach (PlcItem plcItem in projectItem.PlcItems)
            {
                string exportDir = String.IsNullOrEmpty(exportDirectory) ? Path.Combine(Environment.CurrentDirectory, plcItem.Name) : Path.Combine(exportDirectory, plcItem.Name);
                Directory.CreateDirectory(exportDir);

                if (IO)
                {
                    ExportMappingItems(plcItem, exportDir, ExportItemType.HwInput);
                    ExportMappingItems(plcItem, exportDir, ExportItemType.HwOutput);
                    ExportMappingItems(plcItem, exportDir, ExportItemType.PlcInput);
                    ExportMappingItems(plcItem, exportDir, ExportItemType.PlcOutput);
                    ExportCopyInputs(plcItem, exportDir);
                    ExportCopyOutputs(plcItem, exportDir);
                    ExportConfiguration(exportDir);
                    ExportProgram(exportDir);
                }
                if (HWID)
                {
                    ExportHwIdentifiers(plcItem, exportDir);
                }
            }
        }

        /// <summary>
        /// Export mapping items
        /// </summary>
        private static void ExportMappingItems(PlcItem plcItem, string exportDir, ExportItemType exportItemType)
        {
            string filename = "";
            string structname = "";

            switch (exportItemType)
            {
                case ExportItemType.HwInput:
                    filename = Path.Combine(exportDir, Constants.HwInputsStructName + ".st");
                    structname = Constants.HwInputsStructName;
                    break;
                case ExportItemType.HwOutput:
                    filename = Path.Combine(exportDir, Constants.HwOutputsStructName + ".st");
                    structname = Constants.HwOutputsStructName;
                    break;
                case ExportItemType.PlcInput:
                    filename = Path.Combine(exportDir, Constants.PlcInputsStructName + ".st");
                    structname = Constants.PlcInputsStructName;
                    break;
                case ExportItemType.PlcOutput:
                    filename = Path.Combine(exportDir, Constants.PlcOutputsStructName + ".st");
                    structname = Constants.PlcOutputsStructName;
                    break;
            }

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("TYPE");
                sw.WriteLine("\t" + structname + " : STRUCT");
                if (plcItem.LocalModules != null)
                {
                    foreach (ModuleItem module in plcItem.LocalModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (exportItemType == ExportItemType.HwInput && addressItem.IoType.Equals(AddressIoType.Input) || exportItemType == ExportItemType.HwOutput && addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                sw.WriteLine(GetHwItem(module, addressItem));
                            }
                            if (exportItemType == ExportItemType.PlcInput && addressItem.IoType.Equals(AddressIoType.Input) || exportItemType == ExportItemType.PlcOutput && addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                sw.WriteLine(GetPlcItem(module, addressItem));
                            }
                        }
                    }
                }

                if (plcItem.DistributedModules != null)
                {
                    foreach (ModuleItem module in plcItem.DistributedModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (exportItemType == ExportItemType.HwInput && addressItem.IoType.Equals(AddressIoType.Input) || exportItemType == ExportItemType.HwOutput && addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                sw.WriteLine(GetHwItem(module, addressItem));
                            }
                            if (exportItemType == ExportItemType.PlcInput && addressItem.IoType.Equals(AddressIoType.Input) || exportItemType == ExportItemType.PlcOutput && addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                sw.WriteLine(GetPlcItem(module, addressItem));
                            }
                        }
                    }
                }
                sw.WriteLine("\tEND_STRUCT;");
                sw.WriteLine("END_TYPE");
            }

            string GetHwItem(ModuleItem module, AddressItem addressItem)
            {
                return "\t\t" + ValidatePlcItem.Name(module.FullName) + " AT %B" + addressItem.StartAddress + " : " + GetDataType(addressItem) + ";";
            }

            string GetPlcItem(ModuleItem module, AddressItem addressItem)
            {
                return "\t\t" + ValidatePlcItem.Name(module.FullName) + " : " + GetDataType(addressItem) + ";";
            }

            string GetDataType(AddressItem addressItem)
            {
                switch (addressItem.ByteLength)
                {
                    case 1:
                        return "BYTE";
                    case 2:
                        return "WORD";
                    case 4:
                        return "DWORD";
                    default:
                        return "ARRAY[0.." + (addressItem.ByteLength - 1) + "] OF BYTE";
                }
            }
        }

        /// <summary>
        /// Export mapping items
        /// </summary>
        private static void ExportHwIdentifiers(PlcItem plcItem, string exportDir)
        {
            string filename = Path.Combine(exportDir, Constants.HwIdentifiersStructName + ".st");
 
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("TYPE");
                sw.WriteLine("\t" + Constants.HwIdentifiersStructName + " : WORD");
                sw.WriteLine("\t(");
        
                if (plcItem.HwIdentifiers != null)
                    {
                        foreach (HwIdentifierItem hwIdItem in plcItem.HwIdentifiers)
                        {
                            sw.WriteLine(GetHwIdentItem(hwIdItem));
                        }
                    }
                sw.WriteLine("\t\tNONE:= WORD#0");
                sw.WriteLine("\t);");
                sw.WriteLine("END_TYPE");
            }

            string GetHwItem(ModuleItem module, AddressItem addressItem)
            {
                return "\t\t" + ValidatePlcItem.Name(module.FullName) + " AT %B" + addressItem.StartAddress + " : " + GetDataType(addressItem) + ";";
            }

            string GetHwIdentItem(HwIdentifierItem  hwIdItem)
            {
                return "\t\t" + ValidatePlcItem.Name(hwIdItem.Name) + " :=\tWORD#" + hwIdItem.Identifier.ToString() + ",";
            }

            string GetPlcItem(ModuleItem module, AddressItem addressItem)
            {
                return "\t\t" + ValidatePlcItem.Name(module.FullName) + " : " + GetDataType(addressItem) + ";";
            }

            string GetDataType(AddressItem addressItem)
            {
                switch (addressItem.ByteLength)
                {
                    case 1:
                        return "BYTE";
                    case 2:
                        return "WORD";
                    case 4:
                        return "DWORD";
                    default:
                        return "ARRAY[0.." + (addressItem.ByteLength - 1) + "] OF BYTE";
                }
            }
        }

        private static void ExportCopyInputs(PlcItem plcItem, string exportDir)
        {
            string filename = Path.Combine(exportDir, Constants.CopyInputsFunctionName + ".st");

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("FUNCTION " + Constants.CopyInputsFunctionName);
                sw.WriteLine("\tVAR_EXTERNAL");
                sw.WriteLine("\t\t" + Constants.HwInputsStructName + " : " + Constants.HwInputsStructName + "; ");
                sw.WriteLine("\t\t" + Constants.PlcInputsStructName + " : " + Constants.PlcInputsStructName + "; ");
                sw.WriteLine("\tEND_VAR");

                if (plcItem.LocalModules != null)
                {
                    foreach (ModuleItem module in plcItem.LocalModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (addressItem.IoType.Equals(AddressIoType.Input))
                            {
                                if (addressItem.ByteLength == 1 || addressItem.ByteLength == 2 || addressItem.ByteLength == 4)
                                {
                                    sw.WriteLine("\t" + Constants.PlcInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + " := " + Constants.HwInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + ";");
                                }
                                else
                                {
                                    for (int i = 0; i < addressItem.ByteLength; i++)
                                    {
                                        sw.WriteLine("\t" + Constants.PlcInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "] := " + Constants.HwInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "];");
                                    }
                                }
                            }
                        }
                    }
                }

                if (plcItem.DistributedModules != null)
                {
                    foreach (ModuleItem module in plcItem.DistributedModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (addressItem.IoType.Equals(AddressIoType.Input))
                            {
                                if (addressItem.ByteLength == 1 || addressItem.ByteLength == 2 || addressItem.ByteLength == 4)
                                {
                                    sw.WriteLine("\t" + Constants.PlcInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + " := " + Constants.HwInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + ";");
                                }
                                else
                                {
                                    for (int i = 0; i < addressItem.ByteLength; i++)
                                    {
                                        sw.WriteLine("\t" + Constants.PlcInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "] := " + Constants.HwInputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "];");
                                    }
                                }
                            }
                        }
                    }
                }
                sw.WriteLine("END_FUNCTION");
            }
        }

        private static void ExportCopyOutputs(PlcItem plcItem, string exportDir)
        {
            string filename = Path.Combine(exportDir, Constants.CopyOutputsFunctionName + ".st");

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("FUNCTION " + Constants.CopyOutputsFunctionName);
                sw.WriteLine("\tVAR_EXTERNAL");
                sw.WriteLine("\t\t" + Constants.HwOutputsStructName + " : " + Constants.HwOutputsStructName + "; ");
                sw.WriteLine("\t\t" + Constants.PlcOutputsStructName + " : " + Constants.PlcOutputsStructName + "; ");
                sw.WriteLine("\tEND_VAR");

                if (plcItem.LocalModules != null)
                {
                    foreach (ModuleItem module in plcItem.LocalModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                if (addressItem.ByteLength == 1 || addressItem.ByteLength == 2 || addressItem.ByteLength == 4)
                                {
                                    sw.WriteLine("\t" + Constants.HwOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + " := " + Constants.PlcOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + ";");
                                }
                                else
                                {
                                    for (int i = 0; i < addressItem.ByteLength; i++)
                                    {
                                        sw.WriteLine("\t" + Constants.HwOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "] := " + Constants.PlcOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "];");
                                    }
                                }
                            }
                        }
                    }
                }
                if (plcItem.DistributedModules != null)
                {
                    foreach (ModuleItem module in plcItem.DistributedModules)
                    {
                        foreach (AddressItem addressItem in module.AddressItems)
                        {
                            if (addressItem.IoType.Equals(AddressIoType.Output))
                            {
                                if (addressItem.ByteLength == 1 || addressItem.ByteLength == 2 || addressItem.ByteLength == 4)
                                {
                                    sw.WriteLine("\t" + Constants.HwOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + " := " + Constants.PlcOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + ";");
                                }
                                else
                                {
                                    for (int i = 0; i < addressItem.ByteLength; i++)
                                    {
                                        sw.WriteLine("\t" + Constants.HwOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "] := " + Constants.PlcOutputsStructName + "." + ValidatePlcItem.Name(module.FullName) + "[" + i.ToString() + "];");
                                    }
                                }
                            }
                        }
                    }
                }
                sw.WriteLine("END_FUNCTION");
            }
        }

        private static void ExportConfiguration(string exportDir)
        {
            string filename = Path.Combine(exportDir, Constants.ConfigurationVarGlobalSectionFileName);

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("\t//Copy this VAR_GLOBAL section into your configuration file inside your project.");
                sw.WriteLine("\t//Do not change any names, addresses or any another content.");
                sw.WriteLine("\tVAR_GLOBAL");
                sw.WriteLine("\t\t" + Constants.HwInputsStructName + " AT %IB0 : " + Constants.HwInputsStructName + ";");
                sw.WriteLine("\t\t" + Constants.HwOutputsStructName + " AT %QB0 : " + Constants.HwOutputsStructName + ";");
                sw.WriteLine("\t\t" + Constants.PlcInputsStructName + " : " + Constants.PlcInputsStructName + ";");
                sw.WriteLine("\t\t" + Constants.PlcOutputsStructName + " : " + Constants.PlcOutputsStructName + ";");
                sw.WriteLine("\tEND_VAR");
            }
        }

        private static void ExportProgram(string exportDir)
        {
            string filename = Path.Combine(exportDir, Constants.ProgramSectionsFileName);

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("\t//Copy this VAR_EXTERNAL section into the declaration part of your main program file inside your project.");
                sw.WriteLine("\t//Do not change any names, addresses or any another content.");
                sw.WriteLine("\tVAR_EXTERNAL");
                sw.WriteLine("\t\t" + Constants.PlcInputsStructName + " : " + Constants.PlcInputsStructName + ";");
                sw.WriteLine("\t\t" + Constants.PlcOutputsStructName + " : " + Constants.PlcOutputsStructName + ";");
                sw.WriteLine("\tEND_VAR");

                sw.WriteLine("\t//Copy this function call at the very beginning of your program.");
                sw.WriteLine("\t//Do not change any names, addresses or any another content.");
                sw.WriteLine("\t" + Constants.CopyInputsFunctionName + "();");


                sw.WriteLine("\t//Copy this function call at the very end of your program.");
                sw.WriteLine("\t//Do not change any names, addresses or any another content.");
                sw.WriteLine("\t" + Constants.CopyOutputsFunctionName + "();");
            }
        }

        enum ExportItemType
        {
            HwInput,
            HwOutput,
            PlcInput,
            PlcOutput
        }

        private static void DeleteFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return;

            foreach (string file in Directory.GetFiles(folderPath))
            {
                File.Delete(file);
            }

            foreach (string dir in Directory.GetDirectories(folderPath))
            {
                DeleteFolder(dir);
            }
            Directory.Delete(folderPath);
        }

        #endregion // Device

        #endregion // methods
    }
}
