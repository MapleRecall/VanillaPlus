using Dalamud.Game.Text;
using FFXIVClientStructs.FFXIV.Client.UI.Misc;
using KamiToolKit.Addons.Interfaces;

namespace VanillaPlus.Features.GearsetRedirect;

public unsafe class GearsetInfo : IInfoNodeData {
    
    public required int GearsetId { get; init; }

    public string GetLabel()
        => GearsetId < 0 ? "Nothing Selected" : GetGearsetData().NameString;

    public string GetSubLabel()
        => GearsetId < 0 ? string.Empty : $"{SeIconChar.ItemLevel.ToIconString()} {GetGearsetData().ItemLevel}";

    public uint? GetId()
        => GearsetId < 0 ? null : (uint) GearsetId;

    public uint? GetIconId()
        => GearsetId < 0 ? 60072 : GetGearsetData().ClassJob + 62000u;

    public string? GetTexturePath()
        => null;

    public int Compare(IInfoNodeData other, string sortingMode) {
        if (sortingMode == Strings.Alphabetical) {
            return string.CompareOrdinal(GetLabel(), other.GetLabel());
        }

        if (sortingMode == Strings.Id) {
            return GetId()?.CompareTo(other.GetId()) ?? 0;
        }

        return 0;
    }

    private ref RaptureGearsetModule.GearsetEntry GetGearsetData()
        => ref RaptureGearsetModule.Instance()->Entries[GearsetId];
}
