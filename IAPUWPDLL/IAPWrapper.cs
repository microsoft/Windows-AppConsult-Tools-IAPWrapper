using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Store;

namespace IAPUWPDLL
{
    public class IAPWrapper
    {
        /*
        [ComImport]
        [Guid("3E68D4BD-7135-4D10-8018-9FB6D9F33FA1")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IInitializeWithWindow
        {
            void Initialize(IntPtr hwnd);
        }

        [ComImport, Guid("45D64A29-A63E-4CB6-B498-5781D298CB4F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface ICoreWindowInterop
        {
            IntPtr WindowHandle { get; }
            bool MessageHandled { set; }
        }
        */
        private static StoreContext storeContext = null;

        public IAPWrapper()
        {
             
        }
        public async Task<string> Purchase(string storeId)
        {
            

            string statusText = string.Empty;
         if (storeContext == null)
                storeContext = StoreContext.GetDefault();

          await  storeContext.GetAppLicenseAsync();
         /*
            IInitializeWithWindow initWindow = (IInitializeWithWindow)(object)storeContext;
                dynamic corewin = Windows.UI.Core.CoreWindow.GetForCurrentThread();
                var interop = (ICoreWindowInterop)corewin;
                var handle = interop.WindowHandle;
                //var ptr = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
                initWindow.Initialize(handle);
            // If your app is a desktop app that uses the Desktop Bridge, you
            // may need additional code to configure the StoreContext object.
            // For more info, see https://aka.ms/storecontext-for-desktop.
            */
            StorePurchaseResult result = await storeContext.RequestPurchaseAsync(storeId);             

            // Capture the error message for the operation, if any.
            string extendedError = string.Empty;
            if (result.ExtendedError != null)
            {
                extendedError = result.ExtendedError.Message;
            }

            switch (result.Status)
            {
                case StorePurchaseStatus.AlreadyPurchased:
                    statusText = "The user has already purchased the product.";
                    break;

                case StorePurchaseStatus.Succeeded:
                    statusText = "The purchase was successful.";
                    break;

                case StorePurchaseStatus.NotPurchased:
                    statusText = "The purchase did not complete. " +
                        "The user may have cancelled the purchase. ExtendedError: " + extendedError;
                    break;

                case StorePurchaseStatus.NetworkError:
                    statusText = "The purchase was unsuccessful due to a network error. " +
                        "ExtendedError: " + extendedError;
                    break;

                case StorePurchaseStatus.ServerError:
                    statusText = "The purchase was unsuccessful due to a server error. " +
                        "ExtendedError: " + extendedError;
                    break;

                default:
                    statusText = "The purchase was unsuccessful due to an unknown error. " +
                        "ExtendedError: " + extendedError;
                    break;
            }
            return statusText;
        }
    }
}
