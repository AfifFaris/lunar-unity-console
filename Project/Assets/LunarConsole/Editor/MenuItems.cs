﻿using UnityEngine;
using UnityEditor;

namespace LunarConsoleInternal
{
    static class MenuItems
    {
        [MenuItem("Window/Lunar Mobile Console/Install...")]
        static void Install()
        {
            Installer.Install(false);
        }

        [MenuItem("Window/Lunar Mobile Console/")]
        static void Separator()
        {
        }

        [MenuItem("Window/Lunar Mobile Console/Check for updates...")]
        static void CheckForUpdates()
        {
            Updater.CheckForUpdates(false);
        }

        #if LUNAR_DEVELOPMENT
        [MenuItem("Window/Lunar Mobile Console/Reset")]
        static void Reset()
        {
            Updater.Reset();
        }
        #endif
    }
}
