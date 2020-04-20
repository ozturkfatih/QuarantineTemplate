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
