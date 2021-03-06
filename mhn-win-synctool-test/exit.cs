﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace mhn_win_synctool_test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The exit recording.
    /// </summary>
    [TestModule("b61ebc43-3756-4592-b873-2b9f34c82253", ModuleType.Recording, 1)]
    public partial class Exit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the mhn_win_synctool_testRepository repository.
        /// </summary>
        public static mhn_win_synctool_testRepository repo = mhn_win_synctool_testRepository.Instance;

        static Exit instance = new Exit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Exit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Exit Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'win_taskBar.win_showSystemTray_button' at 7;24.", repo.win_taskBar.win_showSystemTray_buttonInfo, new RecordItemIndex(0));
            repo.win_taskBar.win_showSystemTray_button.Click("7;24");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'win_systemTray_Icons.organise_photos_systemTray_icon' at 9;18.", repo.win_systemTray_Icons.organise_photos_systemTray_iconInfo, new RecordItemIndex(1));
            repo.win_systemTray_Icons.organise_photos_systemTray_icon.Click(System.Windows.Forms.MouseButtons.Right, "9;18");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'organise_photos_systemTray_options.organise_photos_systemTray_exit' at 8;5.", repo.organise_photos_systemTray_options.organise_photos_systemTray_exitInfo, new RecordItemIndex(2));
            repo.organise_photos_systemTray_options.organise_photos_systemTray_exit.Click("8;5");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5000ms for item 'win_taskBar.organise_photos_taskBar_icon' to not exist.", repo.win_taskBar.organise_photos_taskBar_iconInfo, new ActionTimeout(5000), new RecordItemIndex(3));
            repo.win_taskBar.organise_photos_taskBar_iconInfo.WaitForNotExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
