//------------------------------------------------------------------------------
// <copyright file="WinFormsSecurity.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 */


namespace System.Windows.Forms
{

    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System;
    using System.IO;
    using System.Security.Permissions;
    using System.Security;
    using System.Drawing.Printing;
    using System.Runtime.Versioning;

    internal static class IntSecurity
    {
        public static readonly TraceSwitch SecurityDemand = new TraceSwitch("SecurityDemand", "Trace when security demands occur.");
#if DEBUG
        public static readonly BooleanSwitch MapSafeTopLevelToSafeSub = new BooleanSwitch("MapSafeTopLevelToSafeSub", "Maps the SafeTopLevelWindow UI permission to SafeSubWindow permission. Must restart to take effect.");
#endif

        private static CodeAccessPermission allPrinting;
        private static CodeAccessPermission allWindows;
        private static CodeAccessPermission clipboardOwn;
        private static CodeAccessPermission modifyFocus;
        private static CodeAccessPermission objectFromWin32Handle;
        private static CodeAccessPermission safeSubWindows;
        private static CodeAccessPermission unmanagedCode;


        public static CodeAccessPermission AllPrinting
        {
            get
            {
                if (allPrinting == null)
                {
                    allPrinting = new PrintingPermission(PrintingPermissionLevel.AllPrinting);
                }
                return allPrinting;
            }
        }

        public static CodeAccessPermission AllWindows
        {
            get
            {
                if (allWindows == null)
                {
                    allWindows = new UIPermission(UIPermissionWindow.AllWindows);
                }
                return allWindows;
            }
        }

        public static CodeAccessPermission ClipboardOwn
        {
            get
            {
                if (clipboardOwn == null)
                {
                    clipboardOwn = new UIPermission(UIPermissionClipboard.OwnClipboard);
                }
                return clipboardOwn;
            }
        }

        public static CodeAccessPermission ModifyFocus
        {
            get
            {
                if (modifyFocus == null)
                {
                    modifyFocus = AllWindows;
                }
                return modifyFocus;
            }
        }

        public static CodeAccessPermission ObjectFromWin32Handle
        {
            get
            {
                if (objectFromWin32Handle == null)
                {
                    objectFromWin32Handle = UnmanagedCode;
                }
                return objectFromWin32Handle;
            }
        }


        public static CodeAccessPermission SafeSubWindows
        {
            get
            {
                if (safeSubWindows == null)
                {
                    safeSubWindows = new UIPermission(UIPermissionWindow.SafeSubWindows);
                }
                return safeSubWindows;
            }
        }

        public static CodeAccessPermission UnmanagedCode
        {
            get
            {
                if (unmanagedCode == null)
                {
                    unmanagedCode = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
                }
                return unmanagedCode;
            }
        }

        [ResourceExposure(ResourceScope.Machine)]
        [ResourceConsumption(ResourceScope.Machine)]
        internal static string UnsafeGetFullPath(string fileName)
        {
            string full = fileName;

            FileIOPermission fiop = new FileIOPermission(PermissionState.None);
            fiop.AllFiles = FileIOPermissionAccess.PathDiscovery;
            fiop.Assert();
            try
            {
                full = Path.GetFullPath(fileName);
            }
            finally
            {
                CodeAccessPermission.RevertAssert();
            }
            return full;
        }
    }
}
