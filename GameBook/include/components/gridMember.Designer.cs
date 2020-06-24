namespace GameBook.include.components
{
    partial class gridMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbLogoGame = new System.Windows.Forms.PictureBox();
            this.solidLine = new System.Windows.Forms.Panel();
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picbLogoGame
            // 
            this.picbLogoGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbLogoGame.Location = new System.Drawing.Point(0, 0);
            this.picbLogoGame.Margin = new System.Windows.Forms.Padding(0);
            this.picbLogoGame.Name = "picbLogoGame";
            this.picbLogoGame.Size = new System.Drawing.Size(278, 159);
            this.picbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogoGame.TabIndex = 0;
            this.picbLogoGame.TabStop = false;
            // 
            // solidLine
            // 
            this.solidLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(5)))));
            this.solidLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.solidLine.Location = new System.Drawing.Point(0, 159);
            this.solidLine.Name = "solidLine";
            this.solidLine.Size = new System.Drawing.Size(278, 4);
            this.solidLine.TabIndex = 1;
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbGameTitle.Location = new System.Drawing.Point(5, 177);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(228, 19);
            this.lbGameTitle.TabIndex = 2;
            this.lbGameTitle.Text = "Game Title";
            // 
            // btnChoose
            // 
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("Google Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnChoose.Location = new System.Drawing.Point(239, 163);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(39, 48);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "੦";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // gridMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lbGameTitle);
            this.Controls.Add(this.solidLine);
            this.Controls.Add(this.picbLogoGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "gridMember";
            this.Size = new System.Drawing.Size(278, 211);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogoGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbLogoGame;
        private System.Windows.Forms.Panel solidLine;
        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Button btnChoose;
    }
}
