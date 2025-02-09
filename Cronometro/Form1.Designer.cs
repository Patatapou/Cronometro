namespace Cronometro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            TIEMPO = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TIMER = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // TIEMPO
            // 
            TIEMPO.AutoSize = true;
            TIEMPO.BackColor = Color.Linen;
            TIEMPO.BorderStyle = BorderStyle.Fixed3D;
            TIEMPO.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TIEMPO.Location = new Point(224, 166);
            TIEMPO.Name = "TIEMPO";
            TIEMPO.Size = new Size(360, 95);
            TIEMPO.TabIndex = 0;
            TIEMPO.Text = "00:00:00";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button1.Location = new Point(176, 299);
            button1.Name = "button1";
            button1.Size = new Size(145, 39);
            button1.TabIndex = 1;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button2.Location = new Point(327, 299);
            button2.Name = "button2";
            button2.Size = new Size(145, 39);
            button2.TabIndex = 2;
            button2.Text = "DETENER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button3.Location = new Point(478, 299);
            button3.Name = "button3";
            button3.Size = new Size(145, 39);
            button3.TabIndex = 3;
            button3.Text = "RESETEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TIMER
            // 
            TIMER.Interval = 1000;
            TIMER.Tick += SEGUNDOS_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(756, 85);
            label1.TabIndex = 4;
            label1.Text = "CRONOMETRO CHIDO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(779, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TIEMPO);
            Name = "Form1";
            Text = "CronometroChido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TIEMPO;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer TIMER;
        private Label label1;
    }
}
