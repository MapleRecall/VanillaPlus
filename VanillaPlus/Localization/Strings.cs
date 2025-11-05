using Dalamud;

namespace VanillaPlus;

public static class Strings {
    // Main Plugin
    public static string PluginTitle => Localization.Localize("PluginTitle", "Vanilla Plus Modification Browser");
    public static string OpenModificationBrowser => Localization.Localize("OpenModificationBrowser", "Open Game Modification Browser");
    public static string WindowSystemName => Localization.Localize("WindowSystemName", "VanillaPlus");
    public static string ChangelogBrowserTitle => Localization.Localize("ChangelogBrowserTitle", "Vanilla Plus Changelog Browser");
    public static string PleaseSelectOption => Localization.Localize("PleaseSelectOption", "Please select an option on the left");
    public static string Changelog => Localization.Localize("Changelog", "Changelog");
    public static string FailedToLoadDisabled => Localization.Localize("FailedToLoadDisabled", "Failed to load, this module has been disabled");
    public static string ExperimentalWarning => Localization.Localize("ExperimentalWarning", "Caution, this feature is experimental.\nMay contain bugs or crash your game.");
    public static string RetryCompatibilityCheck => Localization.Localize("RetryCompatibilityCheck", "Retry compatability check");
    public static string OpenConfigurationWindow => Localization.Localize("OpenConfigurationWindow", "Open configuration window");

    // Common UI Elements
    public static string NoOptionSelected => Localization.Localize("NoOptionSelected", "No Option Selected");
    public static string WindowNotSet => Localization.Localize("WindowNotSet", "Window not Set");
    public static string BackgroundColor => Localization.Localize("BackgroundColor", "Background Color");
    public static string Color => Localization.Localize("Color", "Color");
    public static string PaddingSize => Localization.Localize("PaddingSize", "Padding Size");
    public static string Keybind => Localization.Localize("Keybind", "Keybind");
    public static string ChangeKeybind => Localization.Localize("ChangeKeybind", "Change Keybind");
    public static string WindowSize => Localization.Localize("WindowSize", "Window Size");
    public static string Width => Localization.Localize("Width", "Width");
    public static string Height => Localization.Localize("Height", "Height");
    public static string ChangesWontTakeEffect => Localization.Localize("ChangesWontTakeEffect", "Changes won't take effect until the window is reopened");
    public static string Disable => Localization.Localize("Disable", "Disable");
    public static string Enable => Localization.Localize("Enable", "Enable");
    public static string ColorPickerWindow => Localization.Localize("ColorPickerWindow", "Color Picker Window");
    public static string ColorPicker => Localization.Localize("ColorPicker", "Color Picker");
    public static string TextColor => Localization.Localize("TextColor", "Text Color");
    public static string TextOutline => Localization.Localize("TextOutline", "Text Outline");
    public static string FontSize => Localization.Localize("FontSize", "Font Size");
    public static string Font => Localization.Localize("Font", "Font");
    public static string Alignment => Localization.Localize("Alignment", "Alignment");
    public static string SearchPlaceholder => Localization.Localize("SearchPlaceholder", "Search . . .");
    public static string SupportsRegexSearch => Localization.Localize("SupportsRegexSearch", "[VanillaPlus]: Supports Regex Search");
    public static string StartInputWithDollar => Localization.Localize("StartInputWithDollar", "Start input with '$' to search by description");
    public static string Config => Localization.Localize("Config", "Config");
    public static string Settings => Localization.Localize("Settings", "Settings");
    public static string General => Localization.Localize("General", "General");
    public static string Style => Localization.Localize("Style", "Style");
    public static string Toggles => Localization.Localize("Toggles", "Toggles");
    public static string Animations => Localization.Localize("Animations", "Animations");
    public static string Colors => Localization.Localize("Colors", "Colors");
    public static string Icon => Localization.Localize("Icon", "Icon");
    public static string Visibility => Localization.Localize("Visibility", "Visibility");
    public static string Functions => Localization.Localize("Functions", "Functions");
    public static string KeybindConfigWindow => Localization.Localize("KeybindConfigWindow", "Keybind Config Window");
    public static string ConfigurationWindow => Localization.Localize("ConfigurationWindow", "Configuration Window");
    public static string PresetConfigManager => Localization.Localize("PresetConfigManager", "Preset Config Manager");
    
    // Compatibility Messages
    public static string HaselTweaksCompatibilityError => Localization.Localize("HaselTweaksCompatibilityError", "The original version of this feature is already active in HaselTweaks Plugin.\n\nID: {0}");
    public static string SimpleTweaksCompatibilityError => Localization.Localize("SimpleTweaksCompatibilityError", "The original version of this feature is already active in Simple Tweaks Plugin.\n\nID: {0}");
    public static string PluginCompatibilityError => Localization.Localize("PluginCompatibilityError", "The original version of this feature is from a plugin that is currently active: {0}");

    // Currency Overlay
    public static string CurrencyOverlay => Localization.Localize("CurrencyOverlay", "Currency Overlay");
    public static string CurrencyOverlayDescription => Localization.Localize("CurrencyOverlayDescription",
        "Allows you to add additional currencies to your UI Overlay.\n\n" +
        "Additionally allows you to set minimum and maximum values to trigger a warning.");
    public static string CurrencyOverlayConfig => Localization.Localize("CurrencyOverlayConfig", "Currency Overlay Config");
    public static string ItemSearch => Localization.Localize("ItemSearch", "Item Search");
    public static string WarnWhenBelowLimit => Localization.Localize("WarnWhenBelowLimit", "Warn when below limit");
    public static string WarnWhenAboveLimit => Localization.Localize("WarnWhenAboveLimit", "Warn when above limit");
    public static string ReverseIconPosition => Localization.Localize("ReverseIconPosition", "Reverse icon position");
    public static string EnableMovingOverlayElement => Localization.Localize("EnableMovingOverlayElement", "Enable moving overlay element");
    public static string Scale => Localization.Localize("Scale", "Scale");

    // Window Background
    public static string WindowBackgroundColorPicker => Localization.Localize("WindowBackgroundColorPicker", "Window Background Color Picker");

    // Wondrous Tails
    public static string WondrousTailsProbabilities => Localization.Localize("WondrousTailsProbabilities", "Wondrous Tails Probabilities");
    public static string WondrousTailsProbabilitiesDescription => Localization.Localize("WondrousTailsProbabilitiesDescription",
        "Displays current line probabilities and average reroll probabilities in the Wondrous Tails Book.");
    public static string LineChances => Localization.Localize("LineChances", "Line Chances: ");
    public static string ShuffleAverage => Localization.Localize("ShuffleAverage", "Shuffle Average: ");

    // Sort Options
    public static string Alphabetical => Localization.Localize("Alphabetical", "Alphabetical");
    public static string Id => Localization.Localize("Id", "Id");

    // Window Backgrounds
    public static string WindowBackgrounds => Localization.Localize("WindowBackgrounds", "Window Backgrounds");
    public static string WindowBackgroundsDescription => Localization.Localize("WindowBackgroundsDescription",
        "Allows you to add a background to any native window.\n\n" +
        "Examples: Cast Bar, Target Health Bar, Inventory Widget, Todo List.");
    public static string WindowBackgroundsConfig => Localization.Localize("WindowBackgroundsConfig", "Window Backgrounds Config");
    public static string WindowSearch => Localization.Localize("WindowSearch", "Window Search");

    // Keybind Configuration
    public static string InputDesiredKeyCombo => Localization.Localize("InputDesiredKeyCombo", "Input Desired Key Combo");
    public static string PressAKeyCombo => Localization.Localize("PressAKeyCombo", "Press a Key Combo");
    public static string KeybindConflicts => Localization.Localize("KeybindConflicts", "Keybind Conflict(s)");
    public static string NoConflictsDetected => Localization.Localize("NoConflictsDetected", "No Conflicts Detected");
    public static string Confirm => Localization.Localize("Confirm", "Confirm");
    public static string Cancel => Localization.Localize("Cancel", "Cancel");

    // Party Finder Preset Configuration
    public static string InputNewName => Localization.Localize("InputNewName", "Input new name");
    public static string Apply => Localization.Localize("Apply", "Apply");
    public static string NoPresetsSaved => Localization.Localize("NoPresetsSaved", "No Presets Saved");
    public static string DontUsePreset => Localization.Localize("DontUsePreset", "Don't Use Preset");

    // Target Cast Bar Countdown
    public static string TargetCastBarCountdown => Localization.Localize("TargetCastBarCountdown", "Target Cast Bar Countdown");
    public static string TargetCastBarCountdownDescription => Localization.Localize("TargetCastBarCountdownDescription",
        "Adds the time remaining for your targets current cast to the cast bar.");
    public static string TargetCastBarCountdownConfig => Localization.Localize("TargetCastBarCountdownConfig", "Target Cast Bar Countdown Config");
    public static string ShowOnPrimaryTargetCastbar => Localization.Localize("ShowOnPrimaryTargetCastbar", "Show on Primary Target Castbar");
    public static string ShowOnFocusTargetCastbar => Localization.Localize("ShowOnFocusTargetCastbar", "Show on Focus Target Castbar");
    public static string ShowOnNameplateTargetCastbar => Localization.Localize("ShowOnNameplateTargetCastbar", "Show on Nameplate Target Castbar");

    // Suppress Dialogue Advance
    public static string SuppressDialogAdvance => Localization.Localize("SuppressDialogAdvance", "Suppress Dialogue Advance");
    public static string SuppressDialogAdvanceDescription => Localization.Localize("SuppressDialogAdvanceDescription",
        "Prevents advancing a cutscene dialogue, unless you click on the dialogue box itself.");
    public static string SuppressDialogAdvanceConfig => Localization.Localize("SuppressDialogAdvanceConfig", "Suppress Dialog Advance Config");
    public static string ApplyOnlyInCutscenes => Localization.Localize("ApplyOnlyInCutscenes", "Apply only in Cutscenes");

    // Sticky Shop Categories
    public static string StickyShopCategories => Localization.Localize("StickyShopCategories", "Sticky Shop Categories");
    public static string StickyShopCategoriesDescription => Localization.Localize("StickyShopCategoriesDescription",
        "Remembers the previously selected category when opening shops, retainer markets, grand company vendors, etc.");

    // Skip Teleport Confirm
    public static string SkipTeleportConfirm => Localization.Localize("SkipTeleportConfirm", "Skip Teleport Confirm");
    public static string SkipTeleportConfirmDescription => Localization.Localize("SkipTeleportConfirmDescription",
        "Skips the 'Teleport to [Location] for [amount] gil?' popup when using the map to teleport.");

    // Saddlebag Search Bar
    public static string SaddlebagSearchBar => Localization.Localize("SaddlebagSearchBar", "Saddlebag Search Bar");
    public static string SaddlebagSearchBarDescription => Localization.Localize("SaddlebagSearchBarDescription",
        "Adds a search bar to the saddlebag window.");

    // Retainer Search Bar
    public static string RetainerSearchBar => Localization.Localize("RetainerSearchBar", "Retainer Search Bar");
    public static string RetainerSearchBarDescription => Localization.Localize("RetainerSearchBarDescription",
        "Adds a search bar to the retainer window.");

    // Reset Inventory Tab
    public static string ResetInventoryTab => Localization.Localize("ResetInventoryTab", "Reset Inventory Tab");
    public static string ResetInventoryTabDescription => Localization.Localize("ResetInventoryTabDescription",
        "Automatically resets the inventory to the first tab when opened.");

    // Mini Cactpot Helper
    public static string MiniCactpotHelper => Localization.Localize("MiniCactpotHelper", "Mini Cactpot Helper");
    public static string MiniCactpotHelperDescription => Localization.Localize("MiniCactpotHelperDescription",
        "Indicates which Mini Cactpot spots you should reveal next.");
    public static string MiniCactpotHelperConfig => Localization.Localize("MiniCactpotHelperConfig", "Mini Cactpot Helper Config");
    public static string EnableAnimations => Localization.Localize("EnableAnimations", "Enable Animations");

    // Macro Tooltips
    public static string MacroTooltips => Localization.Localize("MacroTooltips", "Macro Tooltips");
    public static string MacroTooltipsDescription => Localization.Localize("MacroTooltipsDescription",
        "Displays action tooltips when hovering over a macro with '/macroicon' set with an 'action'");

    // Macro Line Numbers
    public static string MacroLineNumbers => Localization.Localize("MacroLineNumbers", "Macro Line Numbers");
    public static string MacroLineNumbersDescription => Localization.Localize("MacroLineNumbersDescription",
        "Adds line numbers to the User Macros window.");

    // Inventory Search Bar
    public static string InventorySearchBar => Localization.Localize("InventorySearchBar", "Inventory Search Bar");
    public static string InventorySearchBarDescription => Localization.Localize("InventorySearchBarDescription",
        "Adds a search bar to the inventory window.");

    // Armoury Search Bar
    public static string ArmourySearchBar => Localization.Localize("ArmourySearchBar", "Armoury Search Bar");
    public static string ArmourySearchBarDescription => Localization.Localize("ArmourySearchBarDescription",
        "Adds a search bar to the armoury window.");

    // Location Display
    public static string LocationDisplay => Localization.Localize("LocationDisplay", "Location Display");
    public static string LocationDisplayDescription => Localization.Localize("LocationDisplayDescription",
        "Displays your current location in the server information bar.");
    public static string LocationDisplayConfig => Localization.Localize("LocationDisplayConfig", "Location Display Config");
    public static string Ward => Localization.Localize("Ward", "Ward {0}");
    public static string Subdivision => Localization.Localize("Subdivision", "Subdivision");
    public static string Apartment => Localization.Localize("Apartment", "Apartment");
    public static string Lobby => Localization.Localize("Lobby", "Lobby");
    public static string Plot => Localization.Localize("Plot", "Plot {0}");
    public static string Room => Localization.Localize("Room", "Room {0}");
    public static string LocationFormatInstruction => Localization.Localize("LocationFormatInstruction", 
        "Use the text box below to define how you want the text to be formatted.\n" +
        "Use symbols {0} {1} {2} {3} {4} where you want the following values to be in the string\n\n" +
        "{0} - Region (Ex. The Northern Empty)\n" +
        "{1} - Territory (Ex. Old Sharlayan)\n" +
        "{2} - Area (Ex. Archons Design)\n" +
        "{3} - Sub-Area (Ex. Old Sharlayan Aetheryte Plaza)\n" +
        "{4} - Housing Ward (Ex. Ward 14)");
    public static string InfoBarEntry => Localization.Localize("InfoBarEntry", "Info Bar Entry");
    public static string InfoBarTooltip => Localization.Localize("InfoBarTooltip", "Info Bar Tooltip");
    public static string ResetToDefault => Localization.Localize("ResetToDefault", "Reset to Default");
    public static string ShowInstanceNumber => Localization.Localize("ShowInstanceNumber", "Show Instance Number");
    public static string ShowPreciseHousingLocation => Localization.Localize("ShowPreciseHousingLocation", "Show Precise Housing Location");

    // HUD Coordinates
    public static string HUDCoordinates => Localization.Localize("HUDCoordinates", "HUD Coordinates");
    public static string HUDCoordinatesDescription => Localization.Localize("HUDCoordinatesDescription",
        "Display coordinate positions in HUD Layout nodes, allows you get get things exactly right.\n\n" +
        "Displays coordinates of the center of HUD elements.");

    // Fate List Window
    public static string FateListWindow => Localization.Localize("FateListWindow", "Fate List Window");
    public static string FateListWindowDescription => Localization.Localize("FateListWindowDescription",
        "Displays a list of all fates that are currently active in the current zone");
    public static string FateList => Localization.Localize("FateList", "Fate List");
    public static string UnknownLevel => Localization.Localize("UnknownLevel", "Lv. ???");

    // Duty Timer
    public static string DutyTimer => Localization.Localize("DutyTimer", "Duty Timer");
    public static string DutyTimerDescription => Localization.Localize("DutyTimerDescription",
        "When completing a duty, prints the time the duty took to chat.");
    public static string DutyCompletedIn => Localization.Localize("DutyCompletedIn", "Duty completed in");

    // List Inventory
    public static string ListInventory => Localization.Localize("ListInventory", "Inventory List Window");
    public static string ListInventoryDescription => Localization.Localize("ListInventoryDescription",
        "Adds a window that displays your inventory as a list, with toggleable filters.");
    public static string InventoryList => Localization.Localize("InventoryList", "Inventory List");

    // Gearset Redirect
    public static string GearsetRedirect => Localization.Localize("GearsetRedirect", "Gearset Redirect");
    public static string GearsetRedirectDescription => Localization.Localize("GearsetRedirectDescription",
        "When equipping gearsets, set alternative sets to load depending on what zone you are in.");
    public static string GearsetRedirectConfig => Localization.Localize("GearsetRedirectConfig", "Gearset Redirect Config");

    // Clear Flag
    public static string ClearFlag => Localization.Localize("ClearFlag", "Clear Flag");
    public static string ClearFlagDescription => Localization.Localize("ClearFlagDescription",
        "Allows you to right click the minimap to clear the currently set flag marker.");

    // Faster Scroll
    public static string FasterScroll => Localization.Localize("FasterScroll", "Faster Scrollbars");
    public static string FasterScrollDescription => Localization.Localize("FasterScrollDescription",
        "Increases the speed of all scrollbars.");
    public static string FasterScrollConfig => Localization.Localize("FasterScrollConfig", "Faster Scrollbars Config");

    // Resource Bar Percentages
    public static string ResourceBarPercentages => Localization.Localize("ResourceBarPercentages", "Show Resource Bars as Percentages");
    public static string ResourceBarPercentagesDescription => Localization.Localize("ResourceBarPercentagesDescription",
        "Displays HP, MP, GP and CP bars as percentages instead of raw values.");
    public static string ResourceBarPercentagesConfig => Localization.Localize("ResourceBarPercentagesConfig", "Resource Bar Percentages Config");

    // Fade Loot Button
    public static string FadeLootButton => Localization.Localize("FadeLootButton", "Fade Loot Button");
    public static string FadeLootButtonDescription => Localization.Localize("FadeLootButtonDescription",
        "Fades the Loot button if you've already rolled on everything available.");
    public static string FadeLootButtonConfig => Localization.Localize("FadeLootButtonConfig", "Fade Loot Button Config");

    // Fade Unavailable Actions
    public static string FadeUnavailableActions => Localization.Localize("FadeUnavailableActions", "Fade Unavailable Actions");
    public static string FadeUnavailableActionsDescription => Localization.Localize("FadeUnavailableActionsDescription",
        "Fades hotbar slots when the action is not able to be cast due to missing resources, out of range, or just on cooldown.\n\n" +
        "Additionally fades actions that are not available because you are sync'd down.");
    public static string FadeUnavailableActionsConfig => Localization.Localize("FadeUnavailableActionsConfig", "Fade Unavailable Actions Config");
    public static string FadePercentage => Localization.Localize("FadePercentage", "Fade Percentage");
    public static string ReddenPercentage => Localization.Localize("ReddenPercentage", "Redden Percentage");
    public static string ApplyTransparencyToFrame => Localization.Localize("ApplyTransparencyToFrame", "Apply Transparency to Frame");
    public static string ApplyOnlyToSyncedActions => Localization.Localize("ApplyOnlyToSyncedActions", "Apply Only to Sync'd Actions");
    public static string ReddenSkillsOutOfRange => Localization.Localize("ReddenSkillsOutOfRange", "Redden Skills out of Range");

    // Better Cursor
    public static string BetterCursor => Localization.Localize("BetterCursor", "Better Cursor");
    public static string BetterCursorDescription => Localization.Localize("BetterCursorDescription",
        "Draws a ring around the cursor to make it easier to see");
    public static string BetterCursorConfig => Localization.Localize("BetterCursorConfig", "Better Cursor Config");
    public static string EnableAnimation => Localization.Localize("EnableAnimation", "Enable Animation");
    public static string HideOnLeftHoldOrRightHold => Localization.Localize("HideOnLeftHoldOrRightHold", "Hide on Left-Hold or Right-Hold");
    public static string OnlyShowInCombat => Localization.Localize("OnlyShowInCombat", "Only show in Combat");
    public static string OnlyShowInDuties => Localization.Localize("OnlyShowInDuties", "Only Show in Duties");

    // Fast Mouse Click
    public static string FastMouseClick => Localization.Localize("FastMouseClick", "Fast Mouse Click");
    public static string FastMouseClickDescription => Localization.Localize("FastMouseClickDescription",
        "The game does not fire UI events for single mouse clicks whenever a double click is detected.\n\n" +
        "This game modification fixes it by always triggering the normal mouse click in addition to the double click.");

    // Select Next Loot Item
    public static string SelectNextLootItem => Localization.Localize("SelectNextLootItem", "Automatically Select Next Loot Item");
    public static string SelectNextLootItemDescription => Localization.Localize("SelectNextLootItemDescription",
        "Automatically advance to the next loot item after clicking Need, Greed, or Pass.\n\n" +
        "Note: this modification does not automatically roll on loot.");

    // Clear Text Inputs
    public static string ClearTextInputs => Localization.Localize("ClearTextInputs", "Clear Text Inputs");
    public static string ClearTextInputsDescription => Localization.Localize("ClearTextInputsDescription",
        "Allows you to clear the text in a text input, by right clicking the text input.");

    // Clear Selected Duties
    public static string ClearSelectedDuties => Localization.Localize("ClearSelectedDuties", "Clear Selected Duties");
    public static string ClearSelectedDutiesDescription => Localization.Localize("ClearSelectedDutiesDescription",
        "When opening the Duty Finder, deselects any selected duties.");
    public static string ClearSelectedDutiesConfig => Localization.Localize("ClearSelectedDutiesConfig", "Clear Selected Duties Config");
    public static string DisableWhenUnrestricted => Localization.Localize("DisableWhenUnrestricted", "Disable when Unrestricted");

    // HUD Presets
    public static string HUDPresets => Localization.Localize("HUDPresets", "HUD Presets");
    public static string HUDPresetsDescription => Localization.Localize("HUDPresetsDescription",
        "Provides preset HUD layouts that can be quickly applied.");
    public static string HUDPresetName => Localization.Localize("HUDPresetName", "HUD Preset Name");
    public static string VanillaPlusHUDPresets => Localization.Localize("VanillaPlusHUDPresets", "[VanillaPlus] HUD Presets");
    public static string SelectHUDLayoutPreset => Localization.Localize("SelectHUDLayoutPreset", "Select a HUD Layout Preset");
    public static string Load => Localization.Localize("Load", "Load");
    public static string LoadSelectedPreset => Localization.Localize("LoadSelectedPreset", "Load selected preset");
    public static string Overwrite => Localization.Localize("Overwrite", "Overwrite");
    public static string OverwriteSelectedPreset => Localization.Localize("OverwriteSelectedPreset", "Overwrite selected preset");
    public static string Delete => Localization.Localize("Delete", "Delete");
    public static string WorkInProgressDeletePreset => Localization.Localize("WorkInProgressDeletePreset", "Work in Progress\nManually delete preset files for now");
    public static string Save => Localization.Localize("Save", "Save");
    public static string ClickSaveAboveFirst => Localization.Localize("ClickSaveAboveFirst", "Click save above before saving a new preset");
    public static string SaveCurrentUIAsNewPreset => Localization.Localize("SaveCurrentUIAsNewPreset", "Save Current UI as a new preset");
    public static string NewPresetName => Localization.Localize("NewPresetName", "New Preset Name");

    // Hide Unwanted Banners
    public static string HideUnwantedBanners => Localization.Localize("HideUnwantedBanners", "Hide Unwanted Banners");
    public static string HideUnwantedBannersDescription => Localization.Localize("HideUnwantedBannersDescription",
        "Prevents large text banners from appearing and playing their sound effect.");
    public static string HideUnwantedBannersConfig => Localization.Localize("HideUnwantedBannersConfig", "Hide Unwanted Banners Config");

    // Hide Guildhest Objective Popup
    public static string HideGuildhestObjectivePopup => Localization.Localize("HideGuildhestObjectivePopup", "Hide Guildhest Objective Popup");
    public static string HideGuildhestObjectivePopupDescription => Localization.Localize("HideGuildhestObjectivePopupDescription",
        "When starting a guildhest this modification will prevent the popup window that contains the instructions on how to do the Guildhest.\n\n" +
        "You will still receive the chat message with the guildhest explanation.");

    // Better Quest Map Link
    public static string BetterQuestMapLink => Localization.Localize("BetterQuestMapLink", "Better Quest Map Link");
    public static string BetterQuestMapLinkDescription => Localization.Localize("BetterQuestMapLinkDescription",
        "When clicking on quest links, open the actual map the quest is for instead of the generic world map.");

    // Enhanced Loot Window
    public static string EnhancedLootWindow => Localization.Localize("EnhancedLootWindow", "Enhanced Loot Window");
    public static string EnhancedLootWindowDescription => Localization.Localize("EnhancedLootWindowDescription",
        "Adds indicators to loot window items to indicate if you have unlocked that item before, or if the item is obtainable.");
    public static string EnhancedLootWindowConfig => Localization.Localize("EnhancedLootWindowConfig", "Enhanced Loot Window Config");
    public static string MarkUnobtainableItems => Localization.Localize("MarkUnobtainableItems", "Mark Unobtainable Items");
    public static string MarkAlreadyUnlockedItems => Localization.Localize("MarkAlreadyUnlockedItems", "Mark Already Unlocked Items");

    // Missing Job Stone Lockout
    public static string MissingJobStoneLockout => Localization.Localize("MissingJobStoneLockout", "Missing Job Stone Lockout");
    public static string MissingJobStoneLockoutDescription => Localization.Localize("MissingJobStoneLockoutDescription",
        "Prevents queuing for a duty while you are missing a jobstone.");
    public static string MissingJobStone => Localization.Localize("MissingJobStone", "Missing Job Stone");
    public static string ClickToDisableLock => Localization.Localize("ClickToDisableLock", "Click to disable lock");
    public static string ClicksRemaining => Localization.Localize("ClicksRemaining", "clicks remaining");

    // Open Glamour Dresser to Current Job
    public static string OpenGlamourDresserToCurrentJob => Localization.Localize("OpenGlamourDresserToCurrentJob", "Open Glamour Dresser to Current Job");
    public static string OpenGlamourDresserToCurrentJobDescription => Localization.Localize("OpenGlamourDresserToCurrentJobDescription",
        "When opening the glamour dresser, the tab for your current job will be automatically selected.");

    // Party Finder Presets
    public static string PartyFinderPresets => Localization.Localize("PartyFinderPresets", "Party Finder Presets");
    public static string PartyFinderPresetsDescription => Localization.Localize("PartyFinderPresetsDescription",
        "Allows you to save an use presets for the Party Finder Recruitment window");
    public static string PartyFinderPreset => Localization.Localize("PartyFinderPreset", "Party Finder Preset");
    public static string SavePreset => Localization.Localize("SavePreset", "Save Preset");
    public static string SaveCurrentSettingsToPreset => Localization.Localize("SaveCurrentSettingsToPreset", "[VanillaPlus]: Save current settings to a preset");
    public static string SelectPreset => Localization.Localize("SelectPreset", "[VanillaPlus]: Select a preset");

    // Pet Size Context Menu
    public static string PetSizeContextMenu => Localization.Localize("PetSizeContextMenu", "Pet Size Context Menu");
    public static string PetSizeContextMenuDescription => Localization.Localize("PetSizeContextMenuDescription",
        "When right clicking on a pet, or a player with a pet, show a context menu entry for changing the pet size");
    public static string PetSize => Localization.Localize("PetSize", "Pet Size");
    public static string Small => Localization.Localize("Small", "Small");
    public static string Medium => Localization.Localize("Medium", "Medium");
    public static string Large => Localization.Localize("Large", "Large");

    // Quest List Window
    public static string QuestListWindow => Localization.Localize("QuestListWindow", "Quest List Window");
    public static string QuestListWindowDescription => Localization.Localize("QuestListWindowDescription",
        "Displays a list of all available quests for the currently occupied zone.");
    public static string QuestList => Localization.Localize("QuestList", "Quest List");

    // Recently Looted Items Window
    public static string RecentlyLootedWindow => Localization.Localize("RecentlyLootedWindow", "Recently Looted Window");
    public static string RecentlyLootedWindowDescription => Localization.Localize("RecentlyLootedWindowDescription",
        "Adds a window that shows a scrollable list of all items that you have looted this session.\n\n" +
        "Filters exist to help you distinguish between what types of items you are after.");
    public static string RecentlyLootedItems => Localization.Localize("RecentlyLootedItems", "Recently Looted Items");

    // Instanced Waymarks
    public static string InstancedWaymarks => Localization.Localize("InstancedWaymarks", "Instanced Waymarks");
    public static string InstancedWaymarksDescription => Localization.Localize("InstancedWaymarksDescription",
        "Enables the use of all saved Waymark Slots per duty, instead of sharing them across all duties, with the option to name each slot.");

    // Hide MP Bars
    public static string HideMpBars => Localization.Localize("HideMpBars", "Hide MP Bars");
    public static string HideMpBarsDescription => Localization.Localize("HideMpBarsDescription",
        "Hides MP Bars in party list for jobs that don't use MP.");

    // Forced Cutscene Sounds
    public static string ForcedCutsceneSounds => Localization.Localize("ForcedCutsceneSounds", "Forced Cutscene Sounds");
    public static string ForcedCutsceneSoundsDescription => Localization.Localize("ForcedCutsceneSoundsDescription",
        "Automatically unmutes selected sound channels in cutscenes.");
    public static string ForcedCutsceneSoundsConfig => Localization.Localize("ForcedCutsceneSoundsConfig", "Forced Cutscene Sounds Config");
    public static string RestoreMuteStateAfterCutscene => Localization.Localize("RestoreMuteStateAfterCutscene", "Restore Mute State After Cutscene");
    public static string UnmuteMasterVolume => Localization.Localize("UnmuteMasterVolume", "Unmute Master Volume");
    public static string UnmuteBGM => Localization.Localize("UnmuteBGM", "Unmute BGM");
    public static string UnmuteSoundEffects => Localization.Localize("UnmuteSoundEffects", "Unmute Sound Effects");
    public static string UnmuteVoice => Localization.Localize("UnmuteVoice", "Unmute Voice");
    public static string UnmuteAmbientSounds => Localization.Localize("UnmuteAmbientSounds", "Unmute Ambient Sounds");
    public static string UnmuteSystemSounds => Localization.Localize("UnmuteSystemSounds", "Unmute System Sounds");
    public static string UnmutePerformance => Localization.Localize("UnmutePerformance", "Unmute Performance");
    public static string DisableInMSQRoulette => Localization.Localize("DisableInMSQRoulette", "Disable in MSQ Roulette");

    // Focus Target Lock
    public static string FocusTargetLock => Localization.Localize("FocusTargetLock", "Focus Target Lock");
    public static string FocusTargetLockDescription => Localization.Localize("FocusTargetLockDescription",
        "When a duty recommences, restores your previous focus target.");

    // Draggable Window Dead Space
    public static string DraggableWindowDeadSpace => Localization.Localize("DraggableWindowDeadSpace", "Draggable Window Dead Space");
    public static string DraggableWindowDeadSpaceDescription => Localization.Localize("DraggableWindowDeadSpaceDescription",
        "Allows clicking and dragging on window dead space to move the window.");

    // Cast Bar Aetheryte Names
    public static string CastBarAetheryteNames => Localization.Localize("CastBarAetheryteNames", "Cast Bar Aetheryte Names");
    public static string CastBarAetheryteNamesDescription => Localization.Localize("CastBarAetheryteNamesDescription",
        "Replaces the name of the action 'Teleport' with the Aetheryte name of your destination.");

    // Better Interruptable Cast Bars
    public static string BetterInterruptableCastBars => Localization.Localize("BetterInterruptableCastBars", "Better Interruptable Castbars");
    public static string BetterInterruptableCastBarsDescription => Localization.Localize("BetterInterruptableCastBarsDescription",
        "Makes enemy interruptable castbars much more noticeable.\n\nAdditionally skills that can interrupt the cast are indicated on your hotbar.");
    // Config Categories
    public static string PartyList => Localization.Localize("PartyList", "Party List");
    public static string ParameterWidget => Localization.Localize("ParameterWidget", "Parameter Widget");
    public static string Extra => Localization.Localize("Extra", "Extra");
    public static string PercentageSign => Localization.Localize("PercentageSign", "Percentage Sign");
    public static string PercentageFormat => Localization.Localize("PercentageFormat", "Percentage Format");
    public static string StyleSettings => Localization.Localize("StyleSettings", "Style Settings");
    
    // Resource Bar Percentages Config Labels
    public static string ShowOnPartyList => Localization.Localize("ShowOnPartyList", "Show on Party List");
    public static string ApplyToPlayer => Localization.Localize("ApplyToPlayer", "Apply to Player");
    public static string ApplyToPartyMembers => Localization.Localize("ApplyToPartyMembers", "Apply to Party Members");
    public static string ChangeHP => Localization.Localize("ChangeHP", "Change HP");
    public static string ChangeMP => Localization.Localize("ChangeMP", "Change MP");
    public static string ChangeGP => Localization.Localize("ChangeGP", "Change GP");
    public static string ChangeCP => Localization.Localize("ChangeCP", "Change CP");
    public static string ShowOnParameterWidget => Localization.Localize("ShowOnParameterWidget", "Show on Parameter Widget");
    public static string DeadOrAliveMode => Localization.Localize("DeadOrAliveMode", "Dead or Alive Mode");
    public static string ShowPercentageSign => Localization.Localize("ShowPercentageSign", "Show Percentage Sign %");
    public static string DecimalPlaces => Localization.Localize("DecimalPlaces", "Decimal Places");
    public static string ShowDecimalsOnlyBelow100 => Localization.Localize("ShowDecimalsOnlyBelow100", "Show Decimals Only While Below 100%");
    public static string Alive => Localization.Localize("Alive", "Alive");
    public static string Dead => Localization.Localize("Dead", "Dead");
    public static string FeatureToggles => Localization.Localize("FeatureToggles", "Feature Toggles");
    public static string IconSelection => Localization.Localize("IconSelection", "Icon Selection");
    public static string TargetCastBarStyleCombined => Localization.Localize("TargetCastBarStyleCombined", "Target Castbar Style (Combined)");
    public static string TargetCastBarStyleSeparate => Localization.Localize("TargetCastBarStyleSeparate", "Target Castbar Style (Separate)");
    public static string FocusTargetCastBarStyle => Localization.Localize("FocusTargetCastBarStyle", "Focus Target Castbar Style");
    public static string NameplateCastBarStyle => Localization.Localize("NameplateCastBarStyle", "Nameplate Castbar Style");
    public static string Special => Localization.Localize("Special", "Special");

    // Control Labels
    public static string SpeedMultiplier => Localization.Localize("SpeedMultiplier", "Speed Multiplier");

    // Search Windows
    public static string ZoneSearch => Localization.Localize("ZoneSearch", "Zone Search");
    public static string GearsetSearch => Localization.Localize("GearsetSearch", "Gearset Search");

    // Node Configuration
    public static string Position => Localization.Localize("Position", "Position");

    // Additional Window Titles
    public static string AddNewGearsetRedirection => Localization.Localize("AddNewGearsetRedirection", "Add New Gearset Redirection");

    // Gearset Redirect
    public static string Gearset => Localization.Localize("Gearset", "Gearset");
    public static string SelectGearset => Localization.Localize("SelectGearset", "Select Gearset");
    public static string Zone => Localization.Localize("Zone", "Zone");
    public static string SelectZone => Localization.Localize("SelectZone", "Select Zone");
    public static string NothingSelected => Localization.Localize("NothingSelected", "Nothing Selected");
    
    // Modification Types
    public static string ModificationTypeDebug => Localization.Localize("ModificationTypeDebug", "Debug");
    public static string ModificationTypeCustomNativeWindows => Localization.Localize("ModificationTypeCustomNativeWindows", "Custom Native Windows");
    public static string ModificationTypeUIModification => Localization.Localize("ModificationTypeUIModification", "UI Modification");
    public static string ModificationTypeGameBehaviorModification => Localization.Localize("ModificationTypeGameBehaviorModification", "Game Behavior Modification");
    public static string ModificationTypeCustomNativeOverlay => Localization.Localize("ModificationTypeCustomNativeOverlay", "Custom Native Overlay");
}
