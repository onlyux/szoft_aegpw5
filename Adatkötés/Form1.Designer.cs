namespace Adatkötés
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
            dataGridView1 = new DataGridView();
            buttonMegnyitás = new Button();
            buttonTörlés = new Button();
            buttonSzerkesztés = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(950, 351);
            dataGridView1.TabIndex = 0;
            // 
            // buttonMegnyitás
            // 
            buttonMegnyitás.Location = new Point(892, 57);
            buttonMegnyitás.Name = "buttonMegnyitás";
            buttonMegnyitás.Size = new Size(121, 50);
            buttonMegnyitás.TabIndex = 1;
            buttonMegnyitás.Text = "Megnyitás";
            buttonMegnyitás.UseVisualStyleBackColor = true;
            buttonMegnyitás.Click += buttonMegnyitás_Click;
            // 
            // buttonTörlés
            // 
            buttonTörlés.Location = new Point(793, 547);
            buttonTörlés.Name = "buttonTörlés";
            buttonTörlés.Size = new Size(90, 32);
            buttonTörlés.TabIndex = 2;
            buttonTörlés.Text = "Törlés";
            buttonTörlés.UseVisualStyleBackColor = true;
            // 
            // buttonSzerkesztés
            // 
            buttonSzerkesztés.Location = new Point(921, 547);
            buttonSzerkesztés.Name = "buttonSzerkesztés";
            buttonSzerkesztés.Size = new Size(92, 32);
            buttonSzerkesztés.TabIndex = 3;
            buttonSzerkesztés.Text = "Szerkesztés";
            buttonSzerkesztés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 638);
            Controls.Add(buttonSzerkesztés);
            Controls.Add(buttonTörlés);
            Controls.Add(buttonMegnyitás);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonMegnyitás;
        private Button buttonTörlés;
        private Button buttonSzerkesztés;
    }
}