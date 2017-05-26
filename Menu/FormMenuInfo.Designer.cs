﻿namespace Forms
{
    partial class FormMenuInfo
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefreshSort = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "MenuId";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.ParentFieldName = "MenuParentId";
            this.treeList1.Size = new System.Drawing.Size(1362, 659);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "菜单名称";
            this.treeListColumn1.FieldName = "MenuName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 150;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "命名空间";
            this.treeListColumn2.FieldName = "MenuSpaceName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 180;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "窗体名称";
            this.treeListColumn3.FieldName = "MenuFrmName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 180;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "是否启用";
            this.treeListColumn4.FieldName = "MenuUse";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "排序";
            this.treeListColumn5.FieldName = "MenuSort";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "菜单ID";
            this.treeListColumn6.FieldName = "MenuId";
            this.treeListColumn6.Name = "treeListColumn6";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "上级菜单ID";
            this.treeListColumn7.FieldName = "MenuParentId";
            this.treeListColumn7.Name = "treeListColumn7";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnInsert);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnRefreshSort);
            this.panelControl1.Controls.Add(this.btnMoveDown);
            this.panelControl1.Controls.Add(this.btnMoveUp);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 659);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1362, 55);
            this.panelControl1.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(129, 7);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 37);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(341, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefreshSort
            // 
            this.btnRefreshSort.Location = new System.Drawing.Point(659, 7);
            this.btnRefreshSort.Name = "btnRefreshSort";
            this.btnRefreshSort.Size = new System.Drawing.Size(86, 37);
            this.btnRefreshSort.TabIndex = 5;
            this.btnRefreshSort.Text = "重置排序";
            this.btnRefreshSort.Click += new System.EventHandler(this.btnRefreshSort_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(553, 7);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(86, 37);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(447, 7);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(86, 37);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormMenuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 714);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormMenuInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单管理";
            this.Load += new System.EventHandler(this.FormMenuInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefreshSort;
        private DevExpress.XtraEditors.SimpleButton btnMoveDown;
        private DevExpress.XtraEditors.SimpleButton btnMoveUp;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
    }
}