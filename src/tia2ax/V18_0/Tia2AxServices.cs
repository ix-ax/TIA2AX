using Tia2Ax.Interfaces;
using Tia2Ax.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Siemens.Engineering;

namespace Tia2Ax.Services
{
    public class Tia2AxServices
    {
        #region fields

        private readonly TraceWriter _traceWriter;
        private readonly ApiWrapper _apiWrapper;

        #endregion // fields

        #region ctor

        public Tia2AxServices(TraceWriter traceWriter, ApiWrapper apiWrapper)
        {
            _traceWriter = traceWriter;
            _apiWrapper = apiWrapper;
            ProjectItem = new ProjectItem();
            SelectedProcessIndex = -1;
        }

        #endregion // ctor

        #region properties

        public int SelectedProcessIndex
        {
            get;
            set;
        }

        public string SelectedProcessItem
        {
            get;
            set;
        }

        public string SelectedProject
        {
            get;
            set;
        }

        public ProjectItem ProjectItem
        {
            get;
            set;
        }

        #endregion // properties

        #region methods

        #region TIA Portal

        /// <summary>
        /// Open a TIA Portal instance
        /// </summary>
        /// <param name="caller"></param>
        public void OpenTiaPortal([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoOpenTiaPortal();
        }

        /// <summary>
        /// Connect to a open TIA Portal instance
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="caller"></param>
        public void ConnectTiaPortal(int processId, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoConnectTiaPortal(processId);
        }

        /// <summary>
        /// Disconnect from an open TIA Portal instance
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="caller"></param>
        public void DisconnectTiaPortal(int processId, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoDisconnectTiaPortal(processId);
        }

        /// <summary>
        /// Close a TIA Portal instance
        /// </summary>
        /// <param name="caller"></param>
        public void CloseTiaPortal([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoCloseTiaPortal();
        }

        /// <summary>
        /// Retrieve the current process id
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string GetCurrentTiaProcessId([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            return _apiWrapper.DoGetCurrentTiaProcessId();
        }

        /// <summary>
        /// Get all TIA Portal processes on the local machine
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public IList<TiaPortalProcess> GetTiaPortalProcesses([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            return _apiWrapper.DoGetTiaPortalProcesses();
        }

        /// <summary>
        /// Extract the process id from selected item and convert to int value
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public int GetSelectedProcessId([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var id = -1;
            if (SelectedProcessIndex > -1)
            {
                id = Convert.ToInt32(SelectedProcessItem.Split(' ')[1]);
            }
            return id;
        }

        /// <summary>
        /// Extract the process id from selected item and get it as string
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string GetSelectedProcessIdAsString([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var processId = string.Empty;
            if (GetSelectedProcessId() > -1)
            {
                processId = GetSelectedProcessId().ToString();
            }
            return processId;
        }

        #endregion // TIA Portal.

        #region TIA Portal Project

        /// <summary>
        /// Retrieve the current project name
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string GetCurrentProjectName([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            return _apiWrapper.CurrentProject != null ? _apiWrapper.CurrentProject.Name : string.Empty;
        }

        /// <summary>
        /// Retrieve the current project target directory
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string GetTargetDirectory([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            return _apiWrapper.CurrentProject != null ? _apiWrapper.CurrentProject.Path.DirectoryName : string.Empty;
        }

        /// <summary>
        /// Retrieve the available project from TIA Portal instance
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public string GetAvailableProject([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            var availableProject = string.Empty;
            if (_apiWrapper.TiaPortal != null && _apiWrapper.TiaPortalIsDisposed == false)
            {
                _apiWrapper.AvailableProject = _apiWrapper.TiaPortal.Projects.FirstOrDefault();

                if (_apiWrapper.AvailableProject != null)
                {
                    availableProject = _apiWrapper.AvailableProject.Name;
                }
            }
            return availableProject;
        }

        /// <summary>
        /// Open a selected project
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public bool OpenProject(string tiaProject, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);
            
            SelectedProject = tiaProject;
            
            var result = false;
          
            if (_apiWrapper.DoOpenProject(SelectedProject))
            {
                    result = true;
            }
            return result;
        }
       
        /// <summary>
        /// Load a open project from connected instance -> see 'DoConnectTiaPortal'
        /// </summary>
        /// <param name="caller"></param>
        public void LoadProject([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoLoadProject();
        }

        /// <summary>
        /// Close a project
        /// </summary>
        /// <param name="caller"></param>
        public void CloseProject([CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.DoCloseProject();
        }

        /// <summary>
        /// Retrieve the PLCs from the current project
        /// </summary>
        /// <param name="caller"></param>
        public void GetPlcList(string outputFolder, bool hwidOnly, [CallerMemberName] string caller = "")
        {
            var methodBase = MethodBase.GetCurrentMethod();
            if (methodBase.ReflectedType != null) _traceWriter.WriteLine(methodBase.ReflectedType.Name + "." + methodBase.Name + " called from " + caller);

            _apiWrapper.GetPlcList(ProjectItem);
            _apiWrapper.ExportAllPLCs(outputFolder, hwidOnly, ProjectItem);
        }

        #endregion // TIA Portal Project

        #endregion // methods
    }
}
