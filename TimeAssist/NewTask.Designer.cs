namespace TimeAssist
{
    partial class NewTask
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
            task_text = new TextBox();
            task_label = new Label();
            estimatedTime_label = new Label();
            estimatedTime_text = new TextBox();
            createTask_btn = new Button();
            chancel_btn = new Button();
            SuspendLayout();
            // 
            // task_text
            // 
            task_text.Location = new Point(8, 28);
            task_text.Margin = new Padding(2, 2, 2, 2);
            task_text.Multiline = true;
            task_text.Name = "task_text";
            task_text.Size = new Size(162, 36);
            task_text.TabIndex = 0;
            // 
            // task_label
            // 
            task_label.AutoSize = true;
            task_label.Location = new Point(8, 11);
            task_label.Margin = new Padding(2, 0, 2, 0);
            task_label.Name = "task_label";
            task_label.Size = new Size(152, 15);
            task_label.TabIndex = 1;
            task_label.Text = "Notiere hier deine Aufgabe.";
            // 
            // estimatedTime_label
            // 
            estimatedTime_label.AutoSize = true;
            estimatedTime_label.Location = new Point(8, 82);
            estimatedTime_label.Margin = new Padding(2, 0, 2, 0);
            estimatedTime_label.Name = "estimatedTime_label";
            estimatedTime_label.Size = new Size(150, 15);
            estimatedTime_label.TabIndex = 2;
            estimatedTime_label.Text = "geschätzte Zeit in Minuten.";
            // 
            // estimatedTime_text
            // 
            estimatedTime_text.Location = new Point(8, 98);
            estimatedTime_text.Margin = new Padding(2, 2, 2, 2);
            estimatedTime_text.Name = "estimatedTime_text";
            estimatedTime_text.Size = new Size(123, 23);
            estimatedTime_text.TabIndex = 3;
            // 
            // createTask_btn
            // 
            createTask_btn.Location = new Point(8, 144);
            createTask_btn.Margin = new Padding(2, 2, 2, 2);
            createTask_btn.Name = "createTask_btn";
            createTask_btn.Size = new Size(122, 20);
            createTask_btn.TabIndex = 4;
            createTask_btn.Text = "Aufgabe erstellen";
            createTask_btn.UseVisualStyleBackColor = true;
            createTask_btn.Click += createTask_btn_Click;
            // 
            // chancel_btn
            // 
            chancel_btn.Location = new Point(135, 144);
            chancel_btn.Name = "chancel_btn";
            chancel_btn.Size = new Size(75, 23);
            chancel_btn.TabIndex = 5;
            chancel_btn.Text = "abbrechen";
            chancel_btn.UseVisualStyleBackColor = true;
            chancel_btn.Click += chancel_btn_Click;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(chancel_btn);
            Controls.Add(createTask_btn);
            Controls.Add(estimatedTime_text);
            Controls.Add(estimatedTime_label);
            Controls.Add(task_label);
            Controls.Add(task_text);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewTask";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox task_text;
        private Label task_label;
        private Label estimatedTime_label;
        private TextBox estimatedTime_text;
        private Button createTask_btn;
        private Button chancel_btn;
    }
}