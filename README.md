**IAPWRAPPER**

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
