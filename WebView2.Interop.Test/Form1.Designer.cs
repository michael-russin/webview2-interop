namespace WebView2.Interop.Test
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.buttonVisible = new System.Windows.Forms.Button();
            this.labelProcessId = new System.Windows.Forms.Label();
            this.textBoxProcessId = new System.Windows.Forms.TextBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonGoForward = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonAddNavHandlers = new System.Windows.Forms.Button();
            this.buttonRemoveNAvHandlers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZoomFactor = new System.Windows.Forms.TextBox();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.buttonDeletFocusHandlers = new System.Windows.Forms.Button();
            this.buttonAddFocusHandler = new System.Windows.Forms.Button();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.buttonDelPermissionHandler = new System.Windows.Forms.Button();
            this.buttonAddPermissionHandler = new System.Windows.Forms.Button();
            this.buttonPermissionTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddWebMessage = new System.Windows.Forms.Button();
            this.buttonAddDevProtocol = new System.Windows.Forms.Button();
            this.buttonAddNewWindow = new System.Windows.Forms.Button();
            this.buttonAddStartScript = new System.Windows.Forms.Button();
            this.button1AddScriptDialog = new System.Windows.Forms.Button();
            this.buttonAddProcessFailed = new System.Windows.Forms.Button();
            this.buttonAddTitleChanged = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveWebMessage = new System.Windows.Forms.Button();
            this.buttonRemoveDevProtocol = new System.Windows.Forms.Button();
            this.buttonDelNewWindow = new System.Windows.Forms.Button();
            this.buttonDeleteStartScript = new System.Windows.Forms.Button();
            this.buttonDelScriptDialog = new System.Windows.Forms.Button();
            this.buttonRemoveProcessFailed = new System.Windows.Forms.Button();
            this.buttonDelTitleHandler = new System.Windows.Forms.Button();
            this.buttonKill = new System.Windows.Forms.Button();
            this.buttonAlert = new System.Windows.Forms.Button();
            this.buttonExecScript = new System.Windows.Forms.Button();
            this.buttonNavigateHtml = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.buttonSetFocus = new System.Windows.Forms.Button();
            this.buttonClearCache = new System.Windows.Forms.Button();
            this.buttonMessageTest = new System.Windows.Forms.Button();
            this.buttonPostJSON = new System.Windows.Forms.Button();
            this.buttonPostString = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonDevTools = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBrowser
            // 
            this.panelBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrowser.Location = new System.Drawing.Point(-2, 67);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(647, 456);
            this.panelBrowser.TabIndex = 0;
            // 
            // buttonVisible
            // 
            this.buttonVisible.Enabled = false;
            this.buttonVisible.Location = new System.Drawing.Point(854, 117);
            this.buttonVisible.Name = "buttonVisible";
            this.buttonVisible.Size = new System.Drawing.Size(98, 23);
            this.buttonVisible.TabIndex = 1;
            this.buttonVisible.Text = "Toggle Visible";
            this.buttonVisible.UseVisualStyleBackColor = true;
            this.buttonVisible.Click += new System.EventHandler(this.buttonVisible_Click);
            // 
            // labelProcessId
            // 
            this.labelProcessId.AutoSize = true;
            this.labelProcessId.Location = new System.Drawing.Point(666, 13);
            this.labelProcessId.Name = "labelProcessId";
            this.labelProcessId.Size = new System.Drawing.Size(57, 13);
            this.labelProcessId.TabIndex = 2;
            this.labelProcessId.Text = "Process Id";
            // 
            // textBoxProcessId
            // 
            this.textBoxProcessId.Location = new System.Drawing.Point(727, 7);
            this.textBoxProcessId.Name = "textBoxProcessId";
            this.textBoxProcessId.ReadOnly = true;
            this.textBoxProcessId.Size = new System.Drawing.Size(67, 20);
            this.textBoxProcessId.TabIndex = 3;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Enabled = false;
            this.buttonGoBack.Location = new System.Drawing.Point(854, 147);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(98, 23);
            this.buttonGoBack.TabIndex = 4;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonGoForward
            // 
            this.buttonGoForward.Enabled = false;
            this.buttonGoForward.Location = new System.Drawing.Point(854, 177);
            this.buttonGoForward.Name = "buttonGoForward";
            this.buttonGoForward.Size = new System.Drawing.Size(98, 23);
            this.buttonGoForward.TabIndex = 5;
            this.buttonGoForward.Text = "Go Forward";
            this.buttonGoForward.UseVisualStyleBackColor = true;
            this.buttonGoForward.Click += new System.EventHandler(this.buttonGoForward_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Enabled = false;
            this.buttonReload.Location = new System.Drawing.Point(854, 207);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(98, 23);
            this.buttonReload.TabIndex = 6;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(13, 6);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(589, 20);
            this.textBoxUrl.TabIndex = 7;
            this.textBoxUrl.Text = "https://www.bing.com";
            // 
            // buttonGo
            // 
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(608, 3);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(37, 23);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonAddNavHandlers
            // 
            this.buttonAddNavHandlers.Location = new System.Drawing.Point(10, 19);
            this.buttonAddNavHandlers.Name = "buttonAddNavHandlers";
            this.buttonAddNavHandlers.Size = new System.Drawing.Size(112, 23);
            this.buttonAddNavHandlers.TabIndex = 9;
            this.buttonAddNavHandlers.Text = "Nav Handlers";
            this.buttonAddNavHandlers.UseVisualStyleBackColor = true;
            this.buttonAddNavHandlers.Click += new System.EventHandler(this.buttonAddNavHandlers_Click);
            // 
            // buttonRemoveNAvHandlers
            // 
            this.buttonRemoveNAvHandlers.Location = new System.Drawing.Point(15, 19);
            this.buttonRemoveNAvHandlers.Name = "buttonRemoveNAvHandlers";
            this.buttonRemoveNAvHandlers.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveNAvHandlers.TabIndex = 10;
            this.buttonRemoveNAvHandlers.Text = "Nav Handlers";
            this.buttonRemoveNAvHandlers.UseVisualStyleBackColor = true;
            this.buttonRemoveNAvHandlers.Click += new System.EventHandler(this.buttonRemoveNAvHandlers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(837, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zoom";
            // 
            // textBoxZoomFactor
            // 
            this.textBoxZoomFactor.Location = new System.Drawing.Point(877, 36);
            this.textBoxZoomFactor.Name = "textBoxZoomFactor";
            this.textBoxZoomFactor.ReadOnly = true;
            this.textBoxZoomFactor.Size = new System.Drawing.Size(100, 20);
            this.textBoxZoomFactor.TabIndex = 12;
            // 
            // buttonZoom
            // 
            this.buttonZoom.Enabled = false;
            this.buttonZoom.Location = new System.Drawing.Point(671, 217);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(98, 23);
            this.buttonZoom.TabIndex = 13;
            this.buttonZoom.Text = "Zoom";
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Version";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(727, 33);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxVersion.TabIndex = 15;
            // 
            // buttonDeletFocusHandlers
            // 
            this.buttonDeletFocusHandlers.Location = new System.Drawing.Point(15, 48);
            this.buttonDeletFocusHandlers.Name = "buttonDeletFocusHandlers";
            this.buttonDeletFocusHandlers.Size = new System.Drawing.Size(112, 23);
            this.buttonDeletFocusHandlers.TabIndex = 17;
            this.buttonDeletFocusHandlers.Text = "Focus Handlers";
            this.buttonDeletFocusHandlers.UseVisualStyleBackColor = true;
            this.buttonDeletFocusHandlers.Click += new System.EventHandler(this.buttonDeletFocusHandlers_Click);
            // 
            // buttonAddFocusHandler
            // 
            this.buttonAddFocusHandler.Location = new System.Drawing.Point(10, 48);
            this.buttonAddFocusHandler.Name = "buttonAddFocusHandler";
            this.buttonAddFocusHandler.Size = new System.Drawing.Size(112, 23);
            this.buttonAddFocusHandler.TabIndex = 16;
            this.buttonAddFocusHandler.Text = "Focus Handlers";
            this.buttonAddFocusHandler.UseVisualStyleBackColor = true;
            this.buttonAddFocusHandler.Click += new System.EventHandler(this.buttonAddFocusHandler_Click);
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.HorizontalScrollbar = true;
            this.listBoxMessages.Location = new System.Drawing.Point(-2, 570);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(844, 95);
            this.listBoxMessages.TabIndex = 18;
            // 
            // buttonDelPermissionHandler
            // 
            this.buttonDelPermissionHandler.Location = new System.Drawing.Point(15, 77);
            this.buttonDelPermissionHandler.Name = "buttonDelPermissionHandler";
            this.buttonDelPermissionHandler.Size = new System.Drawing.Size(112, 23);
            this.buttonDelPermissionHandler.TabIndex = 20;
            this.buttonDelPermissionHandler.Text = "Perm Handlers";
            this.buttonDelPermissionHandler.UseVisualStyleBackColor = true;
            this.buttonDelPermissionHandler.Click += new System.EventHandler(this.buttonDelPermissionHandler_Click);
            // 
            // buttonAddPermissionHandler
            // 
            this.buttonAddPermissionHandler.Location = new System.Drawing.Point(10, 77);
            this.buttonAddPermissionHandler.Name = "buttonAddPermissionHandler";
            this.buttonAddPermissionHandler.Size = new System.Drawing.Size(112, 23);
            this.buttonAddPermissionHandler.TabIndex = 19;
            this.buttonAddPermissionHandler.Text = "Perm Handler";
            this.buttonAddPermissionHandler.UseVisualStyleBackColor = true;
            this.buttonAddPermissionHandler.Click += new System.EventHandler(this.buttonAddPermissionHandler_Click);
            // 
            // buttonPermissionTest
            // 
            this.buttonPermissionTest.Location = new System.Drawing.Point(12, 38);
            this.buttonPermissionTest.Name = "buttonPermissionTest";
            this.buttonPermissionTest.Size = new System.Drawing.Size(96, 23);
            this.buttonPermissionTest.TabIndex = 0;
            this.buttonPermissionTest.Text = "Permission Test";
            this.buttonPermissionTest.UseVisualStyleBackColor = true;
            this.buttonPermissionTest.Click += new System.EventHandler(this.buttonPermissionTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(727, 59);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddWebMessage);
            this.groupBox1.Controls.Add(this.buttonAddDevProtocol);
            this.groupBox1.Controls.Add(this.buttonAddNewWindow);
            this.groupBox1.Controls.Add(this.buttonAddStartScript);
            this.groupBox1.Controls.Add(this.button1AddScriptDialog);
            this.groupBox1.Controls.Add(this.buttonAddProcessFailed);
            this.groupBox1.Controls.Add(this.buttonAddTitleChanged);
            this.groupBox1.Controls.Add(this.buttonAddNavHandlers);
            this.groupBox1.Controls.Add(this.buttonAddFocusHandler);
            this.groupBox1.Controls.Add(this.buttonAddPermissionHandler);
            this.groupBox1.Location = new System.Drawing.Point(661, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 309);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD";
            // 
            // buttonAddWebMessage
            // 
            this.buttonAddWebMessage.Location = new System.Drawing.Point(10, 280);
            this.buttonAddWebMessage.Name = "buttonAddWebMessage";
            this.buttonAddWebMessage.Size = new System.Drawing.Size(112, 23);
            this.buttonAddWebMessage.TabIndex = 26;
            this.buttonAddWebMessage.Text = "Web Message";
            this.buttonAddWebMessage.UseVisualStyleBackColor = true;
            this.buttonAddWebMessage.Click += new System.EventHandler(this.buttonAddWebMessage_Click);
            // 
            // buttonAddDevProtocol
            // 
            this.buttonAddDevProtocol.Location = new System.Drawing.Point(8, 251);
            this.buttonAddDevProtocol.Name = "buttonAddDevProtocol";
            this.buttonAddDevProtocol.Size = new System.Drawing.Size(112, 23);
            this.buttonAddDevProtocol.TabIndex = 25;
            this.buttonAddDevProtocol.Text = "Dev Protocol";
            this.buttonAddDevProtocol.UseVisualStyleBackColor = true;
            this.buttonAddDevProtocol.Click += new System.EventHandler(this.buttonAddDevProtocol_Click);
            // 
            // buttonAddNewWindow
            // 
            this.buttonAddNewWindow.Location = new System.Drawing.Point(10, 222);
            this.buttonAddNewWindow.Name = "buttonAddNewWindow";
            this.buttonAddNewWindow.Size = new System.Drawing.Size(112, 23);
            this.buttonAddNewWindow.TabIndex = 24;
            this.buttonAddNewWindow.Text = "New Window";
            this.buttonAddNewWindow.UseVisualStyleBackColor = true;
            this.buttonAddNewWindow.Click += new System.EventHandler(this.buttonAddNewWindow_Click);
            // 
            // buttonAddStartScript
            // 
            this.buttonAddStartScript.Location = new System.Drawing.Point(10, 193);
            this.buttonAddStartScript.Name = "buttonAddStartScript";
            this.buttonAddStartScript.Size = new System.Drawing.Size(112, 23);
            this.buttonAddStartScript.TabIndex = 23;
            this.buttonAddStartScript.Text = "Start Script";
            this.buttonAddStartScript.UseVisualStyleBackColor = true;
            this.buttonAddStartScript.Click += new System.EventHandler(this.buttonAddStartScript_Click);
            // 
            // button1AddScriptDialog
            // 
            this.button1AddScriptDialog.Location = new System.Drawing.Point(10, 164);
            this.button1AddScriptDialog.Name = "button1AddScriptDialog";
            this.button1AddScriptDialog.Size = new System.Drawing.Size(112, 23);
            this.button1AddScriptDialog.TabIndex = 22;
            this.button1AddScriptDialog.Text = "Script Dialog";
            this.button1AddScriptDialog.UseVisualStyleBackColor = true;
            this.button1AddScriptDialog.Click += new System.EventHandler(this.button1AddScriptDialog_Click);
            // 
            // buttonAddProcessFailed
            // 
            this.buttonAddProcessFailed.Location = new System.Drawing.Point(10, 135);
            this.buttonAddProcessFailed.Name = "buttonAddProcessFailed";
            this.buttonAddProcessFailed.Size = new System.Drawing.Size(112, 23);
            this.buttonAddProcessFailed.TabIndex = 21;
            this.buttonAddProcessFailed.Text = "Process Failed";
            this.buttonAddProcessFailed.UseVisualStyleBackColor = true;
            this.buttonAddProcessFailed.Click += new System.EventHandler(this.buttonAddProcessFailed_Click);
            // 
            // buttonAddTitleChanged
            // 
            this.buttonAddTitleChanged.Location = new System.Drawing.Point(10, 106);
            this.buttonAddTitleChanged.Name = "buttonAddTitleChanged";
            this.buttonAddTitleChanged.Size = new System.Drawing.Size(112, 23);
            this.buttonAddTitleChanged.TabIndex = 20;
            this.buttonAddTitleChanged.Text = "Title Handler";
            this.buttonAddTitleChanged.UseVisualStyleBackColor = true;
            this.buttonAddTitleChanged.Click += new System.EventHandler(this.buttonAddTitleChanged_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveWebMessage);
            this.groupBox2.Controls.Add(this.buttonRemoveDevProtocol);
            this.groupBox2.Controls.Add(this.buttonDelNewWindow);
            this.groupBox2.Controls.Add(this.buttonDeleteStartScript);
            this.groupBox2.Controls.Add(this.buttonDelScriptDialog);
            this.groupBox2.Controls.Add(this.buttonRemoveProcessFailed);
            this.groupBox2.Controls.Add(this.buttonDelTitleHandler);
            this.groupBox2.Controls.Add(this.buttonRemoveNAvHandlers);
            this.groupBox2.Controls.Add(this.buttonDeletFocusHandlers);
            this.groupBox2.Controls.Add(this.buttonDelPermissionHandler);
            this.groupBox2.Location = new System.Drawing.Point(825, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 309);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELETE";
            // 
            // buttonRemoveWebMessage
            // 
            this.buttonRemoveWebMessage.Location = new System.Drawing.Point(15, 277);
            this.buttonRemoveWebMessage.Name = "buttonRemoveWebMessage";
            this.buttonRemoveWebMessage.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveWebMessage.TabIndex = 27;
            this.buttonRemoveWebMessage.Text = "Web Message";
            this.buttonRemoveWebMessage.UseVisualStyleBackColor = true;
            this.buttonRemoveWebMessage.Click += new System.EventHandler(this.buttonRemoveWebMessage_Click);
            // 
            // buttonRemoveDevProtocol
            // 
            this.buttonRemoveDevProtocol.Location = new System.Drawing.Point(15, 251);
            this.buttonRemoveDevProtocol.Name = "buttonRemoveDevProtocol";
            this.buttonRemoveDevProtocol.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveDevProtocol.TabIndex = 26;
            this.buttonRemoveDevProtocol.Text = "Dev Protocol";
            this.buttonRemoveDevProtocol.UseVisualStyleBackColor = true;
            this.buttonRemoveDevProtocol.Click += new System.EventHandler(this.buttonRemoveDevProtocol_Click);
            // 
            // buttonDelNewWindow
            // 
            this.buttonDelNewWindow.Location = new System.Drawing.Point(15, 222);
            this.buttonDelNewWindow.Name = "buttonDelNewWindow";
            this.buttonDelNewWindow.Size = new System.Drawing.Size(112, 23);
            this.buttonDelNewWindow.TabIndex = 25;
            this.buttonDelNewWindow.Text = "New Window";
            this.buttonDelNewWindow.UseVisualStyleBackColor = true;
            this.buttonDelNewWindow.Click += new System.EventHandler(this.buttonDelNewWindow_Click);
            // 
            // buttonDeleteStartScript
            // 
            this.buttonDeleteStartScript.Location = new System.Drawing.Point(15, 193);
            this.buttonDeleteStartScript.Name = "buttonDeleteStartScript";
            this.buttonDeleteStartScript.Size = new System.Drawing.Size(112, 23);
            this.buttonDeleteStartScript.TabIndex = 24;
            this.buttonDeleteStartScript.Text = "Start Script";
            this.buttonDeleteStartScript.UseVisualStyleBackColor = true;
            this.buttonDeleteStartScript.Click += new System.EventHandler(this.buttonDeleteStartScript_Click);
            // 
            // buttonDelScriptDialog
            // 
            this.buttonDelScriptDialog.Location = new System.Drawing.Point(15, 164);
            this.buttonDelScriptDialog.Name = "buttonDelScriptDialog";
            this.buttonDelScriptDialog.Size = new System.Drawing.Size(112, 23);
            this.buttonDelScriptDialog.TabIndex = 23;
            this.buttonDelScriptDialog.Text = "Script Dialog";
            this.buttonDelScriptDialog.UseVisualStyleBackColor = true;
            this.buttonDelScriptDialog.Click += new System.EventHandler(this.buttonDelScriptDialog_Click);
            // 
            // buttonRemoveProcessFailed
            // 
            this.buttonRemoveProcessFailed.Location = new System.Drawing.Point(15, 135);
            this.buttonRemoveProcessFailed.Name = "buttonRemoveProcessFailed";
            this.buttonRemoveProcessFailed.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveProcessFailed.TabIndex = 22;
            this.buttonRemoveProcessFailed.Text = "Process Failed";
            this.buttonRemoveProcessFailed.UseVisualStyleBackColor = true;
            this.buttonRemoveProcessFailed.Click += new System.EventHandler(this.buttonRemoveProcessFailed_Click);
            // 
            // buttonDelTitleHandler
            // 
            this.buttonDelTitleHandler.Location = new System.Drawing.Point(15, 106);
            this.buttonDelTitleHandler.Name = "buttonDelTitleHandler";
            this.buttonDelTitleHandler.Size = new System.Drawing.Size(112, 23);
            this.buttonDelTitleHandler.TabIndex = 21;
            this.buttonDelTitleHandler.Text = "Title Handlers";
            this.buttonDelTitleHandler.UseVisualStyleBackColor = true;
            this.buttonDelTitleHandler.Click += new System.EventHandler(this.buttonDelTitleHandler_Click);
            // 
            // buttonKill
            // 
            this.buttonKill.Location = new System.Drawing.Point(800, 3);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(42, 23);
            this.buttonKill.TabIndex = 25;
            this.buttonKill.Text = "Kill";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // buttonAlert
            // 
            this.buttonAlert.Location = new System.Drawing.Point(114, 38);
            this.buttonAlert.Name = "buttonAlert";
            this.buttonAlert.Size = new System.Drawing.Size(75, 23);
            this.buttonAlert.TabIndex = 26;
            this.buttonAlert.Text = "Alert";
            this.buttonAlert.UseVisualStyleBackColor = true;
            this.buttonAlert.Click += new System.EventHandler(this.buttonAlert_Click);
            // 
            // buttonExecScript
            // 
            this.buttonExecScript.Location = new System.Drawing.Point(671, 128);
            this.buttonExecScript.Name = "buttonExecScript";
            this.buttonExecScript.Size = new System.Drawing.Size(75, 23);
            this.buttonExecScript.TabIndex = 27;
            this.buttonExecScript.Text = "Exec Script";
            this.buttonExecScript.UseVisualStyleBackColor = true;
            this.buttonExecScript.Click += new System.EventHandler(this.buttonExecScript_Click);
            // 
            // buttonNavigateHtml
            // 
            this.buttonNavigateHtml.Location = new System.Drawing.Point(195, 38);
            this.buttonNavigateHtml.Name = "buttonNavigateHtml";
            this.buttonNavigateHtml.Size = new System.Drawing.Size(75, 23);
            this.buttonNavigateHtml.TabIndex = 28;
            this.buttonNavigateHtml.Text = "Nav Html";
            this.buttonNavigateHtml.UseVisualStyleBackColor = true;
            this.buttonNavigateHtml.Click += new System.EventHandler(this.buttonNavigateHtml_Click);
            // 
            // labelSource
            // 
            this.labelSource.Location = new System.Drawing.Point(-2, 532);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(647, 14);
            this.labelSource.TabIndex = 29;
            this.labelSource.Text = "labelSource";
            // 
            // buttonSetFocus
            // 
            this.buttonSetFocus.Location = new System.Drawing.Point(671, 158);
            this.buttonSetFocus.Name = "buttonSetFocus";
            this.buttonSetFocus.Size = new System.Drawing.Size(75, 23);
            this.buttonSetFocus.TabIndex = 30;
            this.buttonSetFocus.Text = "Set Focus";
            this.buttonSetFocus.UseVisualStyleBackColor = true;
            this.buttonSetFocus.Click += new System.EventHandler(this.buttonSetFocus_Click);
            // 
            // buttonClearCache
            // 
            this.buttonClearCache.Location = new System.Drawing.Point(671, 188);
            this.buttonClearCache.Name = "buttonClearCache";
            this.buttonClearCache.Size = new System.Drawing.Size(75, 23);
            this.buttonClearCache.TabIndex = 31;
            this.buttonClearCache.Text = "Clear Cache";
            this.buttonClearCache.UseVisualStyleBackColor = true;
            this.buttonClearCache.Click += new System.EventHandler(this.buttonClearCache_Click);
            // 
            // buttonMessageTest
            // 
            this.buttonMessageTest.Location = new System.Drawing.Point(277, 38);
            this.buttonMessageTest.Name = "buttonMessageTest";
            this.buttonMessageTest.Size = new System.Drawing.Size(75, 23);
            this.buttonMessageTest.TabIndex = 32;
            this.buttonMessageTest.Text = "Message";
            this.buttonMessageTest.UseVisualStyleBackColor = true;
            this.buttonMessageTest.Click += new System.EventHandler(this.buttonMessageTest_Click);
            // 
            // buttonPostJSON
            // 
            this.buttonPostJSON.Location = new System.Drawing.Point(671, 99);
            this.buttonPostJSON.Name = "buttonPostJSON";
            this.buttonPostJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonPostJSON.TabIndex = 33;
            this.buttonPostJSON.Text = "Post JSON";
            this.buttonPostJSON.UseVisualStyleBackColor = true;
            this.buttonPostJSON.Click += new System.EventHandler(this.buttonPostJSON_Click);
            // 
            // buttonPostString
            // 
            this.buttonPostString.Location = new System.Drawing.Point(752, 99);
            this.buttonPostString.Name = "buttonPostString";
            this.buttonPostString.Size = new System.Drawing.Size(75, 23);
            this.buttonPostString.TabIndex = 34;
            this.buttonPostString.Text = "Post String";
            this.buttonPostString.UseVisualStyleBackColor = true;
            this.buttonPostString.Click += new System.EventHandler(this.buttonPostString_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(849, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(48, 23);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(903, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(57, 24);
            this.buttonStop.TabIndex = 36;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonDevTools
            // 
            this.buttonDevTools.Location = new System.Drawing.Point(877, 67);
            this.buttonDevTools.Name = "buttonDevTools";
            this.buttonDevTools.Size = new System.Drawing.Size(75, 23);
            this.buttonDevTools.TabIndex = 37;
            this.buttonDevTools.Text = "Dev Tools";
            this.buttonDevTools.UseVisualStyleBackColor = true;
            this.buttonDevTools.Click += new System.EventHandler(this.buttonDevTools_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 683);
            this.Controls.Add(this.buttonDevTools);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPostString);
            this.Controls.Add(this.buttonPostJSON);
            this.Controls.Add(this.buttonMessageTest);
            this.Controls.Add(this.buttonClearCache);
            this.Controls.Add(this.buttonSetFocus);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.buttonNavigateHtml);
            this.Controls.Add(this.buttonExecScript);
            this.Controls.Add(this.buttonAlert);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPermissionTest);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZoom);
            this.Controls.Add(this.textBoxZoomFactor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonGoForward);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.textBoxProcessId);
            this.Controls.Add(this.labelProcessId);
            this.Controls.Add(this.buttonVisible);
            this.Controls.Add(this.panelBrowser);
            this.Name = "Form1";
            this.Text = "Interop Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBrowser;
        private System.Windows.Forms.Button buttonVisible;
        private System.Windows.Forms.Label labelProcessId;
        private System.Windows.Forms.TextBox textBoxProcessId;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonGoForward;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonAddNavHandlers;
        private System.Windows.Forms.Button buttonRemoveNAvHandlers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZoomFactor;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Button buttonDeletFocusHandlers;
        private System.Windows.Forms.Button buttonAddFocusHandler;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Button buttonDelPermissionHandler;
        private System.Windows.Forms.Button buttonAddPermissionHandler;
        private System.Windows.Forms.Button buttonPermissionTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddTitleChanged;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelTitleHandler;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.Button buttonAddProcessFailed;
        private System.Windows.Forms.Button buttonRemoveProcessFailed;
        private System.Windows.Forms.Button buttonAlert;
        private System.Windows.Forms.Button button1AddScriptDialog;
        private System.Windows.Forms.Button buttonDelScriptDialog;
        private System.Windows.Forms.Button buttonAddStartScript;
        private System.Windows.Forms.Button buttonDeleteStartScript;
        private System.Windows.Forms.Button buttonExecScript;
        private System.Windows.Forms.Button buttonAddNewWindow;
        private System.Windows.Forms.Button buttonDelNewWindow;
        private System.Windows.Forms.Button buttonNavigateHtml;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Button buttonSetFocus;
        private System.Windows.Forms.Button buttonClearCache;
        private System.Windows.Forms.Button buttonAddDevProtocol;
        private System.Windows.Forms.Button buttonRemoveDevProtocol;
        private System.Windows.Forms.Button buttonMessageTest;
        private System.Windows.Forms.Button buttonPostJSON;
        private System.Windows.Forms.Button buttonPostString;
        private System.Windows.Forms.Button buttonAddWebMessage;
        private System.Windows.Forms.Button buttonRemoveWebMessage;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDevTools;
    }
}

