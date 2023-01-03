namespace math_game_4kids
{
    partial class GameForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.buttonIKnow = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.timerRound = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperation.Location = new System.Drawing.Point(220, 340);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(411, 106);
            this.labelOperation.TabIndex = 1;
            this.labelOperation.Text = "10 + 99 = ";
            // 
            // buttonIKnow
            // 
            this.buttonIKnow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIKnow.Location = new System.Drawing.Point(382, 472);
            this.buttonIKnow.Name = "buttonIKnow";
            this.buttonIKnow.Size = new System.Drawing.Size(131, 61);
            this.buttonIKnow.TabIndex = 2;
            this.buttonIKnow.Text = "Tudom!";
            this.buttonIKnow.UseVisualStyleBackColor = true;
            this.buttonIKnow.Click += new System.EventHandler(this.buttonIKnow_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContinue.Location = new System.Drawing.Point(693, 515);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(161, 40);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Következő";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // timerRound
            // 
            this.timerRound.Interval = 400;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 567);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonIKnow);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameForm";
            this.Text = "Játék";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelOperation;
        private Button buttonIKnow;
        private Button buttonContinue;
        private System.Windows.Forms.Timer timerRound;
    }
}