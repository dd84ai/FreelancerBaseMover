namespace FreelancerBaseMover
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1_fileaddress = new System.Windows.Forms.TextBox();
            this.label1_fileaddress = new System.Windows.Forms.Label();
            this.button1_process = new System.Windows.Forms.Button();
            this.textBox1_xpos = new System.Windows.Forms.TextBox();
            this.label1_X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_ypos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_zpos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_zrot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_yrot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1_xrot = new System.Windows.Forms.TextBox();
            this.button1_create_file = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1_zmot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_ymot = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1_xmot = new System.Windows.Forms.TextBox();
            this.checkBox1_mot = new System.Windows.Forms.CheckBox();
            this.checkBox1_position = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1_fileaddress
            // 
            this.textBox1_fileaddress.Location = new System.Drawing.Point(12, 43);
            this.textBox1_fileaddress.Name = "textBox1_fileaddress";
            this.textBox1_fileaddress.Size = new System.Drawing.Size(602, 20);
            this.textBox1_fileaddress.TabIndex = 0;
            this.textBox1_fileaddress.Text = "a.txt";
            // 
            // label1_fileaddress
            // 
            this.label1_fileaddress.AutoSize = true;
            this.label1_fileaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_fileaddress.Location = new System.Drawing.Point(8, 9);
            this.label1_fileaddress.Name = "label1_fileaddress";
            this.label1_fileaddress.Size = new System.Drawing.Size(99, 20);
            this.label1_fileaddress.TabIndex = 1;
            this.label1_fileaddress.Text = "File address:";
            // 
            // button1_process
            // 
            this.button1_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_process.Location = new System.Drawing.Point(368, 299);
            this.button1_process.Name = "button1_process";
            this.button1_process.Size = new System.Drawing.Size(201, 34);
            this.button1_process.TabIndex = 2;
            this.button1_process.Text = "Change the same file";
            this.button1_process.UseVisualStyleBackColor = true;
            this.button1_process.Click += new System.EventHandler(this.button1_process_Click);
            // 
            // textBox1_xpos
            // 
            this.textBox1_xpos.Location = new System.Drawing.Point(43, 105);
            this.textBox1_xpos.Name = "textBox1_xpos";
            this.textBox1_xpos.Size = new System.Drawing.Size(125, 20);
            this.textBox1_xpos.TabIndex = 3;
            this.textBox1_xpos.Text = "0";
            // 
            // label1_X
            // 
            this.label1_X.AutoSize = true;
            this.label1_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_X.Location = new System.Drawing.Point(17, 105);
            this.label1_X.Name = "label1_X";
            this.label1_X.Size = new System.Drawing.Size(20, 20);
            this.label1_X.TabIndex = 4;
            this.label1_X.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Y";
            // 
            // textBox1_ypos
            // 
            this.textBox1_ypos.Location = new System.Drawing.Point(219, 105);
            this.textBox1_ypos.Name = "textBox1_ypos";
            this.textBox1_ypos.Size = new System.Drawing.Size(125, 20);
            this.textBox1_ypos.TabIndex = 5;
            this.textBox1_ypos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Z";
            // 
            // textBox1_zpos
            // 
            this.textBox1_zpos.Location = new System.Drawing.Point(389, 105);
            this.textBox1_zpos.Name = "textBox1_zpos";
            this.textBox1_zpos.Size = new System.Drawing.Size(125, 20);
            this.textBox1_zpos.TabIndex = 7;
            this.textBox1_zpos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "New position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(113, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Insert file address to process, for example \"a.txt\" or \"C:\\BaseMover\\a.txt\")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rotation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(364, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Z";
            // 
            // textBox1_zrot
            // 
            this.textBox1_zrot.Location = new System.Drawing.Point(389, 177);
            this.textBox1_zrot.Name = "textBox1_zrot";
            this.textBox1_zrot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_zrot.TabIndex = 15;
            this.textBox1_zrot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(193, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Y";
            // 
            // textBox1_yrot
            // 
            this.textBox1_yrot.Location = new System.Drawing.Point(219, 177);
            this.textBox1_yrot.Name = "textBox1_yrot";
            this.textBox1_yrot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_yrot.TabIndex = 13;
            this.textBox1_yrot.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "X";
            // 
            // textBox1_xrot
            // 
            this.textBox1_xrot.Location = new System.Drawing.Point(43, 177);
            this.textBox1_xrot.Name = "textBox1_xrot";
            this.textBox1_xrot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_xrot.TabIndex = 11;
            this.textBox1_xrot.Text = "0";
            // 
            // button1_create_file
            // 
            this.button1_create_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_create_file.Location = new System.Drawing.Point(12, 299);
            this.button1_create_file.Name = "button1_create_file";
            this.button1_create_file.Size = new System.Drawing.Size(333, 34);
            this.button1_create_file.TabIndex = 18;
            this.button1_create_file.Text = "Create new file, named b.txt with changes";
            this.button1_create_file.UseVisualStyleBackColor = true;
            this.button1_create_file.Click += new System.EventHandler(this.button1_create_file_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(364, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Z";
            // 
            // textBox1_zmot
            // 
            this.textBox1_zmot.Location = new System.Drawing.Point(389, 256);
            this.textBox1_zmot.Name = "textBox1_zmot";
            this.textBox1_zmot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_zmot.TabIndex = 23;
            this.textBox1_zmot.Text = "0";
            this.textBox1_zmot.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(193, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Y";
            // 
            // textBox1_ymot
            // 
            this.textBox1_ymot.Location = new System.Drawing.Point(219, 256);
            this.textBox1_ymot.Name = "textBox1_ymot";
            this.textBox1_ymot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_ymot.TabIndex = 21;
            this.textBox1_ymot.Text = "0";
            this.textBox1_ymot.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "X";
            // 
            // textBox1_xmot
            // 
            this.textBox1_xmot.Location = new System.Drawing.Point(43, 256);
            this.textBox1_xmot.Name = "textBox1_xmot";
            this.textBox1_xmot.Size = new System.Drawing.Size(125, 20);
            this.textBox1_xmot.TabIndex = 19;
            this.textBox1_xmot.Text = "0";
            this.textBox1_xmot.Visible = false;
            // 
            // checkBox1_mot
            // 
            this.checkBox1_mot.AutoSize = true;
            this.checkBox1_mot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1_mot.Location = new System.Drawing.Point(21, 214);
            this.checkBox1_mot.Name = "checkBox1_mot";
            this.checkBox1_mot.Size = new System.Drawing.Size(427, 24);
            this.checkBox1_mot.TabIndex = 26;
            this.checkBox1_mot.Text = "Custom center of base? (First object is center by default)";
            this.checkBox1_mot.UseVisualStyleBackColor = true;
            this.checkBox1_mot.CheckedChanged += new System.EventHandler(this.checkBox1_mot_CheckedChanged);
            // 
            // checkBox1_position
            // 
            this.checkBox1_position.AutoSize = true;
            this.checkBox1_position.Checked = true;
            this.checkBox1_position.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1_position.Location = new System.Drawing.Point(117, 71);
            this.checkBox1_position.Name = "checkBox1_position";
            this.checkBox1_position.Size = new System.Drawing.Size(96, 24);
            this.checkBox1_position.TabIndex = 27;
            this.checkBox1_position.Text = "Changing";
            this.checkBox1_position.UseVisualStyleBackColor = true;
            this.checkBox1_position.CheckedChanged += new System.EventHandler(this.checkBox1_position_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 345);
            this.Controls.Add(this.checkBox1_position);
            this.Controls.Add(this.checkBox1_mot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1_zmot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1_ymot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1_xmot);
            this.Controls.Add(this.button1_create_file);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1_zrot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1_yrot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1_xrot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_zpos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_ypos);
            this.Controls.Add(this.label1_X);
            this.Controls.Add(this.textBox1_xpos);
            this.Controls.Add(this.button1_process);
            this.Controls.Add(this.label1_fileaddress);
            this.Controls.Add(this.textBox1_fileaddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Freelancer base mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_fileaddress;
        private System.Windows.Forms.Label label1_fileaddress;
        private System.Windows.Forms.Button button1_process;
        private System.Windows.Forms.TextBox textBox1_xpos;
        private System.Windows.Forms.Label label1_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_ypos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_zpos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_zrot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1_yrot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1_xrot;
        private System.Windows.Forms.Button button1_create_file;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1_zmot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1_ymot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1_xmot;
        private System.Windows.Forms.CheckBox checkBox1_mot;
        private System.Windows.Forms.CheckBox checkBox1_position;
    }
}

