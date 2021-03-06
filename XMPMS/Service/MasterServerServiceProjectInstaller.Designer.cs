﻿// ======================================================================
//  Unreal2 XMP Master Server
//  Copyright (C) 2010-2011  Adam Mummery-Smith
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.

//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.

//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

//  Copyright Notice:
//  Unreal and the Unreal logo are registered trademarks of Epic
//  Games, Inc. ALL RIGHTS RESERVED.
// ======================================================================

namespace XMPMS.Service
{
    partial class MasterServerServiceProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MasterServerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MasterServerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MasterServerServiceProcessInstaller
            // 
            this.MasterServerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.MasterServerServiceProcessInstaller.Password = null;
            this.MasterServerServiceProcessInstaller.Username = null;
            // 
            // MasterServerServiceInstaller
            // 
            this.MasterServerServiceInstaller.Description = "Unreal Engine 2.0 compatible Master Server process";
            this.MasterServerServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // MasterServerServiceProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MasterServerServiceProcessInstaller,
            this.MasterServerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MasterServerServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller MasterServerServiceInstaller;
    }
}