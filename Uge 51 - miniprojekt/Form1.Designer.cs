
namespace Uge_51___miniprojekt
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pepperoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hawaiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meatLoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.bestilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hurtigstMuligtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestemtTidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.pizzaToolStripMenuItem1,
            this.bestilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pizzaToolStripMenuItem.Text = "Menu";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // pizzaToolStripMenuItem1
            // 
            this.pizzaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pepperoniToolStripMenuItem,
            this.hawaiiToolStripMenuItem,
            this.meatLoverToolStripMenuItem});
            this.pizzaToolStripMenuItem1.Name = "pizzaToolStripMenuItem1";
            this.pizzaToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.pizzaToolStripMenuItem1.Text = "Pizza";
            // 
            // pepperoniToolStripMenuItem
            // 
            this.pepperoniToolStripMenuItem.Name = "pepperoniToolStripMenuItem";
            this.pepperoniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pepperoniToolStripMenuItem.Text = "Pepperoni";
            // 
            // hawaiiToolStripMenuItem
            // 
            this.hawaiiToolStripMenuItem.Name = "hawaiiToolStripMenuItem";
            this.hawaiiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hawaiiToolStripMenuItem.Text = "Skinke";
            // 
            // meatLoverToolStripMenuItem
            // 
            this.meatLoverToolStripMenuItem.Name = "meatLoverToolStripMenuItem";
            this.meatLoverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meatLoverToolStripMenuItem.Text = "Hawaii";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(231, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(271, 571);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pepperoni";
            // 
            // bestilToolStripMenuItem
            // 
            this.bestilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hurtigstMuligtToolStripMenuItem,
            this.bestemtTidToolStripMenuItem});
            this.bestilToolStripMenuItem.Name = "bestilToolStripMenuItem";
            this.bestilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.bestilToolStripMenuItem.Text = "Bestil";
            // 
            // hurtigstMuligtToolStripMenuItem
            // 
            this.hurtigstMuligtToolStripMenuItem.Name = "hurtigstMuligtToolStripMenuItem";
            this.hurtigstMuligtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hurtigstMuligtToolStripMenuItem.Text = "Hurtigst muligt";
            // 
            // bestemtTidToolStripMenuItem
            // 
            this.bestemtTidToolStripMenuItem.Name = "bestemtTidToolStripMenuItem";
            this.bestemtTidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bestemtTidToolStripMenuItem.Text = "Bestemt tid";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(761, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pepperoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hawaiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meatLoverToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem bestilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hurtigstMuligtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestemtTidToolStripMenuItem;
    }
}

