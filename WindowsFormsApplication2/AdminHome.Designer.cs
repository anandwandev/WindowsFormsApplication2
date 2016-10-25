namespace WindowsFormsApplication2
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 23);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.databaseOperationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            this.formsToolStripMenuItem.Click += new System.EventHandler(this.formsToolStripMenuItem_Click);
            // 
            // databaseOperationsToolStripMenuItem
            // 
            this.databaseOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDatabaseToolStripMenuItem,
            this.editDatabaseToolStripMenuItem});
            this.databaseOperationsToolStripMenuItem.Name = "databaseOperationsToolStripMenuItem";
            this.databaseOperationsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.databaseOperationsToolStripMenuItem.Text = "Database Operations";
            // 
            // showDatabaseToolStripMenuItem
            // 
            this.showDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicInfoToolStripMenuItem,
            this.familyInfoToolStripMenuItem,
            this.healthInfoToolStripMenuItem,
            this.skillInfoToolStripMenuItem});
            this.showDatabaseToolStripMenuItem.Name = "showDatabaseToolStripMenuItem";
            this.showDatabaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showDatabaseToolStripMenuItem.Text = "Search Records";
            this.showDatabaseToolStripMenuItem.Click += new System.EventHandler(this.showDatabaseToolStripMenuItem_Click);
            // 
            // editDatabaseToolStripMenuItem
            // 
            this.editDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRecordsToolStripMenuItem,
            this.deleteRecordsToolStripMenuItem});
            this.editDatabaseToolStripMenuItem.Name = "editDatabaseToolStripMenuItem";
            this.editDatabaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editDatabaseToolStripMenuItem.Text = "Edit Database";
            this.editDatabaseToolStripMenuItem.Click += new System.EventHandler(this.editDatabaseToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // basicInfoToolStripMenuItem
            // 
            this.basicInfoToolStripMenuItem.Name = "basicInfoToolStripMenuItem";
            this.basicInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.basicInfoToolStripMenuItem.Text = "Basic Info";
            this.basicInfoToolStripMenuItem.Click += new System.EventHandler(this.basicInfoToolStripMenuItem_Click);
            // 
            // familyInfoToolStripMenuItem
            // 
            this.familyInfoToolStripMenuItem.Name = "familyInfoToolStripMenuItem";
            this.familyInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.familyInfoToolStripMenuItem.Text = "Family Info";
            this.familyInfoToolStripMenuItem.Click += new System.EventHandler(this.familyInfoToolStripMenuItem_Click);
            // 
            // healthInfoToolStripMenuItem
            // 
            this.healthInfoToolStripMenuItem.Name = "healthInfoToolStripMenuItem";
            this.healthInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.healthInfoToolStripMenuItem.Text = "Health Info";
            this.healthInfoToolStripMenuItem.Click += new System.EventHandler(this.healthInfoToolStripMenuItem_Click);
            // 
            // skillInfoToolStripMenuItem
            // 
            this.skillInfoToolStripMenuItem.Name = "skillInfoToolStripMenuItem";
            this.skillInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skillInfoToolStripMenuItem.Text = "Skill Info";
            this.skillInfoToolStripMenuItem.Click += new System.EventHandler(this.skillInfoToolStripMenuItem_Click);
            // 
            // editRecordsToolStripMenuItem
            // 
            this.editRecordsToolStripMenuItem.Name = "editRecordsToolStripMenuItem";
            this.editRecordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editRecordsToolStripMenuItem.Text = "Edit Records";
            this.editRecordsToolStripMenuItem.Click += new System.EventHandler(this.editRecordsToolStripMenuItem_Click);
            // 
            // deleteRecordsToolStripMenuItem
            // 
            this.deleteRecordsToolStripMenuItem.Name = "deleteRecordsToolStripMenuItem";
            this.deleteRecordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteRecordsToolStripMenuItem.Text = "Delete Records";
            this.deleteRecordsToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordsToolStripMenuItem_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSS Information Centre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordsToolStripMenuItem;
    }
}