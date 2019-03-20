﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace advancedGUITest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Task1_votingForSam - Use 'Task1_votingForSamParams' to pass parameters into this method.
        /// </summary>
        public void Task1_votingForSam()
        {
            #region Variable Declarations
            WinEdit uINameEdit = this.UIDebugWindow.UIItemWindow.UIEVotingSystemListItem.UINameEdit;
            WinEdit uIUsernameBoxEdit = this.UIItemWindow.UIUsernameBoxWindow.UIUsernameBoxEdit;
            WinEdit uIPasswordBoxEdit = this.UIItemWindow.UIPasswordBoxWindow.UIPasswordBoxEdit;
            WinCheckBox uIIamnotarobotCheckBox = this.UIIamnotarobotWindow.UIIamnotarobotCheckBox;
            WinButton uILoginButton = this.UILoginWindow.UILoginButton;
            WinButton uIContinueButton = this.UIContinueWindow.UIContinueButton;
            WinButton uISamGreenPartyButton = this.UIVotePanelWindow.UISamGreenPartyWindow.UISamGreenPartyButton;
            WinButton uIContinueButton1 = this.UIVotePanelWindow.UIContinueWindow.UIContinueButton;
            WinButton uIYesButton = this.UIConfirmPanelWindow.UIYesWindow.UIYesButton;
            WinButton uIEndSessionButton = this.UIThankYouPanelWindow.UIEndSessionWindow.UIEndSessionButton;
            WinButton uICloseButton = this.UIItemWindow.UILoginScreenWindow.UILoginScreenTitleBar.UICloseButton;
            #endregion

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(55, 8));

            // Type 'Robin' in 'usernameBox' text box
            uIUsernameBoxEdit.Text = this.Task1_votingForSamParams.UIUsernameBoxEditText;

            // Type '{Tab}' in 'usernameBox' text box
            Keyboard.SendKeys(uIUsernameBoxEdit, this.Task1_votingForSamParams.UIUsernameBoxEditSendKeys, ModifierKeys.None);

            // Type '********' in 'passwordBox' text box
            Keyboard.SendKeys(uIPasswordBoxEdit, this.Task1_votingForSamParams.UIPasswordBoxEditSendKeys, true);

            // Select 'I am not a robot' check box
            uIIamnotarobotCheckBox.Checked = this.Task1_votingForSamParams.UIIamnotarobotCheckBoxChecked;

            // Click 'Login' button
            Mouse.Click(uILoginButton, new Point(23, 14));

            // Click 'Continue' button
            Mouse.Click(uIContinueButton, new Point(23, 9));

            // Click 'Sam: Green Party' button
            Mouse.Click(uISamGreenPartyButton, new Point(96, 32));

            // Click 'Continue' button
            Mouse.Click(uIContinueButton1, new Point(114, 54));

            // Click 'Yes' button
            Mouse.Click(uIYesButton, new Point(56, 30));

            // Click 'End Session' button
            Mouse.Click(uIEndSessionButton, new Point(118, 34));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(26, 24));
        }
        
        #region Properties
        public virtual Task1_votingForSamParams Task1_votingForSamParams
        {
            get
            {
                if ((this.mTask1_votingForSamParams == null))
                {
                    this.mTask1_votingForSamParams = new Task1_votingForSamParams();
                }
                return this.mTask1_votingForSamParams;
            }
        }
        
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIIamnotarobotWindow UIIamnotarobotWindow
        {
            get
            {
                if ((this.mUIIamnotarobotWindow == null))
                {
                    this.mUIIamnotarobotWindow = new UIIamnotarobotWindow();
                }
                return this.mUIIamnotarobotWindow;
            }
        }
        
        public UILoginWindow UILoginWindow
        {
            get
            {
                if ((this.mUILoginWindow == null))
                {
                    this.mUILoginWindow = new UILoginWindow();
                }
                return this.mUILoginWindow;
            }
        }
        
        public UIContinueWindow UIContinueWindow
        {
            get
            {
                if ((this.mUIContinueWindow == null))
                {
                    this.mUIContinueWindow = new UIContinueWindow();
                }
                return this.mUIContinueWindow;
            }
        }
        
        public UIVotePanelWindow UIVotePanelWindow
        {
            get
            {
                if ((this.mUIVotePanelWindow == null))
                {
                    this.mUIVotePanelWindow = new UIVotePanelWindow();
                }
                return this.mUIVotePanelWindow;
            }
        }
        
        public UIConfirmPanelWindow UIConfirmPanelWindow
        {
            get
            {
                if ((this.mUIConfirmPanelWindow == null))
                {
                    this.mUIConfirmPanelWindow = new UIConfirmPanelWindow();
                }
                return this.mUIConfirmPanelWindow;
            }
        }
        
        public UIThankYouPanelWindow UIThankYouPanelWindow
        {
            get
            {
                if ((this.mUIThankYouPanelWindow == null))
                {
                    this.mUIThankYouPanelWindow = new UIThankYouPanelWindow();
                }
                return this.mUIThankYouPanelWindow;
            }
        }
        #endregion
        
        #region Fields
        private Task1_votingForSamParams mTask1_votingForSamParams;
        
        private UIDebugWindow mUIDebugWindow;
        
        private UIItemWindow1 mUIItemWindow;
        
        private UIIamnotarobotWindow mUIIamnotarobotWindow;
        
        private UILoginWindow mUILoginWindow;
        
        private UIContinueWindow mUIContinueWindow;
        
        private UIVotePanelWindow mUIVotePanelWindow;
        
        private UIConfirmPanelWindow mUIConfirmPanelWindow;
        
        private UIThankYouPanelWindow mUIThankYouPanelWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Task1_votingForSam'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Task1_votingForSamParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Robin' in 'usernameBox' text box
        /// </summary>
        public string UIUsernameBoxEditText = "Robin";
        
        /// <summary>
        /// Type '{Tab}' in 'usernameBox' text box
        /// </summary>
        public string UIUsernameBoxEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '********' in 'passwordBox' text box
        /// </summary>
        public string UIPasswordBoxEditSendKeys = "QWwOodIXpSM441BCNCWNvH9k+8fhegdI";
        
        /// <summary>
        /// Select 'I am not a robot' check box
        /// </summary>
        public bool UIIamnotarobotCheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIEVotingSystemListItem UIEVotingSystemListItem
        {
            get
            {
                if ((this.mUIEVotingSystemListItem == null))
                {
                    this.mUIEVotingSystemListItem = new UIEVotingSystemListItem(this);
                }
                return this.mUIEVotingSystemListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIEVotingSystemListItem mUIEVotingSystemListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIEVotingSystemListItem : WinListItem
    {
        
        public UIEVotingSystemListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "EVotingSystem";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop 1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
            #endregion
        }
        
        #region Properties
        public UIUsernameBoxWindow UIUsernameBoxWindow
        {
            get
            {
                if ((this.mUIUsernameBoxWindow == null))
                {
                    this.mUIUsernameBoxWindow = new UIUsernameBoxWindow(this);
                }
                return this.mUIUsernameBoxWindow;
            }
        }
        
        public UIPasswordBoxWindow UIPasswordBoxWindow
        {
            get
            {
                if ((this.mUIPasswordBoxWindow == null))
                {
                    this.mUIPasswordBoxWindow = new UIPasswordBoxWindow(this);
                }
                return this.mUIPasswordBoxWindow;
            }
        }
        
        public UILoginScreenWindow UILoginScreenWindow
        {
            get
            {
                if ((this.mUILoginScreenWindow == null))
                {
                    this.mUILoginScreenWindow = new UILoginScreenWindow(this);
                }
                return this.mUILoginScreenWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIUsernameBoxWindow mUIUsernameBoxWindow;
        
        private UIPasswordBoxWindow mUIPasswordBoxWindow;
        
        private UILoginScreenWindow mUILoginScreenWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIUsernameBoxWindow : WinWindow
    {
        
        public UIUsernameBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "usernameBox";
            #endregion
        }
        
        #region Properties
        public WinEdit UIUsernameBoxEdit
        {
            get
            {
                if ((this.mUIUsernameBoxEdit == null))
                {
                    this.mUIUsernameBoxEdit = new WinEdit(this);
                }
                return this.mUIUsernameBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIUsernameBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPasswordBoxWindow : WinWindow
    {
        
        public UIPasswordBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "passwordBox";
            #endregion
        }
        
        #region Properties
        public WinEdit UIPasswordBoxEdit
        {
            get
            {
                if ((this.mUIPasswordBoxEdit == null))
                {
                    this.mUIPasswordBoxEdit = new WinEdit(this);
                }
                return this.mUIPasswordBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIPasswordBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UILoginScreenWindow : WinWindow
    {
        
        public UILoginScreenWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UILoginScreenTitleBar UILoginScreenTitleBar
        {
            get
            {
                if ((this.mUILoginScreenTitleBar == null))
                {
                    this.mUILoginScreenTitleBar = new UILoginScreenTitleBar(this);
                }
                return this.mUILoginScreenTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UILoginScreenTitleBar mUILoginScreenTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UILoginScreenTitleBar : WinTitleBar
    {
        
        public UILoginScreenTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIIamnotarobotWindow : WinWindow
    {
        
        public UIIamnotarobotWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "I am not a robot";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("I am not a robot");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIIamnotarobotCheckBox
        {
            get
            {
                if ((this.mUIIamnotarobotCheckBox == null))
                {
                    this.mUIIamnotarobotCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIIamnotarobotCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "I am not a robot";
                    this.mUIIamnotarobotCheckBox.WindowTitles.Add("I am not a robot");
                    #endregion
                }
                return this.mUIIamnotarobotCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIIamnotarobotCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UILoginWindow : WinWindow
    {
        
        public UILoginWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Login";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Login");
            #endregion
        }
        
        #region Properties
        public WinButton UILoginButton
        {
            get
            {
                if ((this.mUILoginButton == null))
                {
                    this.mUILoginButton = new WinButton(this);
                    #region Search Criteria
                    this.mUILoginButton.SearchProperties[WinButton.PropertyNames.Name] = "Login";
                    this.mUILoginButton.WindowTitles.Add("Login");
                    #endregion
                }
                return this.mUILoginButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUILoginButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIContinueWindow : WinWindow
    {
        
        public UIContinueWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Continue";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Continue");
            #endregion
        }
        
        #region Properties
        public WinButton UIContinueButton
        {
            get
            {
                if ((this.mUIContinueButton == null))
                {
                    this.mUIContinueButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIContinueButton.SearchProperties[WinButton.PropertyNames.Name] = "Continue";
                    this.mUIContinueButton.WindowTitles.Add("Continue");
                    #endregion
                }
                return this.mUIContinueButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIContinueButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIVotePanelWindow : WinWindow
    {
        
        public UIVotePanelWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Accessability";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UISamGreenPartyWindow UISamGreenPartyWindow
        {
            get
            {
                if ((this.mUISamGreenPartyWindow == null))
                {
                    this.mUISamGreenPartyWindow = new UISamGreenPartyWindow(this);
                }
                return this.mUISamGreenPartyWindow;
            }
        }
        
        public UIContinueWindow1 UIContinueWindow
        {
            get
            {
                if ((this.mUIContinueWindow == null))
                {
                    this.mUIContinueWindow = new UIContinueWindow1(this);
                }
                return this.mUIContinueWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISamGreenPartyWindow mUISamGreenPartyWindow;
        
        private UIContinueWindow1 mUIContinueWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UISamGreenPartyWindow : WinWindow
    {
        
        public UISamGreenPartyWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "SamBtn";
            #endregion
        }
        
        #region Properties
        public WinButton UISamGreenPartyButton
        {
            get
            {
                if ((this.mUISamGreenPartyButton == null))
                {
                    this.mUISamGreenPartyButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISamGreenPartyButton.SearchProperties[WinButton.PropertyNames.Name] = "Sam: Green Party";
                    #endregion
                }
                return this.mUISamGreenPartyButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISamGreenPartyButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIContinueWindow1 : WinWindow
    {
        
        public UIContinueWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "submitBtn";
            #endregion
        }
        
        #region Properties
        public WinButton UIContinueButton
        {
            get
            {
                if ((this.mUIContinueButton == null))
                {
                    this.mUIContinueButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIContinueButton.SearchProperties[WinButton.PropertyNames.Name] = "Continue";
                    #endregion
                }
                return this.mUIContinueButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIContinueButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIConfirmPanelWindow : WinWindow
    {
        
        public UIConfirmPanelWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Select at least ONE candidate";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIYesWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow(this);
                }
                return this.mUIYesWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYesWindow mUIYesWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIYesWindow : WinWindow
    {
        
        public UIYesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "confirmBtn";
            #endregion
        }
        
        #region Properties
        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIYesButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIThankYouPanelWindow : WinWindow
    {
        
        public UIThankYouPanelWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Help";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIEndSessionWindow UIEndSessionWindow
        {
            get
            {
                if ((this.mUIEndSessionWindow == null))
                {
                    this.mUIEndSessionWindow = new UIEndSessionWindow(this);
                }
                return this.mUIEndSessionWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIEndSessionWindow mUIEndSessionWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIEndSessionWindow : WinWindow
    {
        
        public UIEndSessionWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "signOutLbl";
            #endregion
        }
        
        #region Properties
        public WinButton UIEndSessionButton
        {
            get
            {
                if ((this.mUIEndSessionButton == null))
                {
                    this.mUIEndSessionButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEndSessionButton.SearchProperties[WinButton.PropertyNames.Name] = "End Session";
                    #endregion
                }
                return this.mUIEndSessionButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEndSessionButton;
        #endregion
    }
}
