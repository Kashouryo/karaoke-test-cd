﻿// Copyright (c) andy840119 <andy840119@gmail.com>. Licensed under the GPL Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using System.Linq;
using osu.Framework.Graphics.Sprites;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Karaoke.Objects;

namespace osu.Game.Rulesets.Karaoke.Beatmaps
{
    public class KaraokeBeatmap : Beatmap<KaraokeHitObject>
    {
        public override IEnumerable<BeatmapStatistic> GetStatistics()
        {
            int lyrics = HitObjects.Count(s => s is LyricLine);

            return new[]
            {
                new BeatmapStatistic
                {
                    Name = @"Lyric",
                    Content = lyrics.ToString(),
                    Icon = FontAwesome.Regular.Circle
                },
            };
        }
    }
}
