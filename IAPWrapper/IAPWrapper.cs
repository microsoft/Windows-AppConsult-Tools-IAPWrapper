using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Services.Store;

namespace IAPWrapper
{
    public class IAPWrapper
    {
        [ComImport]
        [Guid("3E68D4BD-7135-4D10-8018-9FB6D9F33FA1")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IInitializeWithWindow
        {
            void Initialize(IntPtr hwnd);
        }
        private static StoreContext storeContext = StoreContext.GetDefault();
        [DllExport(CallingConvention.StdCall)]         
        public static string Purchase(string storeID)
        {
            try
            {
                var t = _PurchaseAsync(storeID);
                /*
                IInitializeWithWindow initWindow = (IInitializeWithWindow)(object)storeContext;
                var ptr = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
                initWindow.Initialize(ptr);

                MessageBox.Show("句柄为" + ptr);
                MessageBox.Show("Thread id 2: " + Thread.CurrentThread.ManagedThreadId);

                var task = storeContext.RequestPurchaseAsync(storeID).AsTask();
                task.Wait();
                */
                MessageBox.Show("Thread id 1: " + Thread.CurrentThread.ManagedThreadId);                
                return "Done";
            }
            catch (AggregateException ex)
            {
                return "Exception:" + ex.ToString() + "exMessage:" + ex.Message;
            }
        }
         
        //[DllExport(CallingConvention.StdCall)]
        public static async Task<bool> _PurchaseAsync(string storeID)
        {
             
            IInitializeWithWindow initWindow = (IInitializeWithWindow)(object)storeContext;
            var ptr = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            initWindow.Initialize(ptr);

            MessageBox.Show("句柄为" + ptr);
            MessageBox.Show("Thread id 2: " + Thread.CurrentThread.ManagedThreadId);
            
            var result = await storeContext.RequestPurchaseAsync(storeID).AsTask().ConfigureAwait(false);
            
            if (result.ExtendedError != null)
            {
                MessageBox.Show(result.ExtendedError.Message, result.ExtendedError.HResult.ToString());
            }
            
            switch (result.Status)
            {
                case StorePurchaseStatus.Succeeded:
                    break;
                case StorePurchaseStatus.AlreadyPurchased:
                    break;
                case StorePurchaseStatus.NotPurchased:
                    break;
                case StorePurchaseStatus.NetworkError:
                    break;
                case StorePurchaseStatus.ServerError:
                    break;
                default:
                    break;
            }
                       
            MessageBox.Show("Purchase Finished with status " + result.Status);
            return true;
        }
     
    }
}
