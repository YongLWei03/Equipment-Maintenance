using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace EquipmentMaintenance
{
    public static class InkInputHelper
    {
        public static void DisableWPFTabletSupport()
        {
            // Get a collection of the tablet devices for this window.  
            TabletDeviceCollection devices = System.Windows.Input.Tablet.TabletDevices;

            if (devices.Count > 0)
            {
                // Get the Type of InputManager.
                Type inputManagerType = typeof(System.Windows.Input.InputManager);

                // Call the StylusLogic method on the InputManager.Current instance.
                object stylusLogic = inputManagerType.InvokeMember("StylusLogic",
                            BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                            null, InputManager.Current, null);

                if (stylusLogic != null)
                {
                    //  Get the type of the stylusLogic returned from the call to StylusLogic.
                    Type stylusLogicType = stylusLogic.GetType();

                    // Loop until there are no more devices to remove.
                    while (devices.Count > 0)
                    {
                        // Remove the first tablet device in the devices collection.
                        stylusLogicType.InvokeMember("OnTabletRemoved",
                                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
                                null, stylusLogic, new object[] { (uint)0 });
                    }
                }
            }
        }
    }

    [Guid("41C81592-514C-48BD-A22E-E6AF638521A6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInputPanelConfiguration
    {
        /// <summary>
        /// Enables a client process to opt-in to the focus tracking mechanism for Windows Store apps that controls the invoking and dismissing semantics of the touch keyboard.
        /// </summary>
        /// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
        int EnableFocusTracking();
    }

    [ComImport, Guid("2853ADD3-F096-4C63-A78F-7FA3EA837FB7")]
    class InputPanelConfiguration
    {
    }
}