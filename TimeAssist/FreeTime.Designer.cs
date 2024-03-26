namespace TimeAssist
{
    partial class FreeTime
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
            setFreeTime_label = new Label();
            setFreeTime_btn = new Button();
            freeTimeMin_label = new Label();
            dayFreeTime_label = new Label();
            freeTimeMin_text = new TextBox();
            dayOfWeek_drop = new ComboBox();
            chancel_btn = new Button();
            SuspendLayout();
            // 
            // setFreeTime_label
            // 
            setFreeTime_label.AutoSize = true;
            setFreeTime_label.Location = new Point(18, 141);
            setFreeTime_label.Margin = new Padding(2, 0, 2, 0);
            setFreeTime_label.Name = "setFreeTime_label";
            setFreeTime_label.Size = new Size(109, 15);
            setFreeTime_label.TabIndex = 12;
            setFreeTime_label.Text = "freie Zeit eintragen.";
            // 
            // setFreeTime_btn
            // 
            setFreeTime_btn.Location = new Point(18, 158);
            setFreeTime_btn.Margin = new Padding(2, 2, 2, 2);
            setFreeTime_btn.Name = "setFreeTime_btn";
            setFreeTime_btn.Size = new Size(78, 20);
            setFreeTime_btn.TabIndex = 11;
            setFreeTime_btn.Text = "bestätigen";
            setFreeTime_btn.UseVisualStyleBackColor = true;
            setFreeTime_btn.Click += setFreeTime_btn_Click;
            // 
            // freeTimeMin_label
            // 
            freeTimeMin_label.AutoSize = true;
            freeTimeMin_label.Location = new Point(18, 74);
            freeTimeMin_label.Margin = new Padding(2, 0, 2, 0);
            freeTimeMin_label.Name = "freeTimeMin_label";
            freeTimeMin_label.Size = new Size(231, 15);
            freeTimeMin_label.TabIndex = 10;
            freeTimeMin_label.Text = "Gib an wie viele Minuten du freie Zeit hast.";
            // 
            // dayFreeTime_label
            // 
            dayFreeTime_label.AutoSize = true;
            dayFreeTime_label.Location = new Point(18, 19);
            dayFreeTime_label.Margin = new Padding(2, 0, 2, 0);
            dayFreeTime_label.Name = "dayFreeTime_label";
            dayFreeTime_label.Size = new Size(221, 15);
            dayFreeTime_label.TabIndex = 9;
            dayFreeTime_label.Text = "Wähle den Tag an dem du freie Zeit hast.";
            // 
            // freeTimeMin_text
            // 
            freeTimeMin_text.Location = new Point(18, 91);
            freeTimeMin_text.Margin = new Padding(2, 2, 2, 2);
            freeTimeMin_text.Name = "freeTimeMin_text";
            freeTimeMin_text.Size = new Size(106, 23);
            freeTimeMin_text.TabIndex = 8;
            // 
            // dayOfWeek_drop
            // 
            dayOfWeek_drop.DisplayMember = "Text";
            dayOfWeek_drop.FormattingEnabled = true;
            dayOfWeek_drop.Items.AddRange(new object[] { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" });
            dayOfWeek_drop.Location = new Point(18, 35);
            dayOfWeek_drop.Margin = new Padding(2, 2, 2, 2);
            dayOfWeek_drop.Name = "dayOfWeek_drop";
            dayOfWeek_drop.Size = new Size(129, 23);
            dayOfWeek_drop.TabIndex = 7;
            // 
            // chancel_btn
            // 
            chancel_btn.Location = new Point(101, 157);
            chancel_btn.Name = "chancel_btn";
            chancel_btn.Size = new Size(75, 23);
            chancel_btn.TabIndex = 13;
            chancel_btn.Text = "abbrechen";
            chancel_btn.UseVisualStyleBackColor = true;
            chancel_btn.Click += chancel_btn_Click;
            // 
            // FreeTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(chancel_btn);
            Controls.Add(setFreeTime_label);
            Controls.Add(setFreeTime_btn);
            Controls.Add(freeTimeMin_label);
            Controls.Add(dayFreeTime_label);
            Controls.Add(freeTimeMin_text);
            Controls.Add(dayOfWeek_drop);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FreeTime";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label setFreeTime_label;
        private Button setFreeTime_btn;
        private Label freeTimeMin_label;
        private Label dayFreeTime_label;
        private TextBox freeTimeMin_text;
        private ComboBox dayOfWeek_drop;
        private Button chancel_btn;
    }
}