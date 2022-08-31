# RockPaperScissorsByThreed

[![dot net version](https://img.shields.io/badge/.NET-6.0-green)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
[![IDE](https://img.shields.io/badge/Visual%20Studio-2022-brightgreen)](https://visualstudio.microsoft.com/vs/)
[![C# version](https://img.shields.io/badge/C%23-v10.0-brightgreen)](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)

---

<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/GameIcon.png" alt="game icon" width="500" height="500">

This is a simple console game <strong>"Rock-Paper-Scissor"</strong> where you and your oponent (the computer) choose one of three options: rock, paper or scissors. You can check the game rules below.

---

# Game rules:

The rules are as follows:
- <b>Rock beats scissors</b> (the scissors will be broken by the rock)
- <b>Scissors beats paper</b> (the scissors will cut the paper)
- <b>Paper beats rock</b> (the paper will cover the rock)

## Possible game situations:

| You | Computer | Outcome |
|-----|----------|---------|
| rock | rock | Draw |
| rock | paper | You lose |
| rock | scissors | You win |
| paper | rock | You win |
| paper | paper | Draw |
| paper | scissors | You lose |
| scissors | rock | You lose |
| scissors | paper | You win |
| scissors | scissors | Draw |

# Input and Output (Examples)

<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/inputOne.png" alt="input img" width="700" height="200">
<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/inputTwo.png" alt="input img" width="700" height="200">
<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/inputThree.png" alt="input img" width="700" height="200">
<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/inputFour.png" alt="input img" width="700" height="200">

# Project structure

The game implementation contains two folders and one file for entry point. The Contracts folder contains the needed interfeces and the Models folder - classes and enumerators.

## Contracts folder

It contains two interfaces IPlayer and IPrinter. Both interfeces are created with the idea of easy-to-change game logic, if such change/modification is required.

### IPlayer interface

It has one property Move from type Movement and one method SetMovement which has the idea to set value to Move property and also to return true if everything is successful.

<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/IPlayerPic.png" alt="iplayer pickture" width="130" height="200">

### IPrinter interface

It is created to handle UI part of the project. It is generic interface and contains one property and four void methods.

<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/IPrinterPic.png" alt="input img" width="130" height="200">

##  Models folder

It contains all needed classes and one enumerator. The enumerator actually is describing the player movements. Classes present the both side of the players (computer and user) and also ConsoleOutput class which is actually a fasade class for System.Console.

<img src="https://github.com/Threed90/RockPaperScissorsByThreed/blob/main/RepoPics/ClassesPic.png" alt="class diagram" width="700" height="330">

# Demo

You can try the game directly in your Web browser here: [Click here](https://replit.com/@DimitrDimitrov1/RockPaperScissors?v=1)
