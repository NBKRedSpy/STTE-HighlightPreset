[h1]Shortest Trip To Earth - Preset Highlight[/h1]


Makes the currently loaded preset easier to see by using a more visible highlight color.
The color can be customized.  See the Configuration section below.

[b]Important[/b]: When a game is loaded, there will not be a highlighted preset as the game does not actually load a preset at that point.  Once a preset is loaded, the mod will highlight the current preset.

[h1]Steam Workshop[/h1]

For Steam Users, subscribing to this mod does not install the mod.
Follow Installation section instructions below to install.

[h1]Compatibility[/h1]
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]

[h1]Configuration[/h1]

The configuration file will be created on the first game run and can be found at [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\HighlightPreset.cfg[/i].  The changes will take effect the next time the game is run.
[table]
[tr]
[td]Name
[/td]
[td]Default
[/td]
[td]Description
[/td]
[/tr]
[tr]
[td]HighlightColor
[/td]
[td]00FF00FF (Green)
[/td]
[td]The highlight color for the current preset.  The Value is in RGBA format
[/td]
[/tr]
[/table]

[h1]Support[/h1]

If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!

[h1]Installation[/h1]

This section covers how to install the BepInEx mod loader and the mod itself.

[h2]BepInEx Setup[/h2]

If BepInEx has already been installed, skip to the Mod Install section.
[list]
[*]
Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip
[*]
Extract the contents of the BepInEx zip file into the game's directory:
[i]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/i]

[b]Important[/b]:  The .zip file [i]must[/i] be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx[/i].

A common issue is extracting the .zip with the .zip name.  Ex: [i]BepInEx_win_x64_5.4.23.1/BepInEx[/i].  If this occurs, move the [i]BepInEx[/i] sub directory to the game's root directory.
[*]
Run the game.  Once the main menu is shown, exit the game.
[*]
If the install was successful, there will now be a [i]<Game Dir>/BepInEx/plugins[/i] directory.
[/list]

[h2]Mod Install[/h2]
[list]
[*]Download the HighlightPreset.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from https://github.com/NBKRedSpy/STTE-HighlightPreset/releases/
[/list]
[*]Extract the contents of the zip file into the [i]<Game Dir>/BepInEx/plugins[/i] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]

[h1]Uninstalling[/h1]

[h2]Uninstalling This Mod Only[/h2]

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the directory [i]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\HighlightPreset[/i].

[h2]Uninstall the Mod and BepInEx[/h2]

This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.

Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]

[h1]Change Log[/h1]

[h2]1.0.0[/h2]
[list]
[*]Release
[/list]

[h1]Source Code[/h1]

Source code is available on GitHub at https://github.com/NBKRedspy/STTE-HighlightPreset
