﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usmooth.common;

namespace usmooth.app
{
    public class NetGuardTimer
    {
        public const int TimeoutInMilliseconds = 3000;

        private System.Timers.Timer _timer;

        public event SysPost.StdMulticastDelegation Timeout;

        public void Activate()
        {
            _timer = new System.Timers.Timer(TimeoutInMilliseconds);
            _timer.Elapsed += OnTimeout;
            _timer.Start();
        }

        public void Deactivate()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer = null;
            }
        }
        void OnTimeout(object sender, System.Timers.ElapsedEventArgs e)
        {
            SysPost.InvokeMulticast(this, Timeout);
        }
    }
}
