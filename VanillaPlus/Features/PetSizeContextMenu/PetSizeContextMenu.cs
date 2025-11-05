using System.Linq;
using Dalamud.Game.Config;
using Dalamud.Game.Gui.ContextMenu;
using VanillaPlus.Classes;

namespace VanillaPlus.Features.PetSizeContextMenu;

public class PetSizeContextMenu : GameModification {
    public override ModificationInfo ModificationInfo => new() {
        DisplayName = Strings.PetSizeContextMenu,
        Description = Strings.PetSizeContextMenuDescription,
        Authors = [ "MidoriKami" ],
        Type = ModificationType.GameBehavior,
        ChangeLog = [
            new ChangeLogInfo(1, "Initial Implementation"),
        ],
    };

    private readonly UiConfigOption[] configEntries = [
        UiConfigOption.BahamutSize, UiConfigOption.PhoenixSize, UiConfigOption.GarudaSize,
        UiConfigOption.TitanSize, UiConfigOption.IfritSize, UiConfigOption.SolBahamutSize,
    ];

    public override string ImageName => "PetSizeContextMenu.png";

    public override void OnEnable()
        => Services.ContextMenu.OnMenuOpened += OnMenuOpened;

    public override void OnDisable()
        => Services.ContextMenu.OnMenuOpened -= OnMenuOpened;

    private void OnMenuOpened(IMenuOpenedArgs args) {
        if (args is not { MenuType: ContextMenuType.Default }) return;
        if (args.Target is not MenuTargetDefault targetInfo) return;
        if (!targetInfo.TargetObject.IsPetOrOwner()) return;

        var currentPetSize = GetPetSize();
        
        args.AddMenuItem(new MenuItem {
            IsSubmenu = true,
            UseDefaultPrefix = true,
            Name = Strings.PetSize,
            OnClicked = clickedArgs => {
                clickedArgs.OpenSubmenu([
                    new MenuItem {
                        IsEnabled = currentPetSize is not 0,
                        UseDefaultPrefix = true, 
                        Name = Strings.Small, 
                        OnClicked = _ => SetPetSize(0),
                    },
                    new MenuItem {
                        IsEnabled = currentPetSize is not 1,
                        UseDefaultPrefix = true, 
                        Name = Strings.Medium, 
                        OnClicked = _ => SetPetSize(1),
                    },
                    new MenuItem {
                        IsEnabled = currentPetSize is not 2,
                        UseDefaultPrefix = true, 
                        Name = Strings.Large, 
                        OnClicked = _ => SetPetSize(2),
                    },
                ]);
            },
        });
    }

    private void SetPetSize(uint size) {
        foreach(var configEntry in configEntries) {
            Services.GameConfig.Set(configEntry, size);
        }
    }

    private uint? GetPetSize()
        => configEntries
           .Select(configKey => Services.GameConfig.TryGet(configKey, out uint value) ? value : 0)
           .GroupBy(configValue => configValue)
           .MaxBy(group => group.Count())?
           .Key;
}
