﻿using System.Linq;
using HLab.Sys.Windows.Monitors;
using LittleBigMouse.DisplayLayout.Monitors;

namespace LittleBigMouse.DisplayLayout;

public static class MonitorDeviceExtension
{
    public static PhysicalMonitor GetPhysicalMonitor(this MonitorDevice device, MonitorsLayout layout)
    {

        var monitor = layout.PhysicalMonitors.Items.FirstOrDefault(m => m.Id == device.IdMonitor);
        if (monitor != null) return monitor;
        
        //monitor = new Monitor();
        //monitor.Id = $"{device.IdMonitor}_{device.AttachedDisplay.CurrentMode.DisplayOrientation}";
        //layout.AllMonitors.Add(monitor);
        return monitor;
    }
}