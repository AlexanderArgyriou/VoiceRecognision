namespace VoiceRec
{
    partial class VoiceRecognitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceRecognitionForm));
            this.TBox = new System.Windows.Forms.RichTextBox();
            this.Enable = new System.Windows.Forms.Button();
            this.Disable = new System.Windows.Forms.Button();
            this.TextRadio = new System.Windows.Forms.RadioButton();
            this.VoiceRadio = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TrainButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(3, 3);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(297, 253);
            this.TBox.TabIndex = 0;
            this.TBox.Text = "";
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(3, 262);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(125, 23);
            this.Enable.TabIndex = 1;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Disable
            // 
            this.Disable.Location = new System.Drawing.Point(3, 291);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(125, 23);
            this.Disable.TabIndex = 2;
            this.Disable.Text = "Disable";
            this.Disable.UseVisualStyleBackColor = true;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // TextRadio
            // 
            this.TextRadio.AutoSize = true;
            this.TextRadio.Checked = true;
            this.TextRadio.Location = new System.Drawing.Point(134, 262);
            this.TextRadio.Name = "TextRadio";
            this.TextRadio.Size = new System.Drawing.Size(76, 17);
            this.TextRadio.TabIndex = 3;
            this.TextRadio.TabStop = true;
            this.TextRadio.Text = "Text Reply";
            this.TextRadio.UseVisualStyleBackColor = true;
            // 
            // VoiceRadio
            // 
            this.VoiceRadio.AutoSize = true;
            this.VoiceRadio.Location = new System.Drawing.Point(134, 291);
            this.VoiceRadio.Name = "VoiceRadio";
            this.VoiceRadio.Size = new System.Drawing.Size(82, 17);
            this.VoiceRadio.TabIndex = 4;
            this.VoiceRadio.Text = "Voice Reply";
            this.VoiceRadio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TBox);
            this.flowLayoutPanel1.Controls.Add(this.Enable);
            this.flowLayoutPanel1.Controls.Add(this.TextRadio);
            this.flowLayoutPanel1.Controls.Add(this.Disable);
            this.flowLayoutPanel1.Controls.Add(this.VoiceRadio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 327);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(3, 3);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(100, 23);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(3, 32);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(247, 20);
            this.Question.TabIndex = 7;
            this.Question.Text = "Command";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(3, 58);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(247, 20);
            this.Answer.TabIndex = 8;
            this.Answer.Text = "Answer";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.TrainButton);
            this.flowLayoutPanel2.Controls.Add(this.Question);
            this.flowLayoutPanel2.Controls.Add(this.Answer);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(324, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 100);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // VoiceRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoiceRecognitionForm";
            this.Text = "SpeechApp";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TBox;
        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.RadioButton TextRadio;
        private System.Windows.Forms.RadioButton VoiceRadio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

