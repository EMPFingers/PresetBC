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
				var broadcasts = plugin.Config.GetBroadcasts();
				
                ev.ReplyMessage = "\n";
                for(var i = 0; i < broadcasts.Count; i++){
                    ev.ReplyMessage += (i+1) + ". "+ broadcasts[i][0] + "\n";
                }
            }
            else if (ev.Name.StartsWith("pre"))
            {
                var id = ev.Name.Substring(3);
                var broadcasts = plugin.Config.GetBroadcasts();
                
                if(int.TryParse(id.Trim(), out var index) && index <= broadcasts.Count && index > 0){
                    Map.Broadcast(plugin.Config.BroadcastDuration, broadcasts[index-1][1]);
                    ev.ReplyMessage = "Broadcast Sent.";
                    return;
                }
                
                var bc = broadcasts.FirstOrDefault(bc => bc[0].Trim().ToLower() == id.Trim().ToLower());
                if(bc){
                    Map.Broadcast(plugin.Config.BroadcastDuration, bc[0]);
                    ev.ReplyMessage = "Broadcast Sent.";
                    return;
                }
            }
        }
    }
}
