using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


#if NETFX_CORE
using System.Threading.Tasks;
using IAPUWPDLL;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Popups;
#endif

/* Can call IAP in Win32 and UWP built properly */
public class IAPCaller : MonoBehaviour
{
#if !NETFX_CORE
    [DllImport("IAPWrapper")]

    extern static IntPtr Purchase(string storeID);
#endif
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
#if !NETFX_CORE
            StartCoroutine(CoroutineCallTask());
#else
            callIAP();
            //StartCoroutine(CoroutineCallTask());
            //DiagTest();
#endif
    }
    public async Task<String> TaskOnClickAsync()
    {
        String statusText =  String.Empty;
#if !NETFX_CORE
         Purchase("abc");
#else
        IAPWrapper iapwrapper = new IAPWrapper();
        await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
        {
            statusText = await iapwrapper.Purchase("abc");
        });
        //statusText = await iapwrapper.Purchase("abc");
#endif
        Debug.Log("You have clicked the mouse! "+ statusText);
        return statusText;
    }
    public delegate void CallIAP();

    public static CallIAP callIAP;
    public IEnumerator CoroutineCallTask()
    {
        var task = TaskOnClickAsync();
        yield return new WaitUntil(() => task.IsCompleted || task.IsFaulted || task.IsCanceled);

        if (task.IsCompleted)
        {
            Debug.Log("Completed!");
        }
    }
#if NETFX_CORE
    public async void DiagTest()
    {
        var dialog = new MessageDialog("当前设置尚未保存，你确认要退出该页面吗?", "消息提示");

        dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
        dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

        //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
        dialog.DefaultCommandIndex = 0;
        dialog.CancelCommandIndex = 1;

        //获取返回值
        var result2 = await dialog.ShowAsync();
    }
#endif
}
