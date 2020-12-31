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

        [Description("What's the shorthand of broadcast 1?")]
        public string ShorthandBroadcast1 { get; set; } = "Hello World!";

        [Description("What is broadcast 1?")]
        public string Broadcast1 { get; set; } = "<size=40><color=#ff0000ff><b>Hello, world!</b></color></size> \n <size=25>This is a sample broadcast!</size>";

        [Description("What's the shorthand of broadcast 2?")]
        public string ShorthandBroadcast2 { get; set; } = "";

        [Description("What is broadcast 2?")]
        public string Broadcast2 { get; set; } = "";

        [Description("What's the shorthand of broadcast 3?")]
        public string ShorthandBroadcast3 { get; set; } = "Empty.";

        [Description("What is broadcast 3?")]
        public string Broadcast3 { get; set; } = "";

        [Description("What's the shorthand of broadcast 4?")]
        public string ShorthandBroadcast4 { get; set; } = "Empty.";

        [Description("What is broadcast 4?")]
        public string Broadcast4 { get; set; } = "";

        [Description("What's the shorthand of broadcast 5?")]
        public string ShorthandBroadcast5 { get; set; } = "Empty.";

        [Description("What is broadcast 5?")]
        public string Broadcast5 { get; set; } = "";

        [Description("What's the shorthand of broadcast 6?")]
        public string ShorthandBroadcast6 { get; set; } = "Empty.";

        [Description("What is broadcast 6?")]
        public string Broadcast6 { get; set; } = "";

        [Description("What's the shorthand of broadcast 7?")]
        public string ShorthandBroadcast7 { get; set; } = "Empty.";

        [Description("What is broadcast 7?")]
        public string Broadcast7 { get; set; } = "";

        [Description("What's the shorthand of broadcast 8?")]
        public string ShorthandBroadcast8 { get; set; } = "Empty.";

        [Description("What is broadcast 8?")]
        public string Broadcast8 { get; set; } = "";

        [Description("What's the shorthand of broadcast 9?")]
        public string ShorthandBroadcast9 { get; set; } = "Empty.";

        [Description("What is broadcast 9?")] 
        public string Broadcast9 { get; set; } = "";
    }
}
