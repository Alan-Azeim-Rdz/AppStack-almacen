namespace AppStack_almacen
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
            btnPush = new Button();
            txtData = new TextBox();
            btnPop = new Button();
            btnPeek = new Button();
            lstPila = new ListBox();
            label1 = new Label();
            BtnSize = new Button();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Location = new Point(103, 118);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(126, 53);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // txtDato
            // 
            txtData.Location = new Point(145, 41);
            txtData.Name = "txtData";
            txtData.Size = new Size(156, 23);
            txtData.TabIndex = 1;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(103, 195);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(126, 53);
            btnPop.TabIndex = 2;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(103, 275);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(126, 53);
            btnPeek.TabIndex = 3;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // lstPila
            // 
            lstPila.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstPila.FormattingEnabled = true;
            lstPila.ItemHeight = 42;
            lstPila.Location = new Point(485, 11);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(453, 424);
            lstPila.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Dato a insertar:";
            // 
            // BtnSize
            // 
            BtnSize.Location = new Point(103, 354);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(126, 53);
            BtnSize.TabIndex = 6;
            BtnSize.Text = "Size";
            BtnSize.UseVisualStyleBackColor = true;
            BtnSize.Click += BtnSize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(BtnSize);
            Controls.Add(label1);
            Controls.Add(lstPila);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(txtData);
            Controls.Add(btnPush);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPush;
        private TextBox txtData;
        private Button btnPop;
        private Button btnPeek;
        private ListBox lstPila;
        private Label label1;
        private Button BtnSize;
    }
}
