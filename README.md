# UnlockTheObelisk
Simple command line tool for unlocking various things in the game Across The Obelisk.

Run at your own risk. I'm not responsible if it ruins your game data, corrupts your hard drive, destroys your marriage, or anything else. 
If it does not work, you are welcome to modify the source yourself but I do not intend to provide support for this project. It worked on my (and my friend's ) machines, and I no longer have a need for it.


Unfortunately, the game's dll's are currently required for this to work. I'm not going to distribute them obviously, so you will have to hook them up during build.
To do so, simple edit the .csproj in this repo and update the $gamePath property to point to the Managed folder in your installation. See the value that is already there
for an idea of what the path should look like. Once that's updated, just build it.

After building (you should be able to use visual studio community or rider to build, or even just run `dotnet build` in the root directory), you can run
`./atounlocker.exe help` to see usage.

BACK UP YOUR FULL FOLDER OF GAME DATA BEFORE RUNNING. It modifies your existing game data without backing anything up itself.
This data exists at `"C:\\Users\\USER_NAME\\AppData\\LocalLow\\Dreamsite Games\\AcrossTheObelisk\\STEAM_ID\\player.ato"`. Create a copy of that folder before you run this application.
Then, copy that path (the full path to the .ato file) as you will need to provide that to the tool.


run `./atounlocker.exe "PATH_TO_ATO_FILE" [args]`

The args are as follows:  
perks - max out all perk points.  
heroes - unlock all heroes.  
town - unlock all town upgrades.  


Note that you do not provide hyphens when providing arguments, because I'm a goober and set it up wrong and don't feel like fixing it. Example usages:

`./atounlocker.exe "PATH_TO_ATO_FILE" town`
- unlocks all the town upgrades.

`./atounlocker.exe "PATH_TO_ATO_FILE" town perks heroes`
- unlocks everything.
