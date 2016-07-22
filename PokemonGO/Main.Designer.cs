using System;

namespace PokemonGO
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			this.Exit_Button = new System.Windows.Forms.Button();
			this.MapBorder = new System.Windows.Forms.Panel();
			this.txtHistory = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.MapBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// gMapControl1
			// 
			this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gMapControl1.BackColor = System.Drawing.Color.MidnightBlue;
			this.gMapControl1.Bearing = 0F;
			this.gMapControl1.CanDragMap = true;
			this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl1.GrayScaleMode = false;
			this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl1.LevelsKeepInMemmory = 5;
			this.gMapControl1.Location = new System.Drawing.Point(3, 2);
			this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gMapControl1.MarkersEnabled = true;
			this.gMapControl1.MaxZoom = 20;
			this.gMapControl1.MinZoom = 2;
			this.gMapControl1.MouseWheelZoomEnabled = true;
			this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl1.Name = "gMapControl1";
			this.gMapControl1.NegativeMode = false;
			this.gMapControl1.PolygonsEnabled = true;
			this.gMapControl1.RetryLoadTile = 0;
			this.gMapControl1.RoutesEnabled = true;
			this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl1.ShowTileGridLines = false;
			this.gMapControl1.Size = new System.Drawing.Size(742, 535);
			this.gMapControl1.TabIndex = 0;
			this.gMapControl1.Zoom = 15D;
			this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
			this.gMapControl1.DoubleClick += new System.EventHandler(this.gMapControl1_DoubleClick);
			// 
			// Exit_Button
			// 
			this.Exit_Button.BackColor = System.Drawing.Color.Silver;
			this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exit_Button.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Exit_Button.Location = new System.Drawing.Point(1027, 536);
			this.Exit_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Exit_Button.Name = "Exit_Button";
			this.Exit_Button.Size = new System.Drawing.Size(72, 27);
			this.Exit_Button.TabIndex = 1;
			this.Exit_Button.Text = "Exit PokeGO Explorer :(";
			this.Exit_Button.UseVisualStyleBackColor = false;
			this.Exit_Button.Click += new System.EventHandler(this.Ex_Click);
			// 
			// MapBorder
			// 
			this.MapBorder.BackColor = System.Drawing.Color.DarkGray;
			this.MapBorder.Controls.Add(this.gMapControl1);
			this.MapBorder.Location = new System.Drawing.Point(5, 29);
			this.MapBorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MapBorder.Name = "MapBorder";
			this.MapBorder.Size = new System.Drawing.Size(748, 539);
			this.MapBorder.TabIndex = 5;
			// 
			// txtHistory
			// 
			this.txtHistory.BackColor = System.Drawing.Color.LightGray;
			this.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHistory.Location = new System.Drawing.Point(760, 34);
			this.txtHistory.Multiline = true;
			this.txtHistory.Name = "txtHistory";
			this.txtHistory.ReadOnly = true;
			this.txtHistory.Size = new System.Drawing.Size(339, 160);
			this.txtHistory.TabIndex = 26;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnLogin.Location = new System.Drawing.Point(760, 213);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(113, 41);
			this.btnLogin.TabIndex = 27;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.Silver;
			this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPause.Location = new System.Drawing.Point(760, 213);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(174, 41);
			this.btnPause.TabIndex = 28;
			this.btnPause.Text = "Start Scanning";
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1108, 572);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtHistory);
			this.Controls.Add(this.MapBorder);
			this.Controls.Add(this.Exit_Button);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Main";
			this.Text = "Pokemon GO Explorer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MapBorder.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel MapBorder;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPause;
    }

}