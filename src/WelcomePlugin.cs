using System;
using IModApi;
using UnityEngine;

[assembly: ModInfo("WelcomePlugin", "7DayPlugins", Version = "1.0.0", Description = "玩家进入服务器发送欢迎消息")] 
[assembly: ModPriority(ModPriority.Medium)]

namespace WelcomePlugin
{
    public class WelcomePlugin : IModApi
    {
        public void InitMod(Mod mod)
        {
            ModEvents.PlayerConnected.Register(this, OnPlayerConnected);
        }

        private void OnPlayerConnected(ClientInfo clientInfo, bool firstConnection)
        {
            if (clientInfo == null) return;

            string welcome = $"[欢迎] 欢迎 {clientInfo.playerName} 来到服务器！";
            GameManager.Instance.GameMessageClient(clientInfo.entityId, EnumGameMessages.Chat, welcome);
        }
    }
}
