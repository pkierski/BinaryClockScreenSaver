namespace BinaryClockScreenSaver
{
    partial class ScreenSaverForm
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
            if(disposing && (components != null))
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
            this.textLabel = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelS32 = new System.Windows.Forms.Label();
            this.labelS16 = new System.Windows.Forms.Label();
            this.labelS4 = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.labelS8 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.labelM1 = new System.Windows.Forms.Label();
            this.labelM2 = new System.Windows.Forms.Label();
            this.labelM4 = new System.Windows.Forms.Label();
            this.labelM8 = new System.Windows.Forms.Label();
            this.labelM16 = new System.Windows.Forms.Label();
            this.labelH1 = new System.Windows.Forms.Label();
            this.labelH2 = new System.Windows.Forms.Label();
            this.labelH4 = new System.Windows.Forms.Label();
            this.labelH8 = new System.Windows.Forms.Label();
            this.labelH16 = new System.Windows.Forms.Label();
            this.labelM32 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.Red;
            this.textLabel.Location = new System.Drawing.Point(25, 58);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(466, 55);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Hello, Screen Saver!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.labelS32, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelS16, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelS4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelS1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelS8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelS2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelM1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelM2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelM4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelM8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelM16, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelH1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelH2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelH4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelH8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelH16, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelM32, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(138, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 213);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelS32
            // 
            this.labelS32.AutoSize = true;
            this.labelS32.BackColor = System.Drawing.Color.Transparent;
            this.labelS32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS32.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS32.ForeColor = System.Drawing.Color.Red;
            this.labelS32.Location = new System.Drawing.Point(0, 142);
            this.labelS32.Margin = new System.Windows.Forms.Padding(0);
            this.labelS32.Name = "labelS32";
            this.labelS32.Size = new System.Drawing.Size(58, 71);
            this.labelS32.TabIndex = 16;
            this.labelS32.Text = "0";
            this.labelS32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS16
            // 
            this.labelS16.AutoSize = true;
            this.labelS16.BackColor = System.Drawing.Color.Transparent;
            this.labelS16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS16.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS16.ForeColor = System.Drawing.Color.Red;
            this.labelS16.Location = new System.Drawing.Point(58, 142);
            this.labelS16.Margin = new System.Windows.Forms.Padding(0);
            this.labelS16.Name = "labelS16";
            this.labelS16.Size = new System.Drawing.Size(58, 71);
            this.labelS16.TabIndex = 14;
            this.labelS16.Text = "0";
            this.labelS16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS4
            // 
            this.labelS4.AutoSize = true;
            this.labelS4.BackColor = System.Drawing.Color.Transparent;
            this.labelS4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS4.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS4.ForeColor = System.Drawing.Color.Red;
            this.labelS4.Location = new System.Drawing.Point(174, 142);
            this.labelS4.Margin = new System.Windows.Forms.Padding(0);
            this.labelS4.Name = "labelS4";
            this.labelS4.Size = new System.Drawing.Size(58, 71);
            this.labelS4.TabIndex = 13;
            this.labelS4.Text = "0";
            this.labelS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.BackColor = System.Drawing.Color.Transparent;
            this.labelS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS1.ForeColor = System.Drawing.Color.Red;
            this.labelS1.Location = new System.Drawing.Point(290, 142);
            this.labelS1.Margin = new System.Windows.Forms.Padding(0);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(63, 71);
            this.labelS1.TabIndex = 12;
            this.labelS1.Text = "0";
            this.labelS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS8
            // 
            this.labelS8.AutoSize = true;
            this.labelS8.BackColor = System.Drawing.Color.Transparent;
            this.labelS8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS8.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS8.ForeColor = System.Drawing.Color.Red;
            this.labelS8.Location = new System.Drawing.Point(116, 142);
            this.labelS8.Margin = new System.Windows.Forms.Padding(0);
            this.labelS8.Name = "labelS8";
            this.labelS8.Size = new System.Drawing.Size(58, 71);
            this.labelS8.TabIndex = 11;
            this.labelS8.Text = "0";
            this.labelS8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.BackColor = System.Drawing.Color.Transparent;
            this.labelS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelS2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelS2.ForeColor = System.Drawing.Color.Red;
            this.labelS2.Location = new System.Drawing.Point(232, 142);
            this.labelS2.Margin = new System.Windows.Forms.Padding(0);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(58, 71);
            this.labelS2.TabIndex = 10;
            this.labelS2.Text = "0";
            this.labelS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.BackColor = System.Drawing.Color.Transparent;
            this.labelM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM1.ForeColor = System.Drawing.Color.Red;
            this.labelM1.Location = new System.Drawing.Point(290, 71);
            this.labelM1.Margin = new System.Windows.Forms.Padding(0);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(63, 71);
            this.labelM1.TabIndex = 9;
            this.labelM1.Text = "0";
            this.labelM1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.BackColor = System.Drawing.Color.Transparent;
            this.labelM2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM2.ForeColor = System.Drawing.Color.Red;
            this.labelM2.Location = new System.Drawing.Point(232, 71);
            this.labelM2.Margin = new System.Windows.Forms.Padding(0);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(58, 71);
            this.labelM2.TabIndex = 8;
            this.labelM2.Text = "0";
            this.labelM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM4
            // 
            this.labelM4.AutoSize = true;
            this.labelM4.BackColor = System.Drawing.Color.Transparent;
            this.labelM4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM4.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM4.ForeColor = System.Drawing.Color.Red;
            this.labelM4.Location = new System.Drawing.Point(174, 71);
            this.labelM4.Margin = new System.Windows.Forms.Padding(0);
            this.labelM4.Name = "labelM4";
            this.labelM4.Size = new System.Drawing.Size(58, 71);
            this.labelM4.TabIndex = 7;
            this.labelM4.Text = "0";
            this.labelM4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM8
            // 
            this.labelM8.AutoSize = true;
            this.labelM8.BackColor = System.Drawing.Color.Transparent;
            this.labelM8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM8.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM8.ForeColor = System.Drawing.Color.Red;
            this.labelM8.Location = new System.Drawing.Point(116, 71);
            this.labelM8.Margin = new System.Windows.Forms.Padding(0);
            this.labelM8.Name = "labelM8";
            this.labelM8.Size = new System.Drawing.Size(58, 71);
            this.labelM8.TabIndex = 6;
            this.labelM8.Text = "0";
            this.labelM8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM16
            // 
            this.labelM16.AutoSize = true;
            this.labelM16.BackColor = System.Drawing.Color.Transparent;
            this.labelM16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM16.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM16.ForeColor = System.Drawing.Color.Red;
            this.labelM16.Location = new System.Drawing.Point(58, 71);
            this.labelM16.Margin = new System.Windows.Forms.Padding(0);
            this.labelM16.Name = "labelM16";
            this.labelM16.Size = new System.Drawing.Size(58, 71);
            this.labelM16.TabIndex = 5;
            this.labelM16.Text = "0";
            this.labelM16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH1
            // 
            this.labelH1.AutoSize = true;
            this.labelH1.BackColor = System.Drawing.Color.Transparent;
            this.labelH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH1.ForeColor = System.Drawing.Color.Red;
            this.labelH1.Location = new System.Drawing.Point(290, 0);
            this.labelH1.Margin = new System.Windows.Forms.Padding(0);
            this.labelH1.Name = "labelH1";
            this.labelH1.Size = new System.Drawing.Size(63, 71);
            this.labelH1.TabIndex = 4;
            this.labelH1.Text = "0";
            this.labelH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH2
            // 
            this.labelH2.AutoSize = true;
            this.labelH2.BackColor = System.Drawing.Color.Transparent;
            this.labelH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH2.ForeColor = System.Drawing.Color.Red;
            this.labelH2.Location = new System.Drawing.Point(232, 0);
            this.labelH2.Margin = new System.Windows.Forms.Padding(0);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(58, 71);
            this.labelH2.TabIndex = 3;
            this.labelH2.Text = "0";
            this.labelH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH4
            // 
            this.labelH4.AutoSize = true;
            this.labelH4.BackColor = System.Drawing.Color.Transparent;
            this.labelH4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH4.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH4.ForeColor = System.Drawing.Color.Red;
            this.labelH4.Location = new System.Drawing.Point(174, 0);
            this.labelH4.Margin = new System.Windows.Forms.Padding(0);
            this.labelH4.Name = "labelH4";
            this.labelH4.Size = new System.Drawing.Size(58, 71);
            this.labelH4.TabIndex = 2;
            this.labelH4.Text = "0";
            this.labelH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH8
            // 
            this.labelH8.AutoSize = true;
            this.labelH8.BackColor = System.Drawing.Color.Transparent;
            this.labelH8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH8.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH8.ForeColor = System.Drawing.Color.Red;
            this.labelH8.Location = new System.Drawing.Point(116, 0);
            this.labelH8.Margin = new System.Windows.Forms.Padding(0);
            this.labelH8.Name = "labelH8";
            this.labelH8.Size = new System.Drawing.Size(58, 71);
            this.labelH8.TabIndex = 1;
            this.labelH8.Text = "0";
            this.labelH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH16
            // 
            this.labelH16.AutoSize = true;
            this.labelH16.BackColor = System.Drawing.Color.Transparent;
            this.labelH16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH16.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH16.ForeColor = System.Drawing.Color.Red;
            this.labelH16.Location = new System.Drawing.Point(58, 0);
            this.labelH16.Margin = new System.Windows.Forms.Padding(0);
            this.labelH16.Name = "labelH16";
            this.labelH16.Size = new System.Drawing.Size(58, 71);
            this.labelH16.TabIndex = 0;
            this.labelH16.Text = "0";
            this.labelH16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM32
            // 
            this.labelM32.AutoSize = true;
            this.labelM32.BackColor = System.Drawing.Color.Transparent;
            this.labelM32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelM32.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelM32.ForeColor = System.Drawing.Color.Red;
            this.labelM32.Location = new System.Drawing.Point(0, 71);
            this.labelM32.Margin = new System.Windows.Forms.Padding(0);
            this.labelM32.Name = "labelM32";
            this.labelM32.Size = new System.Drawing.Size(58, 71);
            this.labelM32.TabIndex = 15;
            this.labelM32.Text = "0";
            this.labelM32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelH16;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label labelH4;
        private System.Windows.Forms.Label labelH8;
        private System.Windows.Forms.Label labelS32;
        private System.Windows.Forms.Label labelS16;
        private System.Windows.Forms.Label labelS4;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.Label labelS8;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label labelM4;
        private System.Windows.Forms.Label labelM8;
        private System.Windows.Forms.Label labelM16;
        private System.Windows.Forms.Label labelM32;
    }
}

