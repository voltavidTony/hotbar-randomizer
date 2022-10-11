# Hotbar Randomizer

_A builder's tool_

For all the builders out there, let this program take care of the more annoying parts of building in Minecraft.

I'll be releasing a server plugin and Fabric mod version soon.

## Cookbook RNG

As the name suggests, Hotbar Randomizer switches hotbar slots randomly, but what sets it apart from all the other programs is what I have coined "Cookbook RNG". Instead of defining each slot's percentage or using a fixed 1/9th chance, you set each slot's proportion to the others, just like the ingredients in a cookbook recipe.

So for instance, if you set the slots' portions to "1 2 1 1 10 1 1 1 2", then slot 5 will be selected 50% of the time since it has 10 of the 20 total portions. Here's a visual representation of this example where you would choose one of the squares with equal chance (in this case 1/20th):

1️⃣ | 2️⃣2️⃣ | 3️⃣ | 4️⃣ | 5️⃣5️⃣5️⃣5️⃣5️⃣5️⃣5️⃣5️⃣5️⃣5️⃣ | 6️⃣ | 7️⃣ | 8️⃣ | 9️⃣9️⃣

Hotbar Randomizer lets you type any 3 digit number (i.e. up to 999). You can also disable one or more slots by setting their portions to 0.

## User Interaction

### GUI

Hotbar Randomizer's window works just like any other window. The top 32 pixels act as an invisible title bar that you can drag. The button in the top right with the red 'X' on it closes the program. The button next to it with the '?' on it opens the built-in manual (the manual closes when you click off of it).

The lever on the left controls whether Hotbar Randomizer will swap offhands. It will issue the swap offhand keypress both when you press left click to mine and when you un-press left click to finish mining. The lever on the right controls whether Hotbar Randomizer will select a new slot whenever you place a block (determined by you un-pressing right click). These two features work independently.

To edit a slot's portion, click it's slot in Hotbar Randomizer. The font will be bold to indicate you're currently editing it. You cannot edit the portions while the random slot selection is active. Editing a portion works in the following ways:

- You can type any number up to 3 digits
- Left click or Enter confirms the edit
- Right click or Escape cancels the edit
- Backspace removes the last digit
- Delete removes all digits and sets the portion to 0

### Commands

Hotbar Randomizer works by reading keyboard input. It leverages this ability to detect when you type one of these three commands in-game:

- `/hot slot` flips the lever on the right
- `/hot swap` flips the lever on the left
- `/hot quit` exits Hotbar Randomizer

Hotbar Randomizer will display what you're typing so you can make sure it picked up what you typed in-game properly (it doesn't capture your input until you hit the command key, '/' by default).

Don't worry if Minecraft gives you an error message, it will still work. Due to the nature of Hotbar Randomizer, it can't add these commands to the game (until I release the server plugin and Fabric mod versions). The only drawback is that you can't use the mouse to edit the text you're entering.

## Custom Keybinds

Hotbar Randomizer interacts with Minecraft by injecting keypresses in response to your mouse events. It uses Minecraft's default keybinds (`F` to swap offhand, `1`-`9` to select the slots, and `/` to detect when you type a command). If you changed some of the keybinds in-game, you can tell Hotbar Randomizer by renaming the executable. For instance, if you reversed the order of the hotbar slots, and swapping the offhand is done with `R`, you would rename `Hotbar Randomizer.exe` to `Hotbar Randomizer {/,9,8,7,6,5,4,3,2,1,R}.exe`. You have to specify all 11 keybinds as a comma separated list contained in curly braces at the end of the filename (but before the .exe). The keybinds must be in this order: command character, slot 1, slot 2, slot 3, slot 4, slot 5, slot 6, slot 7, slot 8, slot 9, and swap offhand character. Anything can come before the curly braces (except more curly braces), but nothing can follow them.

## Troubleshooting

Hotbar Randomizer filters the application you're currently focusing. Only windows with 'Minecraft' in the title that were started by a 'javaw.exe' process. This means that only Java Edition works, as Bedrock edition is ignored. This is done to stop Hotbar Randomizer from injecting keypresses into random applications.

If you find any bugs, please let me know!
