﻿// Copyright (c) andy840119 <andy840119@gmail.com>. Licensed under the GPL Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Karaoke.Objects.Types;

namespace osu.Game.Rulesets.Karaoke.Objects
{
    public struct RomajiTag : ITag
    {
        /// <summary>
        /// If kanji Matched, then apply romaji
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Start index
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// End index
        /// </summary>
        public int EndIndex { get; set; }
    }
}
