namespace TimeAssist
{
    partial class home
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
            newTask_btn = new Button();
            newFreeTime_btn = new Button();
            realTime_btn = new Button();
            timeTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)timeTable).BeginInit();
            SuspendLayout();
            // 
            // newTask_btn
            // 
            newTask_btn.Location = new Point(36, 33);
            newTask_btn.Margin = new Padding(2);
            newTask_btn.Name = "newTask_btn";
            newTask_btn.Size = new Size(164, 20);
            newTask_btn.TabIndex = 0;
            newTask_btn.Text = "Aufgabe eintragen";
            newTask_btn.UseVisualStyleBackColor = true;
            newTask_btn.Click += newTask_btn_Click;
            // 
            // newFreeTime_btn
            // 
            newFreeTime_btn.Location = new Point(36, 77);
            newFreeTime_btn.Margin = new Padding(2);
            newFreeTime_btn.Name = "newFreeTime_btn";
            newFreeTime_btn.Size = new Size(164, 20);
            newFreeTime_btn.TabIndex = 1;
            newFreeTime_btn.Text = "freie Zeit eintragen";
            newFreeTime_btn.UseVisualStyleBackColor = true;
            newFreeTime_btn.Click += newFreeTime_btn_Click;
            // 
            // realTime_btn
            // 
            realTime_btn.Location = new Point(36, 126);
            realTime_btn.Margin = new Padding(2);
            realTime_btn.Name = "realTime_btn";
            realTime_btn.Size = new Size(164, 20);
            realTime_btn.TabIndex = 2;
            realTime_btn.Text = "tatsächliche Zeit eintragen";
            realTime_btn.UseVisualStyleBackColor = true;
            realTime_btn.Click += realTime_btn_Click;
            // 
            // timeTable
            // 
            timeTable.AllowUserToAddRows = false;
            timeTable.AllowUserToDeleteRows = false;
            timeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timeTable.Location = new Point(223, 33);
            timeTable.Name = "timeTable";
            timeTable.ReadOnly = true;
            timeTable.RowTemplate.Height = 25;
            timeTable.Size = new Size(546, 150);
            timeTable.TabIndex = 3;
            timeTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 270);
            Controls.Add(timeTable);
            Controls.Add(realTime_btn);
            Controls.Add(newFreeTime_btn);
            Controls.Add(newTask_btn);
            Margin = new Padding(2);
            Name = "home";
            Text = "Form1";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)timeTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button newTask_btn;
        private Button newFreeTime_btn;
        private Button realTime_btn;
        private DataGridView timeTable;
    }
}
