using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Switch:ISwitch
    {
        private IElectronicDevice _electronicDevice;

        public void SetDevice(IElectronicDevice electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void On()
        {
            _electronicDevice.Start();
        }

        public void Off()
        {
            _electronicDevice.Stop();
        }
    }
}
