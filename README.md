# SDET_AltTester_Lyra_Unreal_Engine
Automation tests with AltTester for Lyra project in Unreal Engine 5.3.2

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
