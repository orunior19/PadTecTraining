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

namespace PadTecTrainingPartI.Modules.TabDynamicIDs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateImageExist recording.
    /// </summary>
    [TestModule("ce00c590-e6e1-4451-a747-08861144a413", ModuleType.Recording, 1)]
    public partial class ValidateImageExist : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PadTecTrainingPartI.Repositories.DynamicIDsRepository repository.
        /// </summary>
        public static global::PadTecTrainingPartI.Repositories.DynamicIDsRepository repo = global::PadTecTrainingPartI.Repositories.DynamicIDsRepository.Instance;

        static ValidateImageExist instance = new ValidateImageExist();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateImageExist()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateImageExist Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (ControlTypeName='PictureBox') on item 'RxMainFrame.PictureBox'.", repo.RxMainFrame.PictureBoxInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.RxMainFrame.PictureBoxInfo, "ControlTypeName", "PictureBox");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
