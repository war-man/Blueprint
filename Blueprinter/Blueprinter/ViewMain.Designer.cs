namespace Blueprinter
{
    partial class ViewMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueprintManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBlueprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BasepathTextbox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BlueprintCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BlueprintTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.hHelpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(510, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueprintManagerToolStripMenuItem,
            this.contentManagerToolStripMenuItem});
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.templatesToolStripMenuItem.Text = "&Templates";
            // 
            // blueprintManagerToolStripMenuItem
            // 
            this.blueprintManagerToolStripMenuItem.Name = "blueprintManagerToolStripMenuItem";
            this.blueprintManagerToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.blueprintManagerToolStripMenuItem.Text = "Blueprint Manager";
            // 
            // contentManagerToolStripMenuItem
            // 
            this.contentManagerToolStripMenuItem.Name = "contentManagerToolStripMenuItem";
            this.contentManagerToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.contentManagerToolStripMenuItem.Text = "Content Manager";
            // 
            // hHelpToolStripMenuItem
            // 
            this.hHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBlueprintToolStripMenuItem});
            this.hHelpToolStripMenuItem.Name = "hHelpToolStripMenuItem";
            this.hHelpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.hHelpToolStripMenuItem.Text = "&Help";
            this.hHelpToolStripMenuItem.Click += new System.EventHandler(this.hHelpToolStripMenuItem_Click);
            // 
            // aboutBlueprintToolStripMenuItem
            // 
            this.aboutBlueprintToolStripMenuItem.Name = "aboutBlueprintToolStripMenuItem";
            this.aboutBlueprintToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.aboutBlueprintToolStripMenuItem.Text = "About Blueprint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base Path: :) :)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasepathTextbox
            // 
            this.BasepathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasepathTextbox.Location = new System.Drawing.Point(15, 72);
            this.BasepathTextbox.Name = "BasepathTextbox";
            this.BasepathTextbox.Size = new System.Drawing.Size(436, 22);
            this.BasepathTextbox.TabIndex = 3;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(457, 72);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(41, 23);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(423, 298);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "&Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // BlueprintCombobox
            // 
            this.BlueprintCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueprintCombobox.FormattingEnabled = true;
            this.BlueprintCombobox.Location = new System.Drawing.Point(288, 100);
            this.BlueprintCombobox.Name = "BlueprintCombobox";
            this.BlueprintCombobox.Size = new System.Drawing.Size(210, 24);
            this.BlueprintCombobox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blueprint:";
            // 
            // BlueprintTextbox
            // 
            this.BlueprintTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueprintTextbox.Location = new System.Drawing.Point(15, 130);
            this.BlueprintTextbox.Multiline = true;
            this.BlueprintTextbox.Name = "BlueprintTextbox";
            this.BlueprintTextbox.Size = new System.Drawing.Size(483, 162);
            this.BlueprintTextbox.TabIndex = 8;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 333);
            this.Controls.Add(this.BlueprintTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlueprintCombobox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.BasepathTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ViewMain";
            this.Text = "Blueprinter";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueprintManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBlueprintToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasepathTextbox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox BlueprintCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BlueprintTextbox;
    }
}

