using System.Drawing;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Yahtzee_UI
{
    partial class ScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.scoreTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreListView = new System.Windows.Forms.ListView();
            this.gameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameNbHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upperPointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lowerPointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameAvgPointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameTotalPointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = true;
            this.scoreTitle.Font = new System.Drawing.Font("Raleway", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(335, 10);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(87, 31);
            this.scoreTitle.TabIndex = 0;
            this.scoreTitle.Text = "Score";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scoreListView);
            this.panel1.Controls.Add(this.scoreTitle);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 410);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameHeader,
            this.gameNbHeader,
            this.upperPointsHeader,
            this.lowerPointsHeader,
            this.gameAvgPointsHeader,
            this.gameTotalPointsHeader});
            this.scoreListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreListView.FullRowSelect = true;
            this.scoreListView.GridLines = true;
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(11, 62);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(734, 331);
            this.scoreListView.TabIndex = 1;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            this.scoreListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.scoreListView_ColumnWidthChanging);
            this.scoreListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // gameHeader
            // 
            this.gameHeader.Text = "Game";
            this.gameHeader.Width = 90;
            // 
            // gameNbHeader
            // 
            this.gameNbHeader.Text = "Number of Games";
            this.gameNbHeader.Width = 130;
            // 
            // upperPointsHeader
            // 
            this.upperPointsHeader.Text = "Upper Sect. Pts (Avg.)";
            this.upperPointsHeader.Width = 140;
            // 
            // lowerPointsHeader
            // 
            this.lowerPointsHeader.Text = "Lower Sect. Pts (Avg.)";
            this.lowerPointsHeader.Width = 140;
            // 
            // gameAvgPointsHeader
            // 
            this.gameAvgPointsHeader.Text = "Average Points";
            this.gameAvgPointsHeader.Width = 120;
            // 
            // gameTotalPointsHeader
            // 
            this.gameTotalPointsHeader.Text = "Total Points";
            this.gameTotalPointsHeader.Width = 110;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView scoreListView;
        private ColumnHeader gameHeader;
        private ColumnHeader gameNbHeader;
        private ColumnHeader gameAvgPointsHeader;
        private ColumnHeader gameTotalPointsHeader;
        private ColumnHeader upperPointsHeader;
        private ColumnHeader lowerPointsHeader;
    }
}