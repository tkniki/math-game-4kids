namespace math_game_4kids
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.radioButton_Easy = new System.Windows.Forms.RadioButton();
            this.radioButton_Medium = new System.Windows.Forms.RadioButton();
            this.radioButton_Hard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 289);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(630, 378);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 45);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(520, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szia! Add meg a neved:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(554, 125);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(176, 27);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // radioButton_Easy
            // 
            this.radioButton_Easy.AutoSize = true;
            this.radioButton_Easy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton_Easy.Location = new System.Drawing.Point(589, 222);
            this.radioButton_Easy.Name = "radioButton_Easy";
            this.radioButton_Easy.Size = new System.Drawing.Size(103, 32);
            this.radioButton_Easy.TabIndex = 4;
            this.radioButton_Easy.TabStop = true;
            this.radioButton_Easy.Text = "Könnyű";
            this.radioButton_Easy.UseVisualStyleBackColor = true;
            // 
            // radioButton_Medium
            // 
            this.radioButton_Medium.AutoSize = true;
            this.radioButton_Medium.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton_Medium.Location = new System.Drawing.Point(587, 260);
            this.radioButton_Medium.Name = "radioButton_Medium";
            this.radioButton_Medium.Size = new System.Drawing.Size(105, 32);
            this.radioButton_Medium.TabIndex = 5;
            this.radioButton_Medium.TabStop = true;
            this.radioButton_Medium.Text = "Közepes";
            this.radioButton_Medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hard
            // 
            this.radioButton_Hard.AutoSize = true;
            this.radioButton_Hard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton_Hard.Location = new System.Drawing.Point(587, 298);
            this.radioButton_Hard.Name = "radioButton_Hard";
            this.radioButton_Hard.Size = new System.Drawing.Size(89, 32);
            this.radioButton_Hard.TabIndex = 6;
            this.radioButton_Hard.TabStop = true;
            this.radioButton_Hard.Text = "Nehéz";
            this.radioButton_Hard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(554, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nehézségi szint:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_Hard);
            this.Controls.Add(this.radioButton_Medium);
            this.Controls.Add(this.radioButton_Easy);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartForm";
            this.Text = "Számolós Játék - Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonStart;
        private Label label1;
        private TextBox nameBox;
        private RadioButton radioButton_Easy;
        private RadioButton radioButton_Medium;
        private RadioButton radioButton_Hard;
        private Label label2;
    }
}