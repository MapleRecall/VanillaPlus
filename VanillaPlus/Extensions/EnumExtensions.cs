using System;
using System.ComponentModel;
using Dalamud.Utility;
using VanillaPlus.Classes;

namespace VanillaPlus.Extensions;

public static class EnumExtensions {
    public static string GetDescription(this Enum enumValue) {
        // Special handling for ModificationType enum to support localization
        if (enumValue is ModificationType modificationType) {
            return modificationType switch {
                ModificationType.Debug => Strings.ModificationTypeDebug,
                ModificationType.NewWindow => Strings.ModificationTypeCustomNativeWindows,
                ModificationType.UserInterface => Strings.ModificationTypeUIModification,
                ModificationType.GameBehavior => Strings.ModificationTypeGameBehaviorModification,
                ModificationType.NewOverlay => Strings.ModificationTypeCustomNativeOverlay,
                _ => modificationType.ToString()
            };
        }
        
        // Default behavior for other enums with Description attributes
        var attribute = enumValue.GetAttribute<DescriptionAttribute>();
        return attribute == null ? enumValue.ToString() : attribute.Description;
    }
}
