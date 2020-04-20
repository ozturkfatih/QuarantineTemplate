using CoreFuncWizard.ItemComponents.RepositoryClassComponet;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CoreFuncWizard.Wizards
{
    public class WizardRepositoryClass : IWizard
    {
        private readonly FormRepositoryClassComponet _form = new FormRepositoryClassComponet();
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
                _form.RootDir = _currentSolutionPath;
                _form.StrFormTitle = Path.GetFileName(replacementsDictionary["$title$"]);
                _form.StrRepositoryClassName = Path.GetFileName(replacementsDictionary["$safeitemname$"]);
                _form.StrRepositoryInterfaceName =$"I{Path.GetFileName(replacementsDictionary["$safeitemname$"])}";
                _form.StrBaseRepositoryProjectName = _currentSolutionPath;
                _form.StrEntityClassProject = _currentSolutionPath;
                _form.StrDbContextProject = _currentSolutionPath;
                
                if (_form.ShowDialog() != DialogResult.OK)
                {
                    _userCancelled = true;
                    return;
                }
                replacementsDictionary["$entityname$"] = _form.StrEntityClass;
                replacementsDictionary["$entitynamespace$"] = _form.StrEntityNamespace;
                replacementsDictionary["$dbcontext$"] = _form.StrDbContextClass;
                replacementsDictionary["$dbcontextnamespace$"] = _form.StrDbContextNamespace;
                replacementsDictionary["$baserespository$"] = _form.StrBaseRepositoryClass;
                replacementsDictionary["$baserespositorynamescpace$"] = _form.StrBaseRepositoryNamespace;
            }
        }
        public void RunFinished()
        {

        }

    }
}
