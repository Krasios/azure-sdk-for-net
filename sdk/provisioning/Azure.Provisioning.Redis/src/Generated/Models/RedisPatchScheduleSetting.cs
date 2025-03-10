// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// Patch schedule entry for a Premium Redis Cache.
/// </summary>
public partial class RedisPatchScheduleSetting : ProvisionableConstruct
{
    /// <summary>
    /// Day of the week when a cache can be patched.
    /// </summary>
    public BicepValue<RedisDayOfWeek> DayOfWeek 
    {
        get { Initialize(); return _dayOfWeek!; }
        set { Initialize(); _dayOfWeek!.Assign(value); }
    }
    private BicepValue<RedisDayOfWeek>? _dayOfWeek;

    /// <summary>
    /// Start hour after which cache patching can start.
    /// </summary>
    public BicepValue<int> StartHourUtc 
    {
        get { Initialize(); return _startHourUtc!; }
        set { Initialize(); _startHourUtc!.Assign(value); }
    }
    private BicepValue<int>? _startHourUtc;

    /// <summary>
    /// ISO8601 timespan specifying how much time cache patching can take.
    /// </summary>
    public BicepValue<TimeSpan> MaintenanceWindow 
    {
        get { Initialize(); return _maintenanceWindow!; }
        set { Initialize(); _maintenanceWindow!.Assign(value); }
    }
    private BicepValue<TimeSpan>? _maintenanceWindow;

    /// <summary>
    /// Creates a new RedisPatchScheduleSetting.
    /// </summary>
    public RedisPatchScheduleSetting()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RedisPatchScheduleSetting.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _dayOfWeek = DefineProperty<RedisDayOfWeek>("DayOfWeek", ["dayOfWeek"]);
        _startHourUtc = DefineProperty<int>("StartHourUtc", ["startHourUtc"]);
        _maintenanceWindow = DefineProperty<TimeSpan>("MaintenanceWindow", ["maintenanceWindow"], format: "P");
    }
}
