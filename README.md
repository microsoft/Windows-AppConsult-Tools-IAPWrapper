# IAPWRAPPER

Desktop Bridge helps developers gradually migrate traditional apps to the Universal Windows Platform (UWP). The In-App Purchase (IAP) in Windows Store is an important scenario to monetize the converted apps. When working with developers on this scenario, I notice certain obstacles are in common，for example: 

a. Porting old .Net or unmanaged applications to use the IAP UWP APIs.
 
b. Didn’t use async calls properly in UI apps and caused hang/deadlock 

c. Default purchase windows failed to popup 

d. Need accurate guide to follow IAP testing with current Windows Store APIs

Here I would like to explain a general solution to solve above issues, and also show four samples to use the IAPWrapper quickly: 

a. WinForm in old .Net version 

b. WPF app 

c. Win32 App in C++ 

d. Unity App in old .Net version 

Refer to: http://flwe.azurewebsites.net/2017/09/13/enable-in-app-product-purchases-for-desktop-bridge-converted-desktop-applications/

# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
