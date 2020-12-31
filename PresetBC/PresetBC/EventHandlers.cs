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

            Player sender = ev.Sender;

            if (!sender.CheckPermission("pbc.broadcast"))
            {
                ev.ReplyMessage = ("Permission Denied.");
            }
            else {
                if (ev.Name == "pre")
                {
                    ev.ReplyMessage = ("\n1. " + plugin.Config.ShorthandBroadcast1 + "\n" +
                    "2. " + plugin.Config.ShorthandBroadcast2 + "\n" +
                    "3. " + plugin.Config.ShorthandBroadcast3 + "\n" +
                    "4. " + plugin.Config.ShorthandBroadcast4 + "\n" +
                    "5. " + plugin.Config.ShorthandBroadcast5 + "\n" +
                    "6. " + plugin.Config.ShorthandBroadcast6 + "\n" +
                    "7. " + plugin.Config.ShorthandBroadcast7 + "\n" +
                    "8. " + plugin.Config.ShorthandBroadcast8 + "\n" +
                    "9. " + plugin.Config.ShorthandBroadcast9);
                }
                else if (ev.Name == "pre1" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast1)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast1);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre2" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast2)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast2);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre3" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast3)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast3);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre4" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast4)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast4);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre5" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast5)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast5);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre6" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast6)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast6);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre7" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast7)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast7);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre8" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast8)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast8);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }
                else if (ev.Name == "pre9" || ev.Name == "pre" + plugin.Config.ShorthandBroadcast9)
                {
                    Map.Broadcast(plugin.Config.BroadcastDuration, plugin.Config.Broadcast9);
                    ev.ReplyMessage = ("Broadcast Sent.");
                }

            }
            
        }
    }
}
