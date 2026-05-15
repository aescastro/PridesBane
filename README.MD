 # Pride's Bane

 This is a Slay the Spire 2 mod created for [Pride With Friends 2026](https://pwf.mcgee.red). It replaces `Ascender's Bane` with the `Pride` curse from Slay the Spire 1 Endless mode.

## Installation instructions

- Download the `PridesBane.zip` from the latest [Releases](https://github.com/aescastro/PridesBane/releases)
- Download the `BaseLib.x.y.z.zip` from the latest [BaseLib Releases](https://github.com/Alchyr/BaseLib-StS2/releases)
- Unzip both to reveal the folders containing the files inside
- Navigate to Slay the Spire 2 in your Steam library
- Right click it, then hover `Manage` and click `Browse local files` in the flyout menu
- In your file explorer, create a new folder named `mods`
- Copy the above folders to your Slay the Spire 2 mods directory

The full path should look similar to the following:

- Windows: `C:\Program Files (x86)\Steam\steamapps\common\SlayTheSpire2\mods`
- Linux: `/home/username/.local/share/Steam/steamapps/common/Slay the Spire 2/mods`

After launching the game, you will be asked if you want to play with mods. Confirming will close the game and change your game profile to the modded version. This will reset your progress! To unlock everything immediately, follow these instructions:

1. Open the settings file
    - Linux: `~/.local/share/SlayTheSpire2/steam/<numbers>/settings.save`
    - Windows: `C:\Users\<YOUR NAME HERE>\AppData\Roaming\SlayTheSpire2\steam\<YOUR STEAM ID>\settings.save` (note: AppData is a hidden folder, if you don't see it then just type the file path into the windows explorer menu)
2. Add `"full_console": true`, under the `fps_limit` line
3. Relaunch the game, open the console with the backtick key, and enter the command `unlock all`

You may also copy your profile data over from the same folder by putting it in the `modded` directory.

## Coming soon

- Updated card art

