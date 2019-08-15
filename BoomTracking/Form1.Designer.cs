namespace BoomTracking
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.locationGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.boomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boomsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoomGear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoomSticks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.boomStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boomStickGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.boomGearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boomGearGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.boomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boomGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingNavigator)).BeginInit();
            this.locationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomStickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomStickGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGearGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(BoomTracking.Location);
            // 
            // locationBindingNavigator
            // 
            this.locationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locationBindingNavigator.BindingSource = this.locationBindingSource;
            this.locationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.locationBindingNavigatorSaveItem});
            this.locationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locationBindingNavigator.Name = "locationBindingNavigator";
            this.locationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locationBindingNavigator.Size = new System.Drawing.Size(1281, 25);
            this.locationBindingNavigator.TabIndex = 1;
            this.locationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locationBindingNavigatorSaveItem
            // 
            this.locationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locationBindingNavigatorSaveItem.Image")));
            this.locationBindingNavigatorSaveItem.Name = "locationBindingNavigatorSaveItem";
            this.locationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locationBindingNavigatorSaveItem.Text = "Save Data";
            this.locationBindingNavigatorSaveItem.Click += new System.EventHandler(this.locationBindingNavigatorSaveItem_Click);
            // 
            // locationGridControl
            // 
            this.locationGridControl.DataSource = this.locationBindingSource;
            this.locationGridControl.Location = new System.Drawing.Point(20, 28);
            this.locationGridControl.MainView = this.gridView1;
            this.locationGridControl.Name = "locationGridControl";
            this.locationGridControl.Size = new System.Drawing.Size(283, 220);
            this.locationGridControl.TabIndex = 2;
            this.locationGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName});
            this.gridView1.GridControl = this.locationGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // boomsBindingSource
            // 
            this.boomsBindingSource.DataMember = "Booms";
            this.boomsBindingSource.DataSource = this.locationBindingSource;
            // 
            // boomsGridControl
            // 
            this.boomsGridControl.DataSource = this.boomsBindingSource;
            this.boomsGridControl.Location = new System.Drawing.Point(309, 28);
            this.boomsGridControl.MainView = this.gridView2;
            this.boomsGridControl.Name = "boomsGridControl";
            this.boomsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.boomsGridControl.Size = new System.Drawing.Size(637, 220);
            this.boomsGridControl.TabIndex = 3;
            this.boomsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colLocation,
            this.colIsActive,
            this.colName1,
            this.colLogs,
            this.colBoomGear,
            this.colBoomSticks});
            this.gridView2.GridControl = this.boomsGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            // 
            // colLocation
            // 
            this.colLocation.ColumnEdit = this.repositoryItemComboBox1;
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 3;
            // 
            // colLogs
            // 
            this.colLogs.FieldName = "Logs";
            this.colLogs.Name = "colLogs";
            this.colLogs.Visible = true;
            this.colLogs.VisibleIndex = 4;
            // 
            // colBoomGear
            // 
            this.colBoomGear.FieldName = "BoomGear";
            this.colBoomGear.Name = "colBoomGear";
            this.colBoomGear.Visible = true;
            this.colBoomGear.VisibleIndex = 5;
            // 
            // colBoomSticks
            // 
            this.colBoomSticks.FieldName = "BoomSticks";
            this.colBoomSticks.Name = "colBoomSticks";
            this.colBoomSticks.Visible = true;
            this.colBoomSticks.VisibleIndex = 6;
            // 
            // boomStickBindingSource
            // 
            this.boomStickBindingSource.DataSource = typeof(BoomTracking.BoomStick);
            // 
            // boomStickGridControl
            // 
            this.boomStickGridControl.DataSource = this.boomStickBindingSource;
            this.boomStickGridControl.Location = new System.Drawing.Point(309, 266);
            this.boomStickGridControl.MainView = this.gridView4;
            this.boomStickGridControl.Name = "boomStickGridControl";
            this.boomStickGridControl.Size = new System.Drawing.Size(300, 220);
            this.boomStickGridControl.TabIndex = 4;
            this.boomStickGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.boomStickGridControl;
            this.gridView4.Name = "gridView4";
            // 
            // boomGearBindingSource
            // 
            this.boomGearBindingSource.DataSource = typeof(BoomTracking.BoomGear);
            // 
            // boomGearGridControl
            // 
            this.boomGearGridControl.DataSource = this.boomGearBindingSource;
            this.boomGearGridControl.Location = new System.Drawing.Point(615, 266);
            this.boomGearGridControl.MainView = this.gridView5;
            this.boomGearGridControl.Name = "boomGearGridControl";
            this.boomGearGridControl.Size = new System.Drawing.Size(300, 220);
            this.boomGearGridControl.TabIndex = 5;
            this.boomGearGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.boomGearGridControl;
            this.gridView5.Name = "gridView5";
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataSource = typeof(BoomTracking.Log);
            // 
            // logGridControl
            // 
            this.logGridControl.DataSource = this.logBindingSource;
            this.logGridControl.Location = new System.Drawing.Point(0, 266);
            this.logGridControl.MainView = this.gridView3;
            this.logGridControl.Name = "logGridControl";
            this.logGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox2});
            this.logGridControl.Size = new System.Drawing.Size(300, 220);
            this.logGridControl.TabIndex = 5;
            this.logGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colSpecies,
            this.colVolume,
            this.colConsumed,
            this.colBoom});
            this.gridView3.GridControl = this.logGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // boomsBindingSource1
            // 
            this.boomsBindingSource1.DataMember = "Booms";
            this.boomsBindingSource1.DataSource = this.logBindingSource;
            // 
            // boomGridControl
            // 
            this.boomGridControl.DataSource = this.boomsBindingSource1;
            this.boomGridControl.Location = new System.Drawing.Point(921, 266);
            this.boomGridControl.MainView = this.gridView6;
            this.boomGridControl.Name = "boomGridControl";
            this.boomGridControl.Size = new System.Drawing.Size(300, 220);
            this.boomGridControl.TabIndex = 6;
            this.boomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.boomGridControl;
            this.gridView6.Name = "gridView6";
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            // 
            // colSpecies
            // 
            this.colSpecies.FieldName = "Species";
            this.colSpecies.Name = "colSpecies";
            this.colSpecies.Visible = true;
            this.colSpecies.VisibleIndex = 1;
            // 
            // colVolume
            // 
            this.colVolume.FieldName = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 2;
            // 
            // colConsumed
            // 
            this.colConsumed.FieldName = "Consumed";
            this.colConsumed.Name = "colConsumed";
            this.colConsumed.Visible = true;
            this.colConsumed.VisibleIndex = 3;
            // 
            // colBoom
            // 
            this.colBoom.ColumnEdit = this.repositoryItemComboBox2;
            this.colBoom.FieldName = "Boom";
            this.colBoom.Name = "colBoom";
            this.colBoom.Visible = true;
            this.colBoom.VisibleIndex = 4;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 619);
            this.Controls.Add(this.boomGridControl);
            this.Controls.Add(this.logGridControl);
            this.Controls.Add(this.boomGearGridControl);
            this.Controls.Add(this.boomStickGridControl);
            this.Controls.Add(this.boomsGridControl);
            this.Controls.Add(this.locationGridControl);
            this.Controls.Add(this.locationBindingNavigator);
            this.Name = "frmMain";
            this.Text = "Boom Tracking";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingNavigator)).EndInit();
            this.locationBindingNavigator.ResumeLayout(false);
            this.locationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomStickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomStickGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGearGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.BindingNavigator locationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton locationBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl locationGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.BindingSource boomsBindingSource;
        private DevExpress.XtraGrid.GridControl boomsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLogs;
        private DevExpress.XtraGrid.Columns.GridColumn colBoomGear;
        private DevExpress.XtraGrid.Columns.GridColumn colBoomSticks;
        private System.Windows.Forms.BindingSource boomStickBindingSource;
        private DevExpress.XtraGrid.GridControl boomStickGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource boomGearBindingSource;
        private DevExpress.XtraGrid.GridControl boomGearGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.BindingSource logBindingSource;
        private DevExpress.XtraGrid.GridControl logGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource boomsBindingSource1;
        private DevExpress.XtraGrid.GridControl boomGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecies;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumed;
        private DevExpress.XtraGrid.Columns.GridColumn colBoom;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
    }
}

