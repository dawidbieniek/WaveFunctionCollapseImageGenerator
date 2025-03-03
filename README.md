<div align="center">
  <h3 align="center">Wave Function Collapse Image Generator</h3>
  <p align="center">
    A WinForms application that procedurally creates unique images using the Wave Function Collapse algorithm
  </p>
</div>

<!-- ABOUT -->
## About
![Screenshot of Application][app-screenshot]

This repository contains a lightweight WinForms app that leverages the Wave Function Collapse algorithm to generate images from build-in tilesets. The app simulates the "collapse" of each cell into one of several available states, resulting creation of different patterns.

### Built With
[![.NET][dotnet-badge]][dotnet-url]

[![WinForms][winforms-badge]][winforms-url]

### Features
- **Procedural Image Generation:** Utilizes the Wave Function Collapse algorithm to produce unique images.
- **Automatic Backtracking:** Recovers from dead-ends by reverting to previous valid states.
- **Multiple Tilesets:** Choose from several built-in tilesets to vary the output.
- **Generation Modes:** Watch the image form in real time or step through each step manually.
- **Saving Images:** Save generated images as PNG, BMP or JPG

<!-- GETTING STARTED -->
## Getting Started

The application is designed to run on Windows systems.

### Prerequisites
- **.NET 9.0 Desktop Runtime:** Ensure the runtime is installed. The app will prompt you to download it if not found.

**.NET SDK:** Usually includes the runtime. If you can build the app, you should be able to run it as well.

### Installation
1. **Clone the Repository**
   ```sh
   git clone https://github.com/dawidbieniek/WaveFunctionCollapseImageGenerator.git
   ```
3. **Build the Project**
   Navigate to the src/ directory and build the project:
   ``` sh
   dotnet build -c Release
   ```
5. **Run the Application**
  Find the generated executable in the **bin/Release/net9.0-windows/** folder and launch it.

## Screenshots
### Different pattern each time
![Patterns][ss-patterns]

### Several build-in tilesets
![Tilesets][ss-tilesets]

### Backtracking allows fixing invalid cell states
![Backtracking][ss-backtracking]

<!-- MARKDOWN LINKS & IMAGES -->
[app-screenshot]: img/app-screenshot.png
[ss-patterns]: img/patterns.png
[ss-tilesets]: img/tilesets.png
[ss-backtracking]: img/backtracking.png
[dotnet-badge]: https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
[dotnet-url]: https://dotnet.microsoft.com/en-us/
[winforms-badge]: https://img.shields.io/badge/WinForms-512BD4?style=for-the-badge
[winforms-url]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
