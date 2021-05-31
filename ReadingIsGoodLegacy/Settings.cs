using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;

namespace ReadingIsGoodLegacy
{
    public class Settings
    {
        public List<ModKey> PluginsToIgnore { get; set; } = new();
    }
}