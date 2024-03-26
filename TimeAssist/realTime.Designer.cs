namespace TimeAssist
{
    partial class realTime
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
            taskId_label = new Label();
            realTime_label = new Label();
            taskId_text = new TextBox();
            realTime_text = new TextBox();
            confirm_btn = new Button();
            chancel_btn = new Button();
            SuspendLayout();
            // 
            // taskId_label
            // 
            taskId_label.AutoSize = true;
            taskId_label.Location = new Point(12, 28);
            taskId_label.Name = "taskId_label";
            taskId_label.Size = new Size(308, 15);
            taskId_label.TabIndex = 0;
            taskId_label.Text = "Für welche Aufgaben Nr. möchtest du die Zeit eintragen?";
            // 
            // realTime_label
            // 
            realTime_label.AutoSize = true;
            realTime_label.Location = new Point(12, 92);
            realTime_label.Name = "realTime_label";
            realTime_label.Size = new Size(245, 15);
            realTime_label.TabIndex = 1;
            realTime_label.Text = "Wie viel war deine benötigte Zeit in Minuten?";
            // 
            // taskId_text
            // 
            taskId_text.Location = new Point(12, 46);
            taskId_text.Name = "taskId_text";
            taskId_text.Size = new Size(100, 23);
            taskId_text.TabIndex = 2;
            // 
            // realTime_text
            // 
            realTime_text.Location = new Point(12, 110);
            realTime_text.Name = "realTime_text";
            realTime_text.Size = new Size(100, 23);
            realTime_text.TabIndex = 3;
            // 
            // confirm_btn
            // 
            confirm_btn.Location = new Point(12, 178);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(75, 23);
            confirm_btn.TabIndex = 4;
            confirm_btn.Text = "bestätigen";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // chancel_btn
            // 
            chancel_btn.Location = new Point(93, 178);
            chancel_btn.Name = "chancel_btn";
            chancel_btn.Size = new Size(75, 23);
            chancel_btn.TabIndex = 5;
            chancel_btn.Text = "abbrechen";
            chancel_btn.UseVisualStyleBackColor = true;
            chancel_btn.Click += chancel_btn_Click;
            // 
            // realTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 226);
            Controls.Add(chancel_btn);
            Controls.Add(confirm_btn);
            Controls.Add(realTime_text);
            Controls.Add(taskId_text);
            Controls.Add(realTime_label);
            Controls.Add(taskId_label);
            Name = "realTime";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskId_label;
        private Label realTime_label;
        private TextBox taskId_text;
        private TextBox realTime_text;
        private Button confirm_btn;
        private Button chancel_btn;
    }
}