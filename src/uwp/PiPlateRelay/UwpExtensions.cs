﻿using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace PiPlateRelay
{
    internal class UwpExtensions
    {
        public static async Task CallOnUiThreadAsync(CoreDispatcher dispatcher, DispatchedHandler handler) =>
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, handler);

        public static async Task CallOnMainViewUiThreadAsync(DispatchedHandler handler) =>
            await CallOnUiThreadAsync(CoreApplication.MainView.CoreWindow.Dispatcher, handler);
    }
}
