# Welcome to the repository for my App Launcher for Microsoft Office 2010!

## Note that for now I am only getting up-to-speed with GitHub hosting for my applications and will fix bugs and add new features as soon as I get settled in. It may be a while before there is documentation complete on here.

I am not associated with Microsoft in any way, shape, or form. I just thought this application (my App Launcher for Office) would be useful to people. I have checked online for application launchers for Office to see if anyone else had already made one but I didn't find any except for a general-purpose launcher which looked kinda slow to use. Don't get me wrong, it looks nice, it's just not something I would use.

If you want general information about this project, be sure to check the wiki on the right-hand side. It's the button that looks like an open book. Otherwise, keep reading.

--

# How to get Up and Running with the Files in this Repo



- First, clone the repository by running:    <code>git clone https://github.com/DrewNaylor/MSOfficeAppLauncherNext32.git</code> and remember where the files are saved.
- Next, open Visual Studio 2010.
- When Visual Studio 2010 launches and is ready for input, click <code>File>New Project...</code>.
- In the left sidebar, navigate to <code>Other Project Types\Visual Studio Solutions</code> and click on <code>Blank Solution</code>. 
- Name your solution something in the <code>Name:</code> field, browse for the directory if necessary, and click the <code>OK</code> button.
- After the Solution file is created, click the <code>Save All</code> to save your project.
- Click <code>File>Add>Existing Project...</code> and navigate to where you cloned the repo earlier. Dig all the way down to ~~Bedrock~~ <code>MSOfficeAppLauncherNext32\MSOfficeAppLauncher</code> and open the file called "<code>MSOfficeAppLauncher32.vbproj</code>." 
- If all goes well, the project should appear in the Visual Studio <code>Solution Explorer</code>.


## Why do I need to create a new Solution file? Why can't I just use the original file?

That's a great question. ~~I don't know why.~~ It's because the original Solution file is looking for a file called "<code>MSOfficeAppLauncher.vbproj</code>." You're probably thinking to yourself, "Isn't that the name of the file that I told Visual Studio to open?" You would be correct, except that there's no "32" at the end of the file it's looking for. That's because I develop both the 32-bit and the 64-bit versions in paralell. Because of that, I had to rename the name of the project file itself by right-clicking the name of the project (not the Solution file!) in the Solution Explorer and hitting "Rename." You can also just single-click on the name of the project and rename it that way. Also the 64-bit version is based on the 32-bit version.
