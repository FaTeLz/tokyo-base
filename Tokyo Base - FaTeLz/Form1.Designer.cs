namespace Tokyo
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
            this.components = new System.ComponentModel.Container();
            this.script = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tokyo_CheckBox1 = new Tokyo.Tokyo_CheckBox();
            this.godMode = new Tokyo.Tokyo_CheckBox();
            this.SuspendLayout();
            // 
            // script
            // 
            this.script.Enabled = true;
            this.script.Tick += new System.EventHandler(this.scriptMain);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SignPainter", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "FaTeLz.ml";
            // 
            // tokyo_CheckBox1
            // 
            this.tokyo_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.tokyo_CheckBox1.Checked = false;
            this.tokyo_CheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tokyo_CheckBox1.Location = new System.Drawing.Point(12, 49);
            this.tokyo_CheckBox1.Name = "tokyo_CheckBox1";
            this.tokyo_CheckBox1.Size = new System.Drawing.Size(62, 15);
            this.tokyo_CheckBox1.TabIndex = 2;
            this.tokyo_CheckBox1.Text = "Active";
            this.tokyo_CheckBox1.CheckedChanged += new Tokyo.Tokyo_CheckBox.CheckedChangedEventHandler(this.tokyo_CheckBox1_CheckedChanged);
            // 
            // godMode
            // 
            this.godMode.BackColor = System.Drawing.Color.Transparent;
            this.godMode.Checked = false;
            this.godMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.godMode.Location = new System.Drawing.Point(23, 70);
            this.godMode.Name = "godMode";
            this.godMode.Size = new System.Drawing.Size(85, 15);
            this.godMode.TabIndex = 3;
            this.godMode.Text = "GodMode";
            this.godMode.CheckedChanged += new Tokyo.Tokyo_CheckBox.CheckedChangedEventHandler(this.godMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.godMode);
            this.Controls.Add(this.tokyo_CheckBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer script;
        private System.Windows.Forms.Label label1;
        private Tokyo_CheckBox tokyo_CheckBox1;
        private Tokyo_CheckBox godMode;
    }
}

