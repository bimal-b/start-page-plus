﻿namespace StartPagePlus.UI.Interfaces
{
    public interface IVisualStudioService
    {
        bool ExecuteCommand(string action, string path);

        bool OpenWebPage(string url, bool internalBrowser);

        bool OpenFolder(string path = "");

        bool OpenSolution(string path = null);

        bool OpenProject(string path = "");

        void CreateNewProject();

        void CloneOrCheckoutCode();

        void RestartVisualStudio(bool confirm = true, bool elevated = false);
    }
}