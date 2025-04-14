Skip to content
Navigation Menu
anton-bot
Full-Emoji-List

Code
Issues
1
Pull requests
1
Actions
Projects
Security
Insights
Full-Emoji-List
/README.md
Go to file
t
anton-bot
anton-bot
Update README.md
968450c
 · 
9 years ago
24 lines (15 loc) · 921 Bytes

Preview

Code

Blame
# Emoji.cs: Full Emoji List for C#/.NET
Full Emoji list presented as a C# class that can be used directly in your .NET projects.

## What is Emoji.cs

This file is a full list of emojis represented as C# constants and can be added to your projects to include emojis into your strings, for example in messages that you send to users. 

## Example use of Emoji.cs

    using J3QQ4;
    
    //if you want to avoid the Emoji prefix and don't mind polluting your namespace
    //using static J3QQ4.Emoji; 
    
    ...
    string replyMessage = "Thanks for shopping with us! " + Emoji.Blush;
    string replyMessage2 = "We hope to see you again in our store" + Emoji.Kissing_Heart;
    ...
    
## Usage and questions

MIT licensed; use for any purpose. For questions or comments please open an issue in this repository. Glad if that file helps!

Help is welcome to update the file with any new emojis that will be released.
Full-Emoji-List/README.md at master · anton-bot/Full-Emoji-List