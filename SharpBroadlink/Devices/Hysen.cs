﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SharpBroadlink.Devices
{
    public class Hysen : Device
    {
        public Hysen(IPEndPoint host, byte[] mac, int devType) : base(host, mac, devType)
        {
            this.DeviceType = DeviceType.Hysen;

            throw new NotImplementedException(@"if you want: https://github.com/mjg59/python-broadlink/blob/56b2ac36e5a2359272f4af8a49cfaf3e1891733a/broadlink/__init__.py#L573-L742");
        }
    }
}
