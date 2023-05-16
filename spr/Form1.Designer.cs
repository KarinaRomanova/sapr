namespace spr
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
            this.nodes = new System.Windows.Forms.Button();
            this.rods = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.main_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.reset_button_1 = new System.Windows.Forms.Button();
            this.sealing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.second_label = new System.Windows.Forms.Label();
            this.result_qx = new System.Windows.Forms.Label();
            this.loads_clear = new System.Windows.Forms.Button();
            this.x_coord = new System.Windows.Forms.TextBox();
            this.second_y = new System.Windows.Forms.TextBox();
            this.y_coord = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.second_x = new System.Windows.Forms.TextBox();
            this.qx = new System.Windows.Forms.TextBox();
            this.qy = new System.Windows.Forms.TextBox();
            this.second_save = new System.Windows.Forms.Button();
            this.ready = new System.Windows.Forms.Button();
            this.sealings_clear = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.TextBox();
            this.ready2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Process = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nodes
            // 
            this.nodes.Location = new System.Drawing.Point(12, 50);
            this.nodes.Name = "nodes";
            this.nodes.Size = new System.Drawing.Size(101, 36);
            this.nodes.TabIndex = 0;
            this.nodes.Text = "Узлы";
            this.nodes.UseVisualStyleBackColor = true;
            this.nodes.Click += new System.EventHandler(this.nodes_Click);
            // 
            // rods
            // 
            this.rods.Location = new System.Drawing.Point(12, 92);
            this.rods.Name = "rods";
            this.rods.Size = new System.Drawing.Size(101, 36);
            this.rods.TabIndex = 1;
            this.rods.Text = "Стержни";
            this.rods.UseVisualStyleBackColor = true;
            this.rods.Click += new System.EventHandler(this.rods_Click);
            // 
            // cut
            // 
            this.cut.Location = new System.Drawing.Point(12, 134);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(101, 36);
            this.cut.TabIndex = 2;
            this.cut.Text = "Сечение";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 176);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(101, 36);
            this.load.TabIndex = 3;
            this.load.Text = "Нагрузки";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_label.Location = new System.Drawing.Point(140, 54);
            this.main_label.Margin = new System.Windows.Forms.Padding(0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(116, 30);
            this.main_label.TabIndex = 4;
            this.main_label.Text = "Main_label";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(648, 60);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(55, 25);
            this.result.TabIndex = 10;
            this.result.Text = "result";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(12, 443);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(101, 33);
            this.reset_button.TabIndex = 11;
            this.reset_button.Text = "Сброс";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click_1);
            // 
            // reset_button_1
            // 
            this.reset_button_1.Location = new System.Drawing.Point(12, 443);
            this.reset_button_1.Name = "reset_button_1";
            this.reset_button_1.Size = new System.Drawing.Size(101, 33);
            this.reset_button_1.TabIndex = 12;
            this.reset_button_1.Text = "Сброс";
            this.reset_button_1.UseVisualStyleBackColor = true;
            this.reset_button_1.Click += new System.EventHandler(this.reset_button_1_Click);
            // 
            // sealing
            // 
            this.sealing.Location = new System.Drawing.Point(12, 218);
            this.sealing.Name = "sealing";
            this.sealing.Size = new System.Drawing.Size(101, 36);
            this.sealing.TabIndex = 13;
            this.sealing.Text = "Заделки";
            this.sealing.UseVisualStyleBackColor = true;
            this.sealing.Click += new System.EventHandler(this.sealing_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // second_label
            // 
            this.second_label.AutoSize = true;
            this.second_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.second_label.Location = new System.Drawing.Point(140, 134);
            this.second_label.Margin = new System.Windows.Forms.Padding(0);
            this.second_label.Name = "second_label";
            this.second_label.Size = new System.Drawing.Size(140, 30);
            this.second_label.TabIndex = 15;
            this.second_label.Text = "Second_label";
            this.second_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // result_qx
            // 
            this.result_qx.AutoSize = true;
            this.result_qx.Location = new System.Drawing.Point(541, 61);
            this.result_qx.Name = "result_qx";
            this.result_qx.Size = new System.Drawing.Size(81, 25);
            this.result_qx.TabIndex = 21;
            this.result_qx.Text = "result_qx";
            // 
            // loads_clear
            // 
            this.loads_clear.Location = new System.Drawing.Point(12, 443);
            this.loads_clear.Name = "loads_clear";
            this.loads_clear.Size = new System.Drawing.Size(101, 33);
            this.loads_clear.TabIndex = 22;
            this.loads_clear.Text = "Сброс";
            this.loads_clear.UseVisualStyleBackColor = true;
            this.loads_clear.Click += new System.EventHandler(this.loads_clear_Click);
            // 
            // x_coord
            // 
            this.x_coord.Location = new System.Drawing.Point(146, 90);
            this.x_coord.Name = "x_coord";
            this.x_coord.Size = new System.Drawing.Size(33, 31);
            this.x_coord.TabIndex = 7;
            this.x_coord.Text = "x";
            this.x_coord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_coord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qy_KeyPress);
            // 
            // second_y
            // 
            this.second_y.Location = new System.Drawing.Point(197, 90);
            this.second_y.Name = "second_y";
            this.second_y.Size = new System.Drawing.Size(33, 31);
            this.second_y.TabIndex = 23;
            this.second_y.Text = "x";
            this.second_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_y_KeyPress);
            // 
            // y_coord
            // 
            this.y_coord.Location = new System.Drawing.Point(236, 90);
            this.y_coord.Name = "y_coord";
            this.y_coord.Size = new System.Drawing.Size(33, 31);
            this.y_coord.TabIndex = 24;
            this.y_coord.Text = "x";
            this.y_coord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_coord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_coord_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(312, 90);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(46, 31);
            this.OK.TabIndex = 28;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(312, 92);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(46, 31);
            this.save.TabIndex = 29;
            this.save.Text = "->";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // second_x
            // 
            this.second_x.Location = new System.Drawing.Point(146, 169);
            this.second_x.Name = "second_x";
            this.second_x.Size = new System.Drawing.Size(33, 31);
            this.second_x.TabIndex = 30;
            this.second_x.Text = "x";
            this.second_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_x_KeyPress_1);
            // 
            // qx
            // 
            this.qx.Location = new System.Drawing.Point(197, 169);
            this.qx.Name = "qx";
            this.qx.Size = new System.Drawing.Size(33, 31);
            this.qx.TabIndex = 31;
            this.qx.Text = "x";
            this.qx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qx_KeyPress_1);
            // 
            // qy
            // 
            this.qy.Location = new System.Drawing.Point(236, 169);
            this.qy.Name = "qy";
            this.qy.Size = new System.Drawing.Size(33, 31);
            this.qy.TabIndex = 32;
            this.qy.Text = "x";
            this.qy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qy_KeyPress_1);
            // 
            // second_save
            // 
            this.second_save.Location = new System.Drawing.Point(312, 169);
            this.second_save.Name = "second_save";
            this.second_save.Size = new System.Drawing.Size(46, 31);
            this.second_save.TabIndex = 33;
            this.second_save.Text = "->";
            this.second_save.UseVisualStyleBackColor = true;
            this.second_save.Click += new System.EventHandler(this.second_save_Click);
            // 
            // ready
            // 
            this.ready.Location = new System.Drawing.Point(119, 443);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(101, 33);
            this.ready.TabIndex = 34;
            this.ready.Text = "Готово";
            this.ready.UseVisualStyleBackColor = true;
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // sealings_clear
            // 
            this.sealings_clear.Location = new System.Drawing.Point(12, 443);
            this.sealings_clear.Name = "sealings_clear";
            this.sealings_clear.Size = new System.Drawing.Size(101, 33);
            this.sealings_clear.TabIndex = 35;
            this.sealings_clear.Text = "Сброс";
            this.sealings_clear.UseVisualStyleBackColor = true;
            this.sealings_clear.Click += new System.EventHandler(this.sealings_clear_Click);
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(275, 90);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(33, 31);
            this.z.TabIndex = 36;
            this.z.Text = "x";
            this.z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.z_KeyPress);
            // 
            // ready2
            // 
            this.ready2.Location = new System.Drawing.Point(119, 443);
            this.ready2.Name = "ready2";
            this.ready2.Size = new System.Drawing.Size(101, 33);
            this.ready2.TabIndex = 37;
            this.ready2.Text = "Готово";
            this.ready2.UseVisualStyleBackColor = true;
            this.ready2.Click += new System.EventHandler(this.ready2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Process});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 33);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_File,
            this.Open_File});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(69, 29);
            this.File.Text = "Файл";
            // 
            // Save_File
            // 
            this.Save_File.Name = "Save_File";
            this.Save_File.Size = new System.Drawing.Size(270, 34);
            this.Save_File.Text = "Сохранить";
            this.Save_File.Click += new System.EventHandler(this.Save_File_Click);
            // 
            // Open_File
            // 
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(270, 34);
            this.Open_File.Text = "Открыть";
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // Process
            // 
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(115, 29);
            this.Process.Text = "Рассчитать";
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 623);
            this.Controls.Add(this.ready2);
            this.Controls.Add(this.z);
            this.Controls.Add(this.sealings_clear);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.second_save);
            this.Controls.Add(this.qy);
            this.Controls.Add(this.qx);
            this.Controls.Add(this.second_x);
            this.Controls.Add(this.save);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.y_coord);
            this.Controls.Add(this.second_y);
            this.Controls.Add(this.loads_clear);
            this.Controls.Add(this.result_qx);
            this.Controls.Add(this.second_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sealing);
            this.Controls.Add(this.reset_button_1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.result);
            this.Controls.Add(this.x_coord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.load);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.rods);
            this.Controls.Add(this.nodes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "САПР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nodes;
        private Button rods;
        private Button cut;
        private Button load;
        private Label main_label;
        private TextBox textBox1;
        private Label result;
        private Button reset_button;
        private Button reset_button_1;
        private Button sealing;
        private Button button1;
        private Label second_label;
        private Label result_qx;
        private Button loads_clear;
        private TextBox x_coord;
        private TextBox second_y;
        private TextBox y_coord;
        private Button OK;
        private Button save;
        private TextBox second_x;
        private TextBox qx;
        private TextBox qy;
        private Button second_save;
        private Button ready;
        private Button sealings_clear;
        private TextBox z;
        private Button ready2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Save_File;
        private ToolStripMenuItem Open_File;
        private ToolStripMenuItem Process;
        private SaveFileDialog saveFileDialog1;
    }
}