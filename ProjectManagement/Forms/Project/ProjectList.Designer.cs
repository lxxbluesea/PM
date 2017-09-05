namespace ProjectManagement.Forms.Project
{
    partial class ProjectList
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
            this.Btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listBoxAdv1 = new DevComponents.DotNetBar.ListBoxAdv();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Cancel.Location = new System.Drawing.Point(5, 299);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(474, 23);
            this.Btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_Cancel.TabIndex = 0;
            this.Btn_Cancel.Text = "关闭";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.listBoxAdv1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(5, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(474, 298);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "项目列表";
            // 
            // listBoxAdv1
            // 
            this.listBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxAdv1.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxAdv1.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxAdv1.CheckStateMember = null;
            this.listBoxAdv1.ContainerControlProcessDialogKey = true;
            this.listBoxAdv1.DragDropSupport = true;
            this.listBoxAdv1.Location = new System.Drawing.Point(113, 0);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.Size = new System.Drawing.Size(242, 277);
            this.listBoxAdv1.TabIndex = 0;
            this.listBoxAdv1.Text = "listBoxAdv1";
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(484, 324);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.Btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProjectList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProjectList";
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX Btn_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv1;

    }
}