using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Permissions.Extensions;
using RemoteAdmin;
using CommandSystem;
using UnityEngine;
using Log = Exiled.API.Features.Log;

namespace PresetBC
{
    public class EventHandlers
    {
        public PresetBC plugin;
        public EventHandlers(PresetBC plugin)
        {
            this.plugin = plugin;
        }
        public void OnCommand(SendingRemoteAdminCommandEventArgs ev)
        {

            var sender = ev.Sender;

            if (!sender.CheckPermission("pbc.broadcast"))
            {
                ev.ReplyMessage = ("Permission Denied.");
                return;
            }
            
            if (ev.Name == "pre")
            {
                ev.ReplyMessage = "";
                foreach(var bc in plugin.Config.GetBroadcasts()){
                    ev.ReplyMessage += bc[0] + "\n";
                }
            }
            else if (ev.Name.StartsWith("pre"))
            {
                var id = ev.Name.Substring(3);
                var broadcasts = plugin.Config.GetBroadcasts();
                
                if(int.TryParse(id.Trim(), out var index) && index < broadcasts.Count){
                    Map.Broadcast(plugin.Config.BroadcastDuration, broadcasts[index][1]);
                    ev.ReplyMessage = "Broadcast Sent.";
                    return;
                }
                
                var bc = broadcasts.Where(bc => bc[0].Trim().ToLower() == id.Trim().ToLower()).FirstOrDefault();
                if(bc){
                    Map.Broadcast(plugin.Config.BroadcastDuration, bc[0]);
                    ev.ReplyMessage = "Broadcast Sent.";
                    return;
                }
            }
        }
    }
}
