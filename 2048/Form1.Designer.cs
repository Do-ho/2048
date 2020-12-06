namespace _2048
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainScore = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.BestScoreBox = new System.Windows.Forms.GroupBox();
            this.BestScoreText = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.GaneBackGround = new System.Windows.Forms.Label();
            this.Block11 = new System.Windows.Forms.Label();
            this.Block12 = new System.Windows.Forms.Label();
            this.Block13 = new System.Windows.Forms.Label();
            this.Block14 = new System.Windows.Forms.Label();
            this.Block24 = new System.Windows.Forms.Label();
            this.Block23 = new System.Windows.Forms.Label();
            this.Block22 = new System.Windows.Forms.Label();
            this.Block21 = new System.Windows.Forms.Label();
            this.Block34 = new System.Windows.Forms.Label();
            this.Block33 = new System.Windows.Forms.Label();
            this.Block32 = new System.Windows.Forms.Label();
            this.Block31 = new System.Windows.Forms.Label();
            this.Block44 = new System.Windows.Forms.Label();
            this.Block43 = new System.Windows.Forms.Label();
            this.Block42 = new System.Windows.Forms.Label();
            this.Block41 = new System.Windows.Forms.Label();
            this.ScoreBox.SuspendLayout();
            this.BestScoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScore
            // 
            this.MainScore.AutoSize = true;
            this.MainScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.MainScore.Font = new System.Drawing.Font("배달의민족 도현", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.MainScore.Location = new System.Drawing.Point(12, 31);
            this.MainScore.Name = "MainScore";
            this.MainScore.Size = new System.Drawing.Size(157, 57);
            this.MainScore.TabIndex = 0;
            this.MainScore.Text = "2048";
            // 
            // ScoreText
            // 
            this.ScoreText.Font = new System.Drawing.Font("-윤고딕330", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreText.ForeColor = System.Drawing.Color.White;
            this.ScoreText.Location = new System.Drawing.Point(6, 23);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(113, 24);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "0";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.ScoreBox.Controls.Add(this.ScoreText);
            this.ScoreBox.Font = new System.Drawing.Font("-윤고딕350", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.ScoreBox.Location = new System.Drawing.Point(196, 28);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(125, 59);
            this.ScoreBox.TabIndex = 2;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "Score";
            // 
            // BestScoreBox
            // 
            this.BestScoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.BestScoreBox.Controls.Add(this.BestScoreText);
            this.BestScoreBox.Font = new System.Drawing.Font("-윤고딕350", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestScoreBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.BestScoreBox.Location = new System.Drawing.Point(344, 28);
            this.BestScoreBox.Name = "BestScoreBox";
            this.BestScoreBox.Size = new System.Drawing.Size(125, 59);
            this.BestScoreBox.TabIndex = 3;
            this.BestScoreBox.TabStop = false;
            this.BestScoreBox.Text = "Best";
            // 
            // BestScoreText
            // 
            this.BestScoreText.Font = new System.Drawing.Font("-윤고딕330", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestScoreText.ForeColor = System.Drawing.Color.White;
            this.BestScoreText.Location = new System.Drawing.Point(6, 23);
            this.BestScoreText.Name = "BestScoreText";
            this.BestScoreText.Size = new System.Drawing.Size(113, 24);
            this.BestScoreText.TabIndex = 2;
            this.BestScoreText.Text = "0";
            this.BestScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BestScoreText.Click += new System.EventHandler(this.BestScoreText_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(102)))));
            this.NewGameButton.Font = new System.Drawing.Font("-윤고딕330", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewGameButton.ForeColor = System.Drawing.Color.White;
            this.NewGameButton.Location = new System.Drawing.Point(331, 103);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(138, 42);
            this.NewGameButton.TabIndex = 4;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // GaneBackGround
            // 
            this.GaneBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.GaneBackGround.Location = new System.Drawing.Point(24, 166);
            this.GaneBackGround.Name = "GaneBackGround";
            this.GaneBackGround.Size = new System.Drawing.Size(440, 440);
            this.GaneBackGround.TabIndex = 5;
            // 
            // Block11
            // 
            this.Block11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block11.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block11.Location = new System.Drawing.Point(41, 185);
            this.Block11.Name = "Block11";
            this.Block11.Size = new System.Drawing.Size(92, 92);
            this.Block11.TabIndex = 6;
            this.Block11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block12
            // 
            this.Block12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block12.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block12.Location = new System.Drawing.Point(146, 185);
            this.Block12.Name = "Block12";
            this.Block12.Size = new System.Drawing.Size(92, 92);
            this.Block12.TabIndex = 7;
            this.Block12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block13
            // 
            this.Block13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block13.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block13.Location = new System.Drawing.Point(251, 185);
            this.Block13.Name = "Block13";
            this.Block13.Size = new System.Drawing.Size(92, 92);
            this.Block13.TabIndex = 8;
            this.Block13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block14
            // 
            this.Block14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block14.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block14.Location = new System.Drawing.Point(356, 185);
            this.Block14.Name = "Block14";
            this.Block14.Size = new System.Drawing.Size(92, 92);
            this.Block14.TabIndex = 9;
            this.Block14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block24
            // 
            this.Block24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block24.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block24.Location = new System.Drawing.Point(356, 289);
            this.Block24.Name = "Block24";
            this.Block24.Size = new System.Drawing.Size(92, 92);
            this.Block24.TabIndex = 13;
            this.Block24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block23
            // 
            this.Block23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block23.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block23.Location = new System.Drawing.Point(251, 289);
            this.Block23.Name = "Block23";
            this.Block23.Size = new System.Drawing.Size(92, 92);
            this.Block23.TabIndex = 12;
            this.Block23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block22
            // 
            this.Block22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block22.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block22.Location = new System.Drawing.Point(146, 289);
            this.Block22.Name = "Block22";
            this.Block22.Size = new System.Drawing.Size(92, 92);
            this.Block22.TabIndex = 11;
            this.Block22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block21
            // 
            this.Block21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block21.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block21.Location = new System.Drawing.Point(41, 289);
            this.Block21.Name = "Block21";
            this.Block21.Size = new System.Drawing.Size(92, 92);
            this.Block21.TabIndex = 10;
            this.Block21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block34
            // 
            this.Block34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block34.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block34.Location = new System.Drawing.Point(356, 393);
            this.Block34.Name = "Block34";
            this.Block34.Size = new System.Drawing.Size(92, 92);
            this.Block34.TabIndex = 17;
            this.Block34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block33
            // 
            this.Block33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block33.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block33.Location = new System.Drawing.Point(251, 393);
            this.Block33.Name = "Block33";
            this.Block33.Size = new System.Drawing.Size(92, 92);
            this.Block33.TabIndex = 16;
            this.Block33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block32
            // 
            this.Block32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block32.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block32.Location = new System.Drawing.Point(146, 393);
            this.Block32.Name = "Block32";
            this.Block32.Size = new System.Drawing.Size(92, 92);
            this.Block32.TabIndex = 15;
            this.Block32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block31
            // 
            this.Block31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block31.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block31.Location = new System.Drawing.Point(41, 393);
            this.Block31.Name = "Block31";
            this.Block31.Size = new System.Drawing.Size(92, 92);
            this.Block31.TabIndex = 14;
            this.Block31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block44
            // 
            this.Block44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block44.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block44.Location = new System.Drawing.Point(356, 497);
            this.Block44.Name = "Block44";
            this.Block44.Size = new System.Drawing.Size(92, 92);
            this.Block44.TabIndex = 21;
            this.Block44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block43
            // 
            this.Block43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block43.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block43.Location = new System.Drawing.Point(251, 497);
            this.Block43.Name = "Block43";
            this.Block43.Size = new System.Drawing.Size(92, 92);
            this.Block43.TabIndex = 20;
            this.Block43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block42
            // 
            this.Block42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block42.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block42.Location = new System.Drawing.Point(146, 497);
            this.Block42.Name = "Block42";
            this.Block42.Size = new System.Drawing.Size(92, 92);
            this.Block42.TabIndex = 19;
            this.Block42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block41
            // 
            this.Block41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.Block41.Font = new System.Drawing.Font("-윤고딕340", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Block41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.Block41.Location = new System.Drawing.Point(41, 497);
            this.Block41.Name = "Block41";
            this.Block41.Size = new System.Drawing.Size(92, 92);
            this.Block41.TabIndex = 18;
            this.Block41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(481, 628);
            this.Controls.Add(this.Block44);
            this.Controls.Add(this.Block43);
            this.Controls.Add(this.Block42);
            this.Controls.Add(this.Block41);
            this.Controls.Add(this.Block34);
            this.Controls.Add(this.Block33);
            this.Controls.Add(this.Block32);
            this.Controls.Add(this.Block31);
            this.Controls.Add(this.Block24);
            this.Controls.Add(this.Block23);
            this.Controls.Add(this.Block22);
            this.Controls.Add(this.Block21);
            this.Controls.Add(this.Block14);
            this.Controls.Add(this.Block13);
            this.Controls.Add(this.Block12);
            this.Controls.Add(this.Block11);
            this.Controls.Add(this.GaneBackGround);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.BestScoreBox);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.MainScore);
            this.Name = "Form1";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ScoreBox.ResumeLayout(false);
            this.BestScoreBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainScore;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.GroupBox BestScoreBox;
        private System.Windows.Forms.Label BestScoreText;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label GaneBackGround;
        private System.Windows.Forms.Label Block11;
        private System.Windows.Forms.Label Block12;
        private System.Windows.Forms.Label Block13;
        private System.Windows.Forms.Label Block14;
        private System.Windows.Forms.Label Block24;
        private System.Windows.Forms.Label Block23;
        private System.Windows.Forms.Label Block22;
        private System.Windows.Forms.Label Block21;
        private System.Windows.Forms.Label Block34;
        private System.Windows.Forms.Label Block33;
        private System.Windows.Forms.Label Block32;
        private System.Windows.Forms.Label Block31;
        private System.Windows.Forms.Label Block44;
        private System.Windows.Forms.Label Block43;
        private System.Windows.Forms.Label Block42;
        private System.Windows.Forms.Label Block41;
    }
}

