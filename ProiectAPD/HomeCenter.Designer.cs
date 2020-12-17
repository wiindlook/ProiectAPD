
namespace ProiectAPD
{
    partial class HomeCenter
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelButoane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButoane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(964, 113);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(230, 470);
            this.panelContainer.TabIndex = 0;
            // 
            // panelButoane
            // 
            this.panelButoane.Controls.Add(this.label1);
            this.panelButoane.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButoane.Location = new System.Drawing.Point(0, 0);
            this.panelButoane.Name = "panelButoane";
            this.panelButoane.Size = new System.Drawing.Size(138, 617);
            this.panelButoane.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HomeCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButoane);
            this.Controls.Add(this.panelContainer);
            this.Name = "HomeCenter";
            this.Text = "HomeCenter";
            this.Load += new System.EventHandler(this.HomeCenter_Load);
            this.panelButoane.ResumeLayout(false);
            this.panelButoane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelButoane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}