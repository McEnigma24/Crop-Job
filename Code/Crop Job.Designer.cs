
namespace Crop_Job
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.button_crop = new System.Windows.Forms.Button();
            this.textBox_cropp_x = new System.Windows.Forms.TextBox();
            this.textBox_cropp_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_rec_height = new System.Windows.Forms.TextBox();
            this.textBox_rec_width = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_extensions = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_jpg = new System.Windows.Forms.CheckBox();
            this.checkBox_png = new System.Windows.Forms.CheckBox();
            this.checkBox_bmp = new System.Windows.Forms.CheckBox();
            this.pictureBox_crop_point_coordinets_width_height = new System.Windows.Forms.PictureBox();
            this.button_see_output = new System.Windows.Forms.Button();
            this.comboBox_direct_paths = new System.Windows.Forms.ComboBox();
            this.button_adding_to_direct_paths = new System.Windows.Forms.Button();
            this.button_deleting_from_direct_paths = new System.Windows.Forms.Button();
            this.button_clearing_direct_paths = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_direct_paths_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_crop_point_coordinets_width_height)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cropping images for you";
            // 
            // textBox_directory
            // 
            this.textBox_directory.AllowDrop = true;
            this.textBox_directory.Location = new System.Drawing.Point(21, 74);
            this.textBox_directory.Multiline = true;
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(172, 49);
            this.textBox_directory.TabIndex = 1;
            this.textBox_directory.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_dropped_directory);
            this.textBox_directory.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_entered);
            // 
            // button_crop
            // 
            this.button_crop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_crop.Location = new System.Drawing.Point(237, 322);
            this.button_crop.Name = "button_crop";
            this.button_crop.Size = new System.Drawing.Size(189, 71);
            this.button_crop.TabIndex = 2;
            this.button_crop.Text = "Crop";
            this.button_crop.UseVisualStyleBackColor = true;
            this.button_crop.Click += new System.EventHandler(this.button_crop_Click);
            // 
            // textBox_cropp_x
            // 
            this.textBox_cropp_x.Location = new System.Drawing.Point(256, 224);
            this.textBox_cropp_x.Name = "textBox_cropp_x";
            this.textBox_cropp_x.Size = new System.Drawing.Size(64, 20);
            this.textBox_cropp_x.TabIndex = 4;
            // 
            // textBox_cropp_y
            // 
            this.textBox_cropp_y.Location = new System.Drawing.Point(333, 224);
            this.textBox_cropp_y.Name = "textBox_cropp_y";
            this.textBox_cropp_y.Size = new System.Drawing.Size(64, 20);
            this.textBox_cropp_y.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(280, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(355, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(336, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(265, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "width";
            // 
            // textBox_rec_height
            // 
            this.textBox_rec_height.Location = new System.Drawing.Point(333, 270);
            this.textBox_rec_height.Name = "textBox_rec_height";
            this.textBox_rec_height.Size = new System.Drawing.Size(64, 20);
            this.textBox_rec_height.TabIndex = 11;
            // 
            // textBox_rec_width
            // 
            this.textBox_rec_width.Location = new System.Drawing.Point(256, 270);
            this.textBox_rec_width.Name = "textBox_rec_width";
            this.textBox_rec_width.Size = new System.Drawing.Size(64, 20);
            this.textBox_rec_width.TabIndex = 10;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_error.Location = new System.Drawing.Point(262, 299);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(125, 20);
            this.label_error.TabIndex = 14;
            this.label_error.Text = "incomplete input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(64, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Saving to format";
            // 
            // comboBox_extensions
            // 
            this.comboBox_extensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_extensions.FormattingEnabled = true;
            this.comboBox_extensions.Items.AddRange(new object[] {
            ".jpg",
            ".png",
            ".bmp"});
            this.comboBox_extensions.Location = new System.Drawing.Point(48, 277);
            this.comboBox_extensions.Name = "comboBox_extensions";
            this.comboBox_extensions.Size = new System.Drawing.Size(115, 21);
            this.comboBox_extensions.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Filter from directory";
            // 
            // checkBox_jpg
            // 
            this.checkBox_jpg.AutoSize = true;
            this.checkBox_jpg.Location = new System.Drawing.Point(21, 142);
            this.checkBox_jpg.Name = "checkBox_jpg";
            this.checkBox_jpg.Size = new System.Drawing.Size(43, 17);
            this.checkBox_jpg.TabIndex = 26;
            this.checkBox_jpg.Text = ".jpg";
            this.checkBox_jpg.UseVisualStyleBackColor = true;
            // 
            // checkBox_png
            // 
            this.checkBox_png.AutoSize = true;
            this.checkBox_png.Location = new System.Drawing.Point(70, 142);
            this.checkBox_png.Name = "checkBox_png";
            this.checkBox_png.Size = new System.Drawing.Size(47, 17);
            this.checkBox_png.TabIndex = 27;
            this.checkBox_png.Text = ".png";
            this.checkBox_png.UseVisualStyleBackColor = true;
            // 
            // checkBox_bmp
            // 
            this.checkBox_bmp.AutoSize = true;
            this.checkBox_bmp.Location = new System.Drawing.Point(123, 142);
            this.checkBox_bmp.Name = "checkBox_bmp";
            this.checkBox_bmp.Size = new System.Drawing.Size(49, 17);
            this.checkBox_bmp.TabIndex = 28;
            this.checkBox_bmp.Text = ".bmp";
            this.checkBox_bmp.UseVisualStyleBackColor = true;
            // 
            // pictureBox_crop_point_coordinets_width_height
            // 
            this.pictureBox_crop_point_coordinets_width_height.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_crop_point_coordinets_width_height.ErrorImage")));
            this.pictureBox_crop_point_coordinets_width_height.ImageLocation = "Application Files/RectXY.jpg";
            this.pictureBox_crop_point_coordinets_width_height.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_crop_point_coordinets_width_height.InitialImage")));
            this.pictureBox_crop_point_coordinets_width_height.Location = new System.Drawing.Point(220, 74);
            this.pictureBox_crop_point_coordinets_width_height.Name = "pictureBox_crop_point_coordinets_width_height";
            this.pictureBox_crop_point_coordinets_width_height.Size = new System.Drawing.Size(206, 123);
            this.pictureBox_crop_point_coordinets_width_height.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_crop_point_coordinets_width_height.TabIndex = 29;
            this.pictureBox_crop_point_coordinets_width_height.TabStop = false;
            // 
            // button_see_output
            // 
            this.button_see_output.Location = new System.Drawing.Point(18, 322);
            this.button_see_output.Name = "button_see_output";
            this.button_see_output.Size = new System.Drawing.Size(175, 71);
            this.button_see_output.TabIndex = 30;
            this.button_see_output.Text = "Open output directory";
            this.button_see_output.UseVisualStyleBackColor = true;
            this.button_see_output.Click += new System.EventHandler(this.button_see_output_Click);
            // 
            // comboBox_direct_paths
            // 
            this.comboBox_direct_paths.AllowDrop = true;
            this.comboBox_direct_paths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox_direct_paths.FormattingEnabled = true;
            this.comboBox_direct_paths.Location = new System.Drawing.Point(21, 197);
            this.comboBox_direct_paths.Name = "comboBox_direct_paths";
            this.comboBox_direct_paths.Size = new System.Drawing.Size(172, 21);
            this.comboBox_direct_paths.TabIndex = 35;
            this.comboBox_direct_paths.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_dropped_direct_path);
            this.comboBox_direct_paths.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_entered);
            // 
            // button_adding_to_direct_paths
            // 
            this.button_adding_to_direct_paths.Location = new System.Drawing.Point(21, 220);
            this.button_adding_to_direct_paths.Name = "button_adding_to_direct_paths";
            this.button_adding_to_direct_paths.Size = new System.Drawing.Size(43, 28);
            this.button_adding_to_direct_paths.TabIndex = 36;
            this.button_adding_to_direct_paths.Text = "add";
            this.button_adding_to_direct_paths.UseVisualStyleBackColor = true;
            this.button_adding_to_direct_paths.Click += new System.EventHandler(this.button_adding_to_direct_paths_Click);
            // 
            // button_deleting_from_direct_paths
            // 
            this.button_deleting_from_direct_paths.Location = new System.Drawing.Point(70, 220);
            this.button_deleting_from_direct_paths.Name = "button_deleting_from_direct_paths";
            this.button_deleting_from_direct_paths.Size = new System.Drawing.Size(49, 28);
            this.button_deleting_from_direct_paths.TabIndex = 37;
            this.button_deleting_from_direct_paths.Text = "delete";
            this.button_deleting_from_direct_paths.UseVisualStyleBackColor = true;
            this.button_deleting_from_direct_paths.Click += new System.EventHandler(this.button_deleting_from_direct_paths_Click);
            // 
            // button_clearing_direct_paths
            // 
            this.button_clearing_direct_paths.Location = new System.Drawing.Point(123, 220);
            this.button_clearing_direct_paths.Name = "button_clearing_direct_paths";
            this.button_clearing_direct_paths.Size = new System.Drawing.Size(70, 28);
            this.button_clearing_direct_paths.TabIndex = 38;
            this.button_clearing_direct_paths.Text = "clear";
            this.button_clearing_direct_paths.UseVisualStyleBackColor = true;
            this.button_clearing_direct_paths.Click += new System.EventHandler(this.button_clearing_direct_paths_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Single directory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Direct paths";
            // 
            // label_direct_paths_count
            // 
            this.label_direct_paths_count.AutoSize = true;
            this.label_direct_paths_count.Location = new System.Drawing.Point(83, 181);
            this.label_direct_paths_count.Name = "label_direct_paths_count";
            this.label_direct_paths_count.Size = new System.Drawing.Size(13, 13);
            this.label_direct_paths_count.TabIndex = 42;
            this.label_direct_paths_count.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 405);
            this.Controls.Add(this.label_direct_paths_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_clearing_direct_paths);
            this.Controls.Add(this.button_deleting_from_direct_paths);
            this.Controls.Add(this.button_adding_to_direct_paths);
            this.Controls.Add(this.comboBox_direct_paths);
            this.Controls.Add(this.button_see_output);
            this.Controls.Add(this.pictureBox_crop_point_coordinets_width_height);
            this.Controls.Add(this.checkBox_bmp);
            this.Controls.Add(this.checkBox_png);
            this.Controls.Add(this.checkBox_jpg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox_extensions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_rec_height);
            this.Controls.Add(this.textBox_rec_width);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cropp_y);
            this.Controls.Add(this.textBox_cropp_x);
            this.Controls.Add(this.button_crop);
            this.Controls.Add(this.textBox_directory);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Crop Job";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_crop_point_coordinets_width_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.Button button_crop;
        private System.Windows.Forms.TextBox textBox_cropp_x;
        private System.Windows.Forms.TextBox textBox_cropp_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_rec_height;
        private System.Windows.Forms.TextBox textBox_rec_width;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_extensions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_jpg;
        private System.Windows.Forms.CheckBox checkBox_png;
        private System.Windows.Forms.CheckBox checkBox_bmp;
        private System.Windows.Forms.PictureBox pictureBox_crop_point_coordinets_width_height;
        private System.Windows.Forms.Button button_see_output;
        private System.Windows.Forms.ComboBox comboBox_direct_paths;
        private System.Windows.Forms.Button button_adding_to_direct_paths;
        private System.Windows.Forms.Button button_deleting_from_direct_paths;
        private System.Windows.Forms.Button button_clearing_direct_paths;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_direct_paths_count;
    }
}

