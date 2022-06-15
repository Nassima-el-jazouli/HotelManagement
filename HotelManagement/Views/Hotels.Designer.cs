namespace HotelManagement.Views
{
    partial class Hotels
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
            this.roundedFlowPanel1 = new HotelManagement.Tools.RoundedFlowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // roundedFlowPanel1
            // 
            this.roundedFlowPanel1.BackColor = System.Drawing.Color.White;
            this.roundedFlowPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundedFlowPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedFlowPanel1.BorderRadius = 20;
            this.roundedFlowPanel1.BorderSize = 0;
            this.roundedFlowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedFlowPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedFlowPanel1.Location = new System.Drawing.Point(105, 73);
            this.roundedFlowPanel1.Name = "roundedFlowPanel1";
            this.roundedFlowPanel1.Size = new System.Drawing.Size(266, 338);
            this.roundedFlowPanel1.TabIndex = 0;
            this.roundedFlowPanel1.TextColor = System.Drawing.Color.White;
            this.roundedFlowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedFlowPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(612, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 125);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1299, 774);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.roundedFlowPanel1);
            this.MaximumSize = new System.Drawing.Size(1317, 821);
            this.MinimumSize = new System.Drawing.Size(1317, 821);
            this.Name = "Hotels";
            this.Text = "ourHotels";
            this.Load += new System.EventHandler(this.ourHotels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.RoundedFlowPanel roundedFlowPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}