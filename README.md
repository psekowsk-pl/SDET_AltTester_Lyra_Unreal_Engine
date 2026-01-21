# SDET_AltTester_Lyra_Unreal_Engine
This repository holds the AltTester + C# + NUnit automated tests, developed for Lyra Starter Game in Unreal Engine 5.3.2.
The tests are designed to verify core functionality via smoke tests and to demonstrate how to interact with the Unreal Engine game environment using AltTester.

## 1. Setup
Follow this instruction to properly set the Lyra and Test Automation projects.

### AltTester
a) Be sure, that you have a valid Unreal Engine license.

### Unreal Engine setup
a) Download and install [Epic Games]("https://www.epicgames.com/site/pl/home").
b) Install Unreal Engine 5.3.2 using Epic Games App.
c) Find and add [Lyra Start Project]("https://www.fab.com/listings/93faede1-4434-47c0-85f1-bf27c0820ad0") to your library, then create a new project.
d) Download and extract the plugin to LyraStartGame/Plugins.
e) Run the project and check if the AltTester is up and running. 
<img width="1668" height="504" alt="obraz" src="https://github.com/user-attachments/assets/ba2fc6ea-d0be-4b9d-a9ca-3b2de08b57e0" />

### Test Automation project setup
a) Install Visual Studio Code and the necessary plugins (NUnit, C#).
b) Copy the [HTTPS_LINK]("https://github.com/psekowsk-pl/SDET_AltTester_Lyra_Unreal_Engine.git") and pull the repository to your project folder.
c) Install AltTester Desktop: [Windows]("https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageWindows__2_2_7.zip") / [MacOS]("https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageMac__2_2_7.zip").
d) Paste your license to AltTester Desktop.

## 2. Troubleshooting
The Unreal Engine 5.3.2 and the Lyra project can have a couple of issues that you need to resolve. Here's a quick instruction how to deal with them:

### a) Lyra project can't start on AMD GPU ~ "GPU Crashed or D3D Device Removed"
This is a common issue on AMD GPU (Unreal Engine 5.2 - 5.3). To resolve this issue you need to go to your project folder, then go to Config folder and open ***DefaultEngine.ini***.

You need to change two variables:

* r.RayTracing=True -> False
* r.Lumen.HardwareRayTracing=True -> False

Here's a piece of code, that you copy and pase:
```
r.RayTracing=False
r.Lumen.HardwareRayTracing=False
```

The issue will be resolved and you will be able to open Lyra project.

## 3. How to run the tests?
* Open the Lyra Starter Game and start the game in the editor.
* Launch AltTester Desktop and be sure, that the license has been activated.
* Open Automation Tests with Visual Studio Code and run the tests.

## 4. Project architecture
```
📁 SDET_AltTester_Lyra_Unreal_Engine
│
├── 📁 Assets - Main container for all project-related resources.
├── 📁 Base - Base folder for test SetUp and TearDown.
├── 📁 Config - Configuration and environment-specific settings.
├── 📁 Driver - Driver manager.
├── 📁 Fixtures - Driver one time Setup and TearDown fixture.
├── 📁 Helpers - Helper utilities used throughout the codebase.
├── 📁 TestReports - Test reports.
├── 📁 Tests - Automated test suites.
├── 📁 Helpers - Helper utilities used throughout the codebase.
└── 📁 Utilities - Shared utility classes and tools
```

## 5. Overall Test Architecture
### a) Code architecture model
This project depends on the driver, so it can't become stale at any point. I couldn't use the POM (Page Object Model), so I've decided to use static classes, functions and variables. This decision allowed me to create seperate files with locators and methods, that I can use any time in the test.
<img width="1038" height="482" alt="obraz" src="https://github.com/user-attachments/assets/dd675789-9564-4499-8e8d-4da0ff803905" />

### b) 

## 6. Smoke tests
Smoke tests are small and quick. Their goal is to confirm that the basic functionality of the game is working as expected, before executing more complex Regression, Performance, Integration and E2E tests.

Every test file contains **TestsSetup()** function, that loads a preset scene to load. 

This project contains 3 types of Smoke tests:

### a) MainMenuSmokeTests - those tests are validating the main menu elements.

Test design:
* Load scene.
* Verify visible elements.
* Go to the next main menu page if necessary and check the visible elements there.

### b) GameplaySmokeTests - those tests are validating the core gameplay mechanics in normal gamemode.

Test design:
* Load scene.
* Verify if player has been spawned.
* Complete the test.
* Assert.

### c) PlayerSmokeTests - those tests are validating the code mechanics, available for the player.

Test design:
* Load scene.
* Verify if player has been spawned.
* Complete the test.
* Assert.
