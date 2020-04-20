# **Quarantine Template**
This repository contains an extensive Visual Studio project template and an element template creation example.

#### What does this repository contain and what will you see?
 1. How to create [VSIX](https://docs.microsoft.com/en-us/visualstudio/extensibility/?view=vs-2019) project?
 2. How to create an [item template](https://docs.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2019) project?
 3. How to create a [project template](https://docs.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2019) project?
 4. How to use Custom parameters in an item template or project template?
 5. How to implementation [IWizard](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.templatewizard.iwizard?view=visualstudiosdk-2017&viewFallbackFrom=visualstudiosdk-2019) interface?
 6. How to create a form and how to shown this form when create an item?
 7. How to debug VSIX project?
 
#### Quarantine Template Project Structure

| Project Name| Project Type | |
| ------------ | ------------ |------------ |
| QuarantineTemplate.sln | Blank Solution | |
| QuarantineTemplate | VSIX Project | **Startup Project** |
| QuarantineEntityTemplate |  C# Item Template Project | |
| QuarantineRepositoryTemplate |  C# Item Template Project | |
| QuarantineWizard |  Class Library (.NET Framework 4.8) |   |  |

#### Quarantine Template Directory Structure

```bash
├── QuarantineTemplate
│   ├── src
│   │   ├── QuarantineTemplate
│   │   ├── QuarantineEntityTemplate
│   │   ├── QuarantineRepositoryTemplate
│   │   ├── QuarantineWizard
├── README.md
├── LICENSE
├── QuarantineTemplate.sln
└── .gitignore
```
