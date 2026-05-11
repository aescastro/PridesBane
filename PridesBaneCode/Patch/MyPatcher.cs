using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Ascension;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using PridesBane.PridesBaneCode.Cards;

namespace PridesBane.PridesBaneCode.Patch;

[HarmonyPatch(typeof(AscensionManager), nameof(AscensionManager.ApplyEffectsTo))]
public class MyPatcher
{
    static bool Prefix(AscensionManager __instance, Player player)
    {
        if (__instance.HasLevel(AscensionLevel.TightBelt))
            player.SubtractFromMaxPotionCount(1);
        
        if (!__instance.HasLevel(AscensionLevel.AscendersBane))
            return false;
        
        Cards.PridesBane card = player.RunState.CreateCard<Cards.PridesBane>(player);
        card.FloorAddedToDeck = new int?(1);
        player.Deck.AddInternal((CardModel) card, silent: true);
        
        return false;
    }
}