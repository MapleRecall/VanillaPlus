using Dalamud.Game.Addon.Lifecycle;
using Dalamud.Game.Addon.Lifecycle.AddonArgTypes;
using FFXIVClientStructs.FFXIV.Component.GUI;
using Lumina.Excel.Sheets;
using VanillaPlus.Classes;

namespace VanillaPlus.Features.HideGuildhestObjectivePopup;

public class HideGuildhestObjectivePopup : GameModification {
    public override ModificationInfo ModificationInfo => new() {
        DisplayName = Strings.HideGuildhestObjectivePopup,
        Description = Strings.HideGuildhestObjectivePopupDescription,
        Authors = ["MidoriKami"],
        Type = ModificationType.GameBehavior,
        ChangeLog = [
            new ChangeLogInfo(1, "Initial Implementation"),
        ],
        CompatibilityModule = new SimpleTweaksCompatibilityModule("UiAdjustments@HideGuildhestObjectivePopup"),
    };

    public override string ImageName => "HideGuildhestObjective.png";

    public override void OnEnable()
        => Services.AddonLifecycle.RegisterListener(AddonEvent.PreSetup, "JournalAccept", OnJournalAcceptOpen);

    public override void OnDisable()
        => Services.AddonLifecycle.UnregisterListener(OnJournalAcceptOpen);

    private unsafe void OnJournalAcceptOpen(AddonEvent type, AddonArgs args) {
        if (Services.DataManager.GetExcelSheet<TerritoryType>().GetRow(Services.ClientState.TerritoryType) is not { TerritoryIntendedUse.RowId: 3 }) return;

        args.GetAddon<AtkUnitBase>()->Hide(false, false, 1);
    }
}
