﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Chisel.Core;
using Chisel.Components;
using UnitySceneExtensions;
using UnityEditor.ShortcutManagement;

namespace Chisel.Editors
{
    public sealed class ChiselTorusGeneratorMode : IChiselToolMode
    {
        // Commented out, for the time being, because this generator has not been implemented yet
        /*
        #region Keyboard Shortcut
        const string kToolShotcutName = ChiselKeyboardDefaults.ShortCutCreateBase + ChiselTorus.kNodeTypeName;
        [Shortcut(kToolShotcutName, ChiselKeyboardDefaults.TorusBuilderModeKey, ChiselKeyboardDefaults.TorusBuilderModeModifiers, displayName = kToolShotcutName)]
        public static void Enable() { ChiselEditModeManager.EditMode = ChiselEditMode.Torus; }
        #endregion
        */

        public void OnEnable()
        {
        }

        public void OnDisable()
        {
        }

        void Reset()
        {
        }
        
        public void OnSceneGUI(SceneView sceneView, Rect dragArea)
        {
        }
    }
}
