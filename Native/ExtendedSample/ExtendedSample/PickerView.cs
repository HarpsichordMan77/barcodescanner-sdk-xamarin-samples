﻿using System;
using Xamarin.Forms;

namespace ExtendedSample
{
    public class PickerView : View
    {
		public event EventHandler StartScanningRequested;
		public event EventHandler PauseScanningRequested;
		public event EventHandler StopScanningRequested;

		public IScannerDelegate Delegate { get; set; }
		public Settings Settings { get; set; }

        public static string GetAppKey()
        {
            return "--ENTER YOUR SCANDIT LICENSE KEY HERE--";
        }

		public void StartScanning()
		{
            StartScanningRequested?.Invoke(this, EventArgs.Empty);
        }

        public void PauseScanning()
        {
            PauseScanningRequested?.Invoke(this, EventArgs.Empty);
        }

        public void StopScanning()
        {
            StopScanningRequested?.Invoke(this, EventArgs.Empty);
        }

        public void DidScan(string symbology, string code)
        {
            if (Delegate != null)
            {
                Delegate.DidScan(symbology, code);
            }
        }
    }
}
