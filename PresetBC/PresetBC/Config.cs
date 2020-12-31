using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Exiled.API.Interfaces;
using Exiled.Loader;

namespace PresetBC
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("How long do the broadcasts last?")]
        public ushort BroadcastDuration { get; set; } = 15;

        [Description("Define your broadcasts here.")]
        public List<string> Broadcasts = new List<string>() {
            "Hello World!: <size=40><color=#ff0000ff><b>Hello, world!</b></color></size> \n <size=25>This is a sample broadcast!</size>"
        };
        
        internal List<string[]> GetBroadcasts(){
            return Broadcasts.Select(bc => bc.Split(new string[]{": "}, 2, StringSplitOptions.None));
        }
    }
}
