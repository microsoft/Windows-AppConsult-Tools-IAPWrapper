using System;
using System.Threading.Tasks;

namespace IAPUWPDLL
{
    public class IAPWrapper
    {         
        public IAPWrapper()
        {
            throw new NotImplementedException();
        }
        public async Task<string> Purchase(string storeId)        {

            await Task.Run(() => { });
            return  String.Empty;
            
        }
    }
}
