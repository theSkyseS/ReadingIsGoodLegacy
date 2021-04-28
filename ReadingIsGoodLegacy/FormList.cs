using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;

namespace ReadingIsGoodLegacy
{
    public class ReadingIsGood
    {
        private FormLink<IFormListGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
        
        public readonly ModKey ModKey;
        public List<FormLink<IFormListGetter>> FormLists;
        public ReadingIsGood(GameRelease gameRelease)
        {
            ModKey = gameRelease switch
            {
                GameRelease.SkyrimLE => ModKey.FromNameAndExtension("Reading Is Good 2.esp"),
                GameRelease.SkyrimSE or GameRelease.SkyrimVR => ModKey.FromNameAndExtension("ReadingIsGood.esp"),
                _ => ModKey
            };
            FormLists = new List<FormLink<IFormListGetter>>()
            {
                Construct(0xd74),
                Construct(0xd75),
                Construct(0xd76),
                Construct(0xd77),
                Construct(0xd78),
                Construct(0xd79),
                Construct(0xd7a),
                Construct(0xd7b),
                Construct(0xd7c),
                Construct(0xd7d),
                Construct(0xd7e),
                Construct(0xd7f),
                Construct(0xd80),
                Construct(0xd81),
                Construct(0xd82),
                Construct(0xd83),
                Construct(0xd84),
                Construct(0xd85),
                Construct(0xd86),
                Construct(0xd87),
                Construct(0xd88),
                Construct(0xd89),
                Construct(0xd8a),
                Construct(0xd8b),
                Construct(0xd8c),
                Construct(0xd8d),
                Construct(0xd8e),
                Construct(0xd8f),
                Construct(0xd90),
                Construct(0xd91),
                Construct(0xd92),
                Construct(0xd93),
                Construct(0xd94),
                Construct(0xd95),
                Construct(0xd96),
                Construct(0xd97)
            };
        }
    }
}
