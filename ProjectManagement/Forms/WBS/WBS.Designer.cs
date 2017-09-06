namespace ProjectManagement.Forms.WBS
{
    partial class WBS
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
            this.components = new System.ComponentModel.Container();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node8 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node9 = new DevComponents.AdvTree.Node();
            this.node10 = new DevComponents.AdvTree.Node();
            this.node11 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.node6 = new DevComponents.AdvTree.Node();
            this.node7 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panelNode = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txt_edit_node_desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btn_save_node = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txt_edit_node_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtParent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelJFW = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.sdWeight = new DevComponents.DotNetBar.Controls.Slider();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.gridManager = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnAddManager = new DevComponents.DotNetBar.ButtonX();
            this.txtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtJFW = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClear2 = new DevComponents.DotNetBar.ButtonX();
            this.intWorkload = new DevComponents.Editors.IntegerInput();
            this.btnSave2 = new DevComponents.DotNetBar.ButtonX();
            this.dtEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtJFWParent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.EditNodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolNodeUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNodeExchange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNodeRename = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.panelNode.SuspendLayout();
            this.panelJFW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intWorkload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).BeginInit();
            this.EditNodeMenu.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree1.Location = new System.Drawing.Point(0, 0);
            this.advTree1.Margin = new System.Windows.Forms.Padding(2);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(262, 496);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            this.advTree1.BeforeNodeSelect += new DevComponents.AdvTree.AdvTreeNodeCancelEventHandler(this.advTree1_BeforeNodeSelect);
            this.advTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.ParentSelect);
            this.advTree1.BeforeNodeDrop += new DevComponents.AdvTree.TreeDragDropEventHandler(this.advTree1_BeforeNodeDrop);
            this.advTree1.NodeMouseDown += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.advTree1_MouseDown);
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2,
            this.node3,
            this.node4,
            this.node5,
            this.node6,
            this.node7});
            this.node1.Text = "徐州肉菜项目";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node8});
            this.node2.Text = "项目启动";
            // 
            // node8
            // 
            this.node8.Name = "node8";
            this.node8.TagString = "123";
            this.node8.Text = "项目启动会";
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node9,
            this.node10,
            this.node11});
            this.node3.Text = "项目规划";
            // 
            // node9
            // 
            this.node9.Name = "node9";
            this.node9.Text = "工作分解";
            // 
            // node10
            // 
            this.node10.Name = "node10";
            this.node10.Text = "项目计划";
            // 
            // node11
            // 
            this.node11.Name = "node11";
            this.node11.Text = "风险识别";
            // 
            // node4
            // 
            this.node4.Name = "node4";
            this.node4.Text = "项目执行";
            // 
            // node5
            // 
            this.node5.Name = "node5";
            this.node5.Text = "项目收尾";
            // 
            // node6
            // 
            this.node6.Name = "node6";
            this.node6.Text = "例会";
            // 
            // node7
            // 
            this.node7.Name = "node7";
            this.node7.Text = "阶段汇报";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panelNode
            // 
            this.panelNode.BackColor = System.Drawing.Color.Transparent;
            this.panelNode.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNode.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNode.Controls.Add(this.labelX13);
            this.panelNode.Controls.Add(this.line1);
            this.panelNode.Controls.Add(this.txt_edit_node_desc);
            this.panelNode.Controls.Add(this.txt_Desc);
            this.panelNode.Controls.Add(this.btnClear);
            this.panelNode.Controls.Add(this.btn_save_node);
            this.panelNode.Controls.Add(this.btnSave);
            this.panelNode.Controls.Add(this.txt_edit_node_name);
            this.panelNode.Controls.Add(this.txtNode);
            this.panelNode.Controls.Add(this.labelX12);
            this.panelNode.Controls.Add(this.txtParent);
            this.panelNode.Controls.Add(this.labelX8);
            this.panelNode.Controls.Add(this.labelX2);
            this.panelNode.Controls.Add(this.labelX3);
            this.panelNode.Controls.Add(this.labelX1);
            this.panelNode.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelNode.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNode.Location = new System.Drawing.Point(273, 1);
            this.panelNode.Margin = new System.Windows.Forms.Padding(2);
            this.panelNode.Name = "panelNode";
            this.panelNode.Size = new System.Drawing.Size(300, 520);
            // 
            // 
            // 
            this.panelNode.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelNode.Style.BackColorGradientAngle = 90;
            this.panelNode.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelNode.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNode.Style.BorderBottomWidth = 1;
            this.panelNode.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelNode.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNode.Style.BorderLeftWidth = 1;
            this.panelNode.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNode.Style.BorderRightWidth = 1;
            this.panelNode.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNode.Style.BorderTopWidth = 1;
            this.panelNode.Style.CornerDiameter = 4;
            this.panelNode.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelNode.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelNode.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelNode.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelNode.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelNode.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelNode.TabIndex = 1;
            this.panelNode.Text = "添加子结点";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(109, 183);
            this.labelX13.Margin = new System.Windows.Forms.Padding(2);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(82, 18);
            this.labelX13.TabIndex = 0;
            this.labelX13.Text = "当前结点信息";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(-3, 180);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(297, 23);
            this.line1.TabIndex = 5;
            this.line1.Text = "line1";
            // 
            // txt_edit_node_desc
            // 
            // 
            // 
            // 
            this.txt_edit_node_desc.Border.Class = "TextBoxBorder";
            this.txt_edit_node_desc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_edit_node_desc.Location = new System.Drawing.Point(86, 262);
            this.txt_edit_node_desc.Multiline = true;
            this.txt_edit_node_desc.Name = "txt_edit_node_desc";
            this.txt_edit_node_desc.PreventEnterBeep = true;
            this.txt_edit_node_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_edit_node_desc.Size = new System.Drawing.Size(199, 62);
            this.txt_edit_node_desc.TabIndex = 6;
            // 
            // txt_Desc
            // 
            // 
            // 
            // 
            this.txt_Desc.Border.Class = "TextBoxBorder";
            this.txt_Desc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Desc.Location = new System.Drawing.Point(86, 65);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.PreventEnterBeep = true;
            this.txt_Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Desc.Size = new System.Drawing.Size(199, 62);
            this.txt_Desc.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(166, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 18);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_save_node
            // 
            this.btn_save_node.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save_node.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save_node.Location = new System.Drawing.Point(86, 342);
            this.btn_save_node.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_node.Name = "btn_save_node";
            this.btn_save_node.Size = new System.Drawing.Size(56, 18);
            this.btn_save_node.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save_node.TabIndex = 7;
            this.btn_save_node.Text = "保存";
            this.btn_save_node.Click += new System.EventHandler(this.btn_save_node_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(86, 145);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 18);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_edit_node_name
            // 
            this.txt_edit_node_name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_edit_node_name.Border.Class = "TextBoxBorder";
            this.txt_edit_node_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_edit_node_name.DisabledBackColor = System.Drawing.Color.White;
            this.txt_edit_node_name.ForeColor = System.Drawing.Color.Black;
            this.txt_edit_node_name.Location = new System.Drawing.Point(86, 229);
            this.txt_edit_node_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_edit_node_name.Name = "txt_edit_node_name";
            this.txt_edit_node_name.PreventEnterBeep = true;
            this.txt_edit_node_name.Size = new System.Drawing.Size(199, 21);
            this.txt_edit_node_name.TabIndex = 5;
            // 
            // txtNode
            // 
            this.txtNode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNode.Border.Class = "TextBoxBorder";
            this.txtNode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNode.DisabledBackColor = System.Drawing.Color.White;
            this.txtNode.ForeColor = System.Drawing.Color.Black;
            this.txtNode.Location = new System.Drawing.Point(86, 32);
            this.txtNode.Margin = new System.Windows.Forms.Padding(2);
            this.txtNode.Name = "txtNode";
            this.txtNode.PreventEnterBeep = true;
            this.txtNode.Size = new System.Drawing.Size(199, 21);
            this.txtNode.TabIndex = 1;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(9, 265);
            this.labelX12.Margin = new System.Windows.Forms.Padding(2);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(82, 18);
            this.labelX12.TabIndex = 0;
            this.labelX12.Text = "结点描述：";
            // 
            // txtParent
            // 
            this.txtParent.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtParent.Border.Class = "TextBoxBorder";
            this.txtParent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtParent.DisabledBackColor = System.Drawing.Color.White;
            this.txtParent.ForeColor = System.Drawing.Color.Black;
            this.txtParent.Location = new System.Drawing.Point(86, 2);
            this.txtParent.Margin = new System.Windows.Forms.Padding(2);
            this.txtParent.Name = "txtParent";
            this.txtParent.PreventEnterBeep = true;
            this.txtParent.ReadOnly = true;
            this.txtParent.Size = new System.Drawing.Size(199, 21);
            this.txtParent.TabIndex = 0;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(4, 230);
            this.labelX8.Margin = new System.Windows.Forms.Padding(2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(82, 18);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "*结点名称：";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(4, 65);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 18);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "子结点描述：";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(-2, 34);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(93, 18);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "*子结点名称：";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(-2, 5);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "*上级结点：";
            // 
            // panelJFW
            // 
            this.panelJFW.BackColor = System.Drawing.Color.Transparent;
            this.panelJFW.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelJFW.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelJFW.Controls.Add(this.advTree1);
            this.panelJFW.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelJFW.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelJFW.Location = new System.Drawing.Point(5, 1);
            this.panelJFW.Margin = new System.Windows.Forms.Padding(2);
            this.panelJFW.Name = "panelJFW";
            this.panelJFW.Size = new System.Drawing.Size(268, 520);
            // 
            // 
            // 
            this.panelJFW.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelJFW.Style.BackColorGradientAngle = 90;
            this.panelJFW.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelJFW.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelJFW.Style.BorderBottomWidth = 1;
            this.panelJFW.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelJFW.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelJFW.Style.BorderLeftWidth = 1;
            this.panelJFW.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelJFW.Style.BorderRightWidth = 1;
            this.panelJFW.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelJFW.Style.BorderTopWidth = 1;
            this.panelJFW.Style.CornerDiameter = 4;
            this.panelJFW.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelJFW.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelJFW.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelJFW.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelJFW.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelJFW.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelJFW.TabIndex = 0;
            this.panelJFW.Text = "创建WBS";
            // 
            // sdWeight
            // 
            // 
            // 
            // 
            this.sdWeight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sdWeight.Location = new System.Drawing.Point(84, 265);
            this.sdWeight.Margin = new System.Windows.Forms.Padding(2);
            this.sdWeight.Maximum = 10;
            this.sdWeight.Minimum = 1;
            this.sdWeight.Name = "sdWeight";
            this.sdWeight.Size = new System.Drawing.Size(187, 18);
            this.sdWeight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sdWeight.TabIndex = 6;
            this.sdWeight.Text = "1";
            this.sdWeight.Value = 1;
            this.sdWeight.ValueChanged += new System.EventHandler(this.sdWeight_ValueChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(1, 265);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(82, 18);
            this.labelX7.TabIndex = 24;
            this.labelX7.Text = "权  值：";
            // 
            // gridManager
            // 
            this.gridManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gridManager.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridManager.ForeColor = System.Drawing.Color.Black;
            this.gridManager.Location = new System.Drawing.Point(6, 292);
            this.gridManager.Margin = new System.Windows.Forms.Padding(2);
            this.gridManager.Name = "gridManager";
            // 
            // 
            // 
            this.gridManager.PrimaryGrid.AllowRowInsert = true;
            this.gridManager.PrimaryGrid.AutoGenerateColumns = false;
            this.gridManager.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.gridManager.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.gridManager.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.gridManager.PrimaryGrid.Columns.Add(this.gridColumn5);
            this.gridManager.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.gridManager.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.gridManager.Size = new System.Drawing.Size(277, 165);
            this.gridManager.TabIndex = 20;
            this.gridManager.Text = "superGridControl1";
            this.gridManager.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.gridManager_CellClick);
            this.gridManager.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gridManager_RowDoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "Manager";
            this.gridColumn3.Visible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FillWeight = 70;
            this.gridColumn1.HeaderText = "责任人";
            this.gridColumn1.Name = "ManagerName";
            this.gridColumn1.Width = 70;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FillWeight = 60;
            this.gridColumn2.HeaderText = "预计工作量";
            this.gridColumn2.Name = "Workload";
            this.gridColumn2.Width = 60;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FillWeight = 60;
            this.gridColumn5.HeaderText = "实际工作量";
            this.gridColumn5.Name = "ActualWorkload";
            this.gridColumn5.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.DefaultNewRowCellValue = "删除";
            this.gridColumn4.FillWeight = 60;
            this.gridColumn4.HeaderText = "操作";
            this.gridColumn4.Name = "RowDel";
            this.gridColumn4.NullString = "删除";
            this.gridColumn4.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            this.gridColumn4.Width = 60;
            // 
            // btnAddManager
            // 
            this.btnAddManager.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddManager.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddManager.Location = new System.Drawing.Point(6, 470);
            this.btnAddManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(89, 18);
            this.btnAddManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddManager.TabIndex = 7;
            this.btnAddManager.Text = "添加责任人";
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.Border.Class = "TextBoxBorder";
            this.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesc.Location = new System.Drawing.Point(83, 65);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PreventEnterBeep = true;
            this.txtDesc.Size = new System.Drawing.Size(200, 85);
            this.txtDesc.TabIndex = 2;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(1, 63);
            this.labelX11.Margin = new System.Windows.Forms.Padding(2);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(89, 18);
            this.labelX11.TabIndex = 14;
            this.labelX11.Text = "交付物描述：";
            // 
            // txtJFW
            // 
            this.txtJFW.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJFW.Border.Class = "TextBoxBorder";
            this.txtJFW.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJFW.DisabledBackColor = System.Drawing.Color.White;
            this.txtJFW.ForeColor = System.Drawing.Color.Black;
            this.txtJFW.Location = new System.Drawing.Point(83, 32);
            this.txtJFW.Margin = new System.Windows.Forms.Padding(2);
            this.txtJFW.Name = "txtJFW";
            this.txtJFW.PreventEnterBeep = true;
            this.txtJFW.Size = new System.Drawing.Size(200, 21);
            this.txtJFW.TabIndex = 1;
            // 
            // btnClear2
            // 
            this.btnClear2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear2.Location = new System.Drawing.Point(215, 470);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(68, 18);
            this.btnClear2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear2.TabIndex = 9;
            this.btnClear2.Text = "清空";
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // intWorkload
            // 
            // 
            // 
            // 
            this.intWorkload.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intWorkload.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intWorkload.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intWorkload.Location = new System.Drawing.Point(83, 233);
            this.intWorkload.Margin = new System.Windows.Forms.Padding(2);
            this.intWorkload.MinValue = 0;
            this.intWorkload.Name = "intWorkload";
            this.intWorkload.ShowUpDown = true;
            this.intWorkload.Size = new System.Drawing.Size(200, 21);
            this.intWorkload.TabIndex = 5;
            this.intWorkload.Value = 1;
            // 
            // btnSave2
            // 
            this.btnSave2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave2.Location = new System.Drawing.Point(113, 470);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(76, 18);
            this.btnSave2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave2.TabIndex = 8;
            this.btnSave2.Text = "保存";
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // dtEnd
            // 
            // 
            // 
            // 
            this.dtEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEnd.ButtonDropDown.Visible = true;
            this.dtEnd.IsPopupCalendarOpen = false;
            this.dtEnd.Location = new System.Drawing.Point(83, 197);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.DisplayMonth = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dtEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.TodayButtonVisible = true;
            this.dtEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 21);
            this.dtEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEnd.TabIndex = 4;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // dtStart
            // 
            // 
            // 
            // 
            this.dtStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStart.ButtonDropDown.Visible = true;
            this.dtStart.IsPopupCalendarOpen = false;
            this.dtStart.Location = new System.Drawing.Point(83, 161);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            this.dtStart.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.DisplayMonth = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dtStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtStart.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtStart.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.TodayButtonVisible = true;
            this.dtStart.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 21);
            this.dtStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStart.TabIndex = 3;
            this.dtStart.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(1, 197);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(82, 18);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "结束时间：";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(1, 232);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(82, 18);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "工作量：";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(1, 162);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 18);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "开始时间：";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(1, 4);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(82, 18);
            this.labelX10.TabIndex = 0;
            this.labelX10.Text = "*所属结点：";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(1, 34);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 18);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "*交付物名称：";
            // 
            // txtJFWParent
            // 
            this.txtJFWParent.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJFWParent.Border.Class = "TextBoxBorder";
            this.txtJFWParent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJFWParent.DisabledBackColor = System.Drawing.Color.White;
            this.txtJFWParent.ForeColor = System.Drawing.Color.Black;
            this.txtJFWParent.Location = new System.Drawing.Point(83, 2);
            this.txtJFWParent.Margin = new System.Windows.Forms.Padding(2);
            this.txtJFWParent.Name = "txtJFWParent";
            this.txtJFWParent.PreventEnterBeep = true;
            this.txtJFWParent.ReadOnly = true;
            this.txtJFWParent.Size = new System.Drawing.Size(200, 21);
            this.txtJFWParent.TabIndex = 0;
            // 
            // EditNodeMenu
            // 
            this.EditNodeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.EditNodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNodeUp,
            this.toolNodeExchange,
            this.toolNodeRename});
            this.EditNodeMenu.Name = "EditNodeMenu";
            this.EditNodeMenu.Size = new System.Drawing.Size(190, 70);
            // 
            // toolNodeUp
            // 
            this.toolNodeUp.Name = "toolNodeUp";
            this.toolNodeUp.Size = new System.Drawing.Size(189, 22);
            this.toolNodeUp.Text = "上移一级";
            this.toolNodeUp.Click += new System.EventHandler(this.toolNodeUp_Click);
            // 
            // toolNodeExchange
            // 
            this.toolNodeExchange.Name = "toolNodeExchange";
            this.toolNodeExchange.Size = new System.Drawing.Size(189, 22);
            this.toolNodeExchange.Text = "转为结点/转为交付物";
            this.toolNodeExchange.Click += new System.EventHandler(this.toolNodeExchange_Click);
            // 
            // toolNodeRename
            // 
            this.toolNodeRename.Name = "toolNodeRename";
            this.toolNodeRename.Size = new System.Drawing.Size(189, 22);
            this.toolNodeRename.Text = "修改名称";
            this.toolNodeRename.Click += new System.EventHandler(this.toolNodeRename_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.sdWeight);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txtJFWParent);
            this.groupPanel1.Controls.Add(this.gridManager);
            this.groupPanel1.Controls.Add(this.btnAddManager);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txtDesc);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txtJFW);
            this.groupPanel1.Controls.Add(this.dtStart);
            this.groupPanel1.Controls.Add(this.btnClear2);
            this.groupPanel1.Controls.Add(this.dtEnd);
            this.groupPanel1.Controls.Add(this.intWorkload);
            this.groupPanel1.Controls.Add(this.btnSave2);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(573, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(296, 520);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "添加交付物";
            // 
            // WBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 523);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panelNode);
            this.Controls.Add(this.panelJFW);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WBS";
            this.Text = "工作分解结构";
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.panelNode.ResumeLayout(false);
            this.panelJFW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intWorkload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).EndInit();
            this.EditNodeMenu.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNode;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtParent;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelJFW;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStart;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJFW;
        private DevComponents.Editors.IntegerInput intWorkload;
        private DevComponents.DotNetBar.ButtonX btnClear2;
        private DevComponents.DotNetBar.ButtonX btnSave2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEnd;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJFWParent;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node8;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node5;
        private DevComponents.AdvTree.Node node6;
        private DevComponents.AdvTree.Node node7;
        private DevComponents.AdvTree.Node node9;
        private DevComponents.AdvTree.Node node10;
        private DevComponents.AdvTree.Node node11;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDesc;
        private System.Windows.Forms.ContextMenuStrip EditNodeMenu;
        private System.Windows.Forms.ToolStripMenuItem toolNodeUp;
        private System.Windows.Forms.ToolStripMenuItem toolNodeExchange;
        private System.Windows.Forms.ToolStripMenuItem toolNodeRename;
        private DevComponents.DotNetBar.ButtonX btnAddManager;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridManager;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.Controls.Slider sdWeight;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Desc;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_edit_node_desc;
        private DevComponents.DotNetBar.ButtonX btn_save_node;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_edit_node_name;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}