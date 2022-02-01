
namespace System
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.txt_amountpaid = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.txt_change);
            this.panel1.Controls.Add(this.txt_amountpaid);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.txt_itemname);
            this.panel1.Controls.Add(this.txt_itemid);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 581);
            this.panel1.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Purple;
            this.panel10.Location = new System.Drawing.Point(171, 512);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(109, 8);
            this.panel10.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Change :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount Paid:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Purple;
            this.panel9.Location = new System.Drawing.Point(171, 298);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(102, 8);
            this.panel9.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item ID :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Purple;
            this.panel8.Location = new System.Drawing.Point(330, 321);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 174);
            this.panel8.TabIndex = 19;
            // 
            // txt_change
            // 
            this.txt_change.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_change.Location = new System.Drawing.Point(150, 220);
            this.txt_change.Margin = new System.Windows.Forms.Padding(2);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(271, 32);
            this.txt_change.TabIndex = 18;
            this.txt_change.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemid_KeyPress);
            // 
            // txt_amountpaid
            // 
            this.txt_amountpaid.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountpaid.Location = new System.Drawing.Point(150, 166);
            this.txt_amountpaid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amountpaid.Name = "txt_amountpaid";
            this.txt_amountpaid.Size = new System.Drawing.Size(271, 32);
            this.txt_amountpaid.TabIndex = 17;
            this.txt_amountpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemid_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Purple;
            this.panel7.Location = new System.Drawing.Point(108, 321);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 174);
            this.panel7.TabIndex = 18;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Purple;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(46, 492);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(128, 45);
            this.btn_remove.TabIndex = 17;
            this.btn_remove.Text = "&Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(150, 115);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(271, 32);
            this.txt_itemname.TabIndex = 16;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(150, 64);
            this.txt_itemid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(271, 32);
            this.txt_itemid.TabIndex = 15;
            this.txt_itemid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemid_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Purple;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(272, 278);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 45);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Modifier";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(97, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mini Cashiering System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 328);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Purple;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(46, 279);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(128, 45);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "&Ajouter";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(272, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(439, 231);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panel1;
        private Windows.Forms.Panel panel10;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Windows.Forms.Panel panel9;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.Panel panel8;
        private Windows.Forms.TextBox txt_change;
        private Windows.Forms.TextBox txt_amountpaid;
        private Windows.Forms.Panel panel7;
        private Windows.Forms.Button btn_remove;
        private Windows.Forms.TextBox txt_itemname;
        private Windows.Forms.TextBox txt_itemid;
        private Windows.Forms.Button btn_clear;
        private Windows.Forms.Label label5;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.Button btn_print;
        private Windows.Forms.Button button1;
        private Windows.Forms.DataGridView dataGridView1;
    }
}

