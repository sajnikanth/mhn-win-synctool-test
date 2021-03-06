﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace mhn_win_synctool_test
{
    public partial class Login
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void check_existing_session()
        {
        }

        public void Mouse_Click_username_field()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OrganisePhotosSyncTool.UserLoginSettings.username_field' at 80;8.", repo.OrganisePhotosSyncTool.UserLoginSettings.username_fieldInfo);
            repo.OrganisePhotosSyncTool.UserLoginSettings.username_field.Click("80;8");
        }

        public void MergedUserCodeMethod()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OrganisePhotosSyncTool.profile_tab' at 21;11.", repo.OrganisePhotosSyncTool.profile_tabInfo);
            repo.OrganisePhotosSyncTool.profile_tab.Click("21;11");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OrganisePhotosSyncTool.UserLoginSettings.username_field' at 80;8.", repo.OrganisePhotosSyncTool.UserLoginSettings.username_fieldInfo);
            repo.OrganisePhotosSyncTool.UserLoginSettings.username_field.Click("80;8");
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Back}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}{Back}");
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$var_username'.");
            Keyboard.Press(var_username);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OrganisePhotosSyncTool.UserLoginSettings.password_field' at 70;13.", repo.OrganisePhotosSyncTool.UserLoginSettings.password_fieldInfo);
            repo.OrganisePhotosSyncTool.UserLoginSettings.password_field.Click("70;13");
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$var_password'.");
            Keyboard.Press(var_password);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OrganisePhotosSyncTool.UserLoginSettings.login_button' at 40;10.", repo.OrganisePhotosSyncTool.UserLoginSettings.login_buttonInfo);
            repo.OrganisePhotosSyncTool.UserLoginSettings.login_button.Click("40;10");
        }

    }
}