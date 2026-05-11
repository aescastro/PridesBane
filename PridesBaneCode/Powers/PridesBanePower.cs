using BaseLib.Abstracts;
using BaseLib.Extensions;
using PridesBane.PridesBaneCode.Extensions;
using Godot;

namespace PridesBane.PridesBaneCode.Powers;

public abstract class PridesBanePower : CustomPowerModel
{
    //Loads from PridesBane/images/powers/your_power.png
    public override string CustomPackedIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".PowerImagePath();
    public override string CustomBigIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".BigPowerImagePath();
}