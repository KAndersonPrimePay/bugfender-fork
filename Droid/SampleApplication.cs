﻿using System;
using Android.App;
using Android.Runtime;

using Com.Bugfender.Sdk;

[Application]
public class SampleApplication : Application
{
    public SampleApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
        Bugfender.Init(this.ApplicationContext, "jv7uuCzhmOWoma4x5NxoSb6EfJt7vX4Z", true);
        Bugfender.EnableUIEventLogging(this);
        Bugfender.EnableLogcatLogging();
        Bugfender.EnableXamarinCrashReporting();

        Bugfender.D("TAG", "Hello, testing!");
        Bugfender.W("TAG", "Hello, warning!");
        Bugfender.E("TAG", Bugfender.DeviceIdentifier);
    }
}