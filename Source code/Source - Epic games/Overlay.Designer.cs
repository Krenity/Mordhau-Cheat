namespace epex.mordhau.recode
{
	// Token: 0x02000002 RID: 2
	public partial class Overlay : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002142 File Offset: 0x00000342
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002F68 File Offset: 0x00001168
		private void InitializeComponent()
		{
            this.overlay_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.overlay_box)).BeginInit();
            this.SuspendLayout();
            // 
            // overlay_box
            // 
            this.overlay_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay_box.Location = new System.Drawing.Point(0, 0);
            this.overlay_box.Name = "overlay_box";
            this.overlay_box.Size = new System.Drawing.Size(800, 450);
            this.overlay_box.TabIndex = 0;
            this.overlay_box.TabStop = false;
            this.overlay_box.Paint += new System.Windows.Forms.PaintEventHandler(this.overlay_box_Paint);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.overlay_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Overlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.Load += new System.EventHandler(this.Overlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overlay_box)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.PictureBox overlay_box;
	}
}
