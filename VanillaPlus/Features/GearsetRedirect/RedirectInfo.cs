using FFXIVClientStructs.FFXIV.Client.UI.Misc;
using KamiToolKit.Addons.Interfaces;
using Lumina.Excel.Sheets;

namespace VanillaPlus.Features.GearsetRedirect;

public unsafe class RedirectInfo : IInfoNodeData {
    public required int AlternateGearsetId { get; init; }
    public required uint TerritoryType { get; init; }

    public string GetLabel()
        => GetGearsetData().NameString;

    public string GetSubLabel()
        => $"When in {Services.DataManager.GetExcelSheet<TerritoryType>().GetRow(TerritoryType).PlaceName.Value.Name}";

    public uint? GetId()
        => (uint) AlternateGearsetId;

    public uint? GetIconId()
        => GetGearsetData().ClassJob + 62000u;

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
        => ref RaptureGearsetModule.Instance()->Entries[AlternateGearsetId];
}
