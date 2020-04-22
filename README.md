# **Quarantine Template**
This repository contains an extensive Visual Studio project template and an item template creation example.

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
    │   ├── src
    │   │   ├── QuarantineTemplate
    │   │   │   └── QuarantineTemplatePackage.cs
    │   │   │   └── source.extension.vsixmanifest
    │   │   ├── QuarantineEntityTemplate
    │   │   │   └── Entity.cs
    │   │   │   └── EntityTemplate.ico
    │   │   │   └── EntityTemplate.vstemplate
    │   │   ├── QuarantineRepositoryTemplate
    │   │   │   └── ...
    │   │   ├── QuarantineWizard
    │   │   │   ├── ItemComponents
    │   │   │   │   ├── EntityClassComponent
    │   │   │   │   │   └── FormEntityClassComponet.cs    
    │   │   │   ├── Wizards
    │   │   │   │   └── WizardEntityClass.cs
    │   ├── files
    │   └── QuarantineTemplate.sln
    │   └── README.md
    │   └── LICENSE
    │   └── .gitignore
```

#### Creating the Visual Studio extension project
 1. Create a new VSIX project within Visual Studio (New Project / Visual C# / Extensions) (VS2019)
 2. Select VSIX Project.
 3. QuarantineTemplate is a VSIX Project.
 
#### Creating the Visual Studio item template project
 1. Create a new C# Item Template Project within Visual Studio (New Project / Visual C# / Extensions) (VS2019)
 2. Select C# Item Template.
 3. QuarantineEntityTemplate and QuarantineRepositoryTemplate are C# Item Template projects.
 
 #### How to implementation IWizard interface?

Create an Class Library and install VSSDK.TemplateWizardInterface from nuget. Add a class and this class is inherit from the IWizard interface.

```c#
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using QuarantineWizard.ItemComponents.EntityClassComponent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuarantineWizard.Wizards
{
    public class WizardEntityClass : IWizard
    {
        private readonly FormEntityClassComponet _form = new FormEntityClassComponet();
        private bool _userCancelled;
        private DTE _currnetDte;
        private static string _currentSolutionPath;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {

        }

        public void ProjectFinishedGenerating(Project project)
        {

        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {

        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return !_userCancelled;
        }


        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _currnetDte = (DTE)automationObject;
            _currentSolutionPath = replacementsDictionary["$solutiondirectory$"];

            using (_form)
            {
                _form.StrFormTitle = Path.GetFileName(replacementsDictionary["$title$"]);
                _form.StrEntityClassName = Path.GetFileName(replacementsDictionary["$safeitemrootname$"]);
                _form.StrEntitySchemaName = Path.GetFileName(replacementsDictionary["$schemaname$"]);
                _form.StrEntityIdTypeName = Path.GetFileName(replacementsDictionary["$idtype$"]);
                if (_form.ShowDialog() != DialogResult.OK)
                {
                    _userCancelled = true;
                    return;
                }

                replacementsDictionary["$schemaname$"] = _form.StrEntitySchemaName;
                replacementsDictionary["$idtype$"] = _form.StrEntityIdTypeName;
            }
        }
        public void RunFinished()
        {

        }
    }
}

```
To use this project in the item template or the project template, the key.snk file must be created.

[Read this more information](https://docs.microsoft.com/en-us/visualstudio/extensibility/how-to-use-wizards-with-project-templates?view=vs-2019#connect-the-wizard-to-the-custom-template)

![](https://raw.githubusercontent.com/ozturkfatih/QuarantineTemplate/master/files/img_key_snk.png)

How read your key.snk public token. It's easy with Visual Studio. 
Add new an external tool. Visual Studi -> Tools -> External Tools and open external tools window.

![](https://raw.githubusercontent.com/ozturkfatih/QuarantineTemplate/master/files/img_exernal.png)

Now run added external tool and get token.

![](https://raw.githubusercontent.com/ozturkfatih/QuarantineTemplate/master/files/img_output_public.png)

The token will use on project template or item template .vstemplate files.

#### EntityTemplate.vstemplate file Wizard project dll usage

![](https://raw.githubusercontent.com/ozturkfatih/QuarantineTemplate/master/files/img_template.png)

#### How debug solution.

 1. Create a new console application in a directory close to your project.
```bash
    ├── Projects
    │   ├── QuarantineTemplate
    │   ├── QuarantineTemplateDebugger
    │   │   └── QuarantineTemplateDebugger.sln
```
 2. Open QuarantineTemplate properties debug tab and configure like this.
 
 ![](https://raw.githubusercontent.com/ozturkfatih/QuarantineTemplate/master/files/img_debug.png)
 
