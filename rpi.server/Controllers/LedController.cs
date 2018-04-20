using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace rpi.server.Controllers
{
    [Route("api/[controller]")]
    public class LedController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id, bool isOn)
        {
            var pin = Pi.Gpio.Pins[id];
            pin.PinMode = GpioPinDriveMode.Input;
            var isOnNow = pin.Read();

            if (isOnNow == isOn)
            {
                return $"id: {id}, isOn: {isOn}, már eleve {isOnNow} az állapot, nem tudom {isOn}-ba tenni még egyszer";
            }
            else
            {
                pin.PinMode = GpioPinDriveMode.Output;
                pin.Write(isOn);
                return $"id: {id}, isOn: {isOn} OK";
            }
        }
    }
}
