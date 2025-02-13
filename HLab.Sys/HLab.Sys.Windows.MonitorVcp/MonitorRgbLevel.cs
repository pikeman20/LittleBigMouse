﻿using HLab.Sys.Windows.Monitors;
using ReactiveUI;
using System.ComponentModel;

namespace HLab.Sys.Windows.MonitorVcp;

public class MonitorRgbLevel : ReactiveObject
{
    readonly MonitorLevel[] _values = new MonitorLevel[3];

    public MonitorRgbLevel(LevelParser parser, VcpGetter getter, VcpSetter setter)
    {
        for (var i = 0; i < 3; i++)
            _values[i] = new MonitorLevel(parser, getter, setter, (VcpComponent)i);
    }

    public MonitorLevel Channel(uint channel) { return _values[channel]; }

    public MonitorLevel Red => Channel(0);
    public MonitorLevel Green => Channel(1);
    public MonitorLevel Blue => Channel(2);
}