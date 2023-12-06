namespace lab2._2
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
            groupBox1 = new GroupBox();
            save_button = new Button();
            text_point = new TextBox();
            text_name = new TextBox();
            text_id_student = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            text_avg = new TextBox();
            textBox_F = new TextBox();
            textBox_D = new TextBox();
            textBox_D_pass = new TextBox();
            textBox_C = new TextBox();
            textBox_C_pass = new TextBox();
            textBox_B = new TextBox();
            textBox_B_pass = new TextBox();
            textBox_A = new TextBox();
            avg_point = new TextBox();
            socre_min = new TextBox();
            name_min = new TextBox();
            student_min = new TextBox();
            socre_max = new TextBox();
            name_max = new TextBox();
            student_max = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(save_button);
            groupBox1.Controls.Add(text_point);
            groupBox1.Controls.Add(text_name);
            groupBox1.Controls.Add(text_id_student);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูล";
            // 
            // save_button
            // 
            save_button.Location = new Point(146, 163);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 29);
            save_button.TabIndex = 6;
            save_button.Text = "บันทึก";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // text_point
            // 
            text_point.Location = new Point(137, 119);
            text_point.Name = "text_point";
            text_point.Size = new Size(125, 27);
            text_point.TabIndex = 5;
            // 
            // text_name
            // 
            text_name.Location = new Point(137, 76);
            text_name.Name = "text_name";
            text_name.Size = new Size(125, 27);
            text_name.TabIndex = 4;
            // 
            // text_id_student
            // 
            text_id_student.Location = new Point(137, 37);
            text_id_student.Name = "text_id_student";
            text_id_student.Size = new Size(125, 27);
            text_id_student.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 122);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "รหัสนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(text_avg);
            groupBox2.Controls.Add(textBox_F);
            groupBox2.Controls.Add(textBox_D);
            groupBox2.Controls.Add(textBox_D_pass);
            groupBox2.Controls.Add(textBox_C);
            groupBox2.Controls.Add(textBox_C_pass);
            groupBox2.Controls.Add(textBox_B);
            groupBox2.Controls.Add(textBox_B_pass);
            groupBox2.Controls.Add(textBox_A);
            groupBox2.Controls.Add(avg_point);
            groupBox2.Controls.Add(socre_min);
            groupBox2.Controls.Add(name_min);
            groupBox2.Controls.Add(student_min);
            groupBox2.Controls.Add(socre_max);
            groupBox2.Controls.Add(name_max);
            groupBox2.Controls.Add(student_max);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(402, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 546);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพท์";
            // 
            // text_avg
            // 
            text_avg.Location = new Point(138, 464);
            text_avg.Name = "text_avg";
            text_avg.Size = new Size(98, 27);
            text_avg.TabIndex = 32;
            // 
            // textBox_F
            // 
            textBox_F.Location = new Point(138, 416);
            textBox_F.Name = "textBox_F";
            textBox_F.Size = new Size(98, 27);
            textBox_F.TabIndex = 31;
            // 
            // textBox_D
            // 
            textBox_D.Location = new Point(138, 380);
            textBox_D.Name = "textBox_D";
            textBox_D.Size = new Size(98, 27);
            textBox_D.TabIndex = 30;
            // 
            // textBox_D_pass
            // 
            textBox_D_pass.Location = new Point(138, 334);
            textBox_D_pass.Name = "textBox_D_pass";
            textBox_D_pass.Size = new Size(98, 27);
            textBox_D_pass.TabIndex = 29;
            // 
            // textBox_C
            // 
            textBox_C.Location = new Point(138, 291);
            textBox_C.Name = "textBox_C";
            textBox_C.Size = new Size(98, 27);
            textBox_C.TabIndex = 28;
            // 
            // textBox_C_pass
            // 
            textBox_C_pass.Location = new Point(138, 249);
            textBox_C_pass.Name = "textBox_C_pass";
            textBox_C_pass.Size = new Size(98, 27);
            textBox_C_pass.TabIndex = 27;
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(138, 203);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(98, 27);
            textBox_B.TabIndex = 26;
            // 
            // textBox_B_pass
            // 
            textBox_B_pass.Location = new Point(138, 163);
            textBox_B_pass.Name = "textBox_B_pass";
            textBox_B_pass.Size = new Size(98, 27);
            textBox_B_pass.TabIndex = 25;
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(138, 119);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(98, 27);
            textBox_A.TabIndex = 24;
            // 
            // avg_point
            // 
            avg_point.Location = new Point(634, 185);
            avg_point.Name = "avg_point";
            avg_point.Size = new Size(98, 27);
            avg_point.TabIndex = 23;
            // 
            // socre_min
            // 
            socre_min.Location = new Point(633, 126);
            socre_min.Name = "socre_min";
            socre_min.Size = new Size(98, 27);
            socre_min.TabIndex = 22;
            // 
            // name_min
            // 
            name_min.Location = new Point(530, 126);
            name_min.Name = "name_min";
            name_min.Size = new Size(98, 27);
            name_min.TabIndex = 21;
            // 
            // student_min
            // 
            student_min.Location = new Point(424, 126);
            student_min.Name = "student_min";
            student_min.Size = new Size(98, 27);
            student_min.TabIndex = 20;
            // 
            // socre_max
            // 
            socre_max.Location = new Point(634, 76);
            socre_max.Name = "socre_max";
            socre_max.Size = new Size(98, 27);
            socre_max.TabIndex = 19;
            // 
            // name_max
            // 
            name_max.Location = new Point(528, 76);
            name_max.Name = "name_max";
            name_max.Size = new Size(100, 27);
            name_max.TabIndex = 18;
            // 
            // student_max
            // 
            student_max.Location = new Point(426, 76);
            student_max.Name = "student_max";
            student_max.Size = new Size(96, 27);
            student_max.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 464);
            label18.Name = "label18";
            label18.Size = new Size(66, 20);
            label18.TabIndex = 17;
            label18.Text = "เกรดเฉลี่ย";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 416);
            label17.Name = "label17";
            label17.Size = new Size(16, 20);
            label17.TabIndex = 16;
            label17.Text = "F";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 380);
            label16.Name = "label16";
            label16.Size = new Size(20, 20);
            label16.TabIndex = 15;
            label16.Text = "D";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 334);
            label15.Name = "label15";
            label15.Size = new Size(30, 20);
            label15.TabIndex = 14;
            label15.Text = "D+";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 291);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 13;
            label14.Text = "C";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 249);
            label13.Name = "label13";
            label13.Size = new Size(28, 20);
            label13.TabIndex = 12;
            label13.Text = "C+";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 203);
            label12.Name = "label12";
            label12.Size = new Size(18, 20);
            label12.TabIndex = 11;
            label12.Text = "B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 163);
            label11.Name = "label11";
            label11.Size = new Size(28, 20);
            label11.TabIndex = 10;
            label11.Text = "B+";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 122);
            label10.Name = "label10";
            label10.Size = new Size(19, 20);
            label10.TabIndex = 9;
            label10.Text = "A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(528, 188);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 8;
            label9.Text = "คะแนนเฉลี่ย";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 126);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 7;
            label8.Text = "คะแนนต่ำสุด";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 76);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "คะแนนสูงสุด";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(660, 40);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "คะแนน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 37);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "ชื่อ-นามสกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 37);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "รหัสนักศึกษา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 618);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button save_button;
        private TextBox text_point;
        private TextBox text_name;
        private TextBox text_id_student;
        private TextBox text_avg;
        private TextBox textBox_F;
        private TextBox textBox_D;
        private TextBox textBox_D_pass;
        private TextBox textBox_C;
        private TextBox textBox_C_pass;
        private TextBox textBox_B;
        private TextBox textBox_B_pass;
        private TextBox textBox_A;
        private TextBox avg_point;
        private TextBox socre_min;
        private TextBox name_min;
        private TextBox student_min;
        private TextBox socre_max;
        private TextBox name_max;
        private TextBox student_max;
        private Label label18;
        private Label label17;
    }
}
