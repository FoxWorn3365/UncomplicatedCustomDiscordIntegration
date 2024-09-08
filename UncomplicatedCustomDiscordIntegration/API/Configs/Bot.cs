﻿using SimpleDiscord.Enums;
using System.ComponentModel;

namespace UncomplicatedDiscordIntegration.API.Configs
{
    public sealed class Bot
    {
        public string Token { get; set; } = string.Empty;

        [Description("The status that the bot will have")]
        public string Presence { get; set; } = "%current%/%total% players online";

        [Description("The presence that the bot will show (es: Playing <game>)")]
        public ActivityType PresenceActivity { get; set; } = ActivityType.Watching;

        [Description("If true every log will be sent inside an embed")]
        public bool ShouldUseEmbeds { get; set; } = false;

        [Description("Choose how many log entries can be held inside the same message to avoid Discord ratelimit")]
        public int BucketSize { get; set; } = 10;
    }
}
