using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Crop_Job
{
    public partial class Form1 : Form
    {
        private List<ImageProperties> input_list;
        private string explorer_output_dir;
        private string output_dir;

        XmlSerializer serializer;
        private string serialize_dir;
        PropertyInfo big_property;
        Point original_position;
        Point tmp_location;

        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = label1;
            input_list = new List<ImageProperties>();
            big_property = new PropertyInfo();

            original_position = label_error.Location;
            label_error.Text = "";            
            explorer_output_dir = @"\Application Files\Finished Cropped Files";
            output_dir = @"Application Files/Finished Cropped Files";
            serialize_dir = @"Application Files/properties.txt";
            serializer = new XmlSerializer(typeof(PropertyInfo));

            // deserializacja //
            {
                if (File.Exists(serialize_dir))
                {
                    using (FileStream fileStream = new FileStream(serialize_dir, FileMode.Open))
                        big_property = (PropertyInfo)serializer.Deserialize(fileStream);

                    // aplikacja zapisanych wartości
                    {
                        // saving to //
                        {
                            // ustawiania w comboBox
                            switch (big_property.saving_to)
                            {
                                case string x when x.StartsWith(".jpg"):
                                    {
                                        //comboBox_extensions.Text = ".jpg";

                                        comboBox_extensions.SelectedItem = ".jpg";
                                        break;
                                    }

                                case string x when x.StartsWith(".png"):
                                    {
                                        //comboBox_extensions.Text = ".png";

                                        comboBox_extensions.SelectedItem = ".png";
                                        break;
                                    }

                                case string x when x.StartsWith(".bmp"):
                                    {
                                        //comboBox_extensions.Text = ".bmp";

                                        comboBox_extensions.SelectedItem = ".bmp";
                                        break;
                                    }

                                default: { break; }
                            }
                        }
                        // filter set to //
                        {
                            // ustawiania w różnych checkBox'ach
                            if (big_property.checkBox_jpg) checkBox_jpg.Checked = true;
                            if (big_property.checkBox_png) checkBox_png.Checked = true;
                            if (big_property.checkBox_bmp) checkBox_bmp.Checked = true;
                        }
                        // crop properties //
                        {
                            textBox_cropp_x.Text = big_property.crop_point_x.ToString();
                            textBox_cropp_y.Text = big_property.crop_point_y.ToString();

                            textBox_rec_width.Text = big_property.width.ToString();
                            textBox_rec_height.Text = big_property.height.ToString();
                        }
                        // last used directory //
                        {
                            textBox_directory.Text = big_property.folder_dir;
                            this.ActiveControl = label1;
                            //textBox_directory.Enabled = false;
                        }
                    }
                }

                // domyślne jeśli jeszcze nie ma pliku 
                else
                {
                    // Extension Filters //
                    checkBox_jpg.Checked = true;

                    // Saving to //
                    comboBox_extensions.SelectedItem = ".jpg";


                    // Crop Point //
                    textBox_cropp_x.Text = "0";
                    textBox_cropp_y.Text = "0";

                    textBox_rec_width.Text = "0";
                    textBox_rec_height.Text = "0";
                }
            }
        }


        // Main Button //
        private async void button_crop_Click(object sender, EventArgs e)
        {
            button_crop.Enabled = false;

            await allOtherStuff();

            button_crop.Enabled = true;
            //this.ActiveControl = button_crop;
            this.ActiveControl = label1;
        }

        private async Task allOtherStuff()
        {
            label_error.Text = ""; this.ActiveControl = label1;

            // user input check //
            if (!(textBox_cropp_x.Text != "" && textBox_cropp_y.Text != "" && textBox_rec_width.Text != "" && textBox_rec_height.Text != ""))
            {
                label_errorOffsetText(-32, 0, "incomplete crop parameters");                
                return;
            }
            if (!(int.TryParse(textBox_cropp_x.Text, out int coord_x) && int.TryParse(textBox_cropp_y.Text, out int coord_y) &&
                int.TryParse(textBox_rec_width.Text, out int user_width) && int.TryParse(textBox_rec_height.Text, out int user_height)))
            {
                label_errorOffsetText(-3, 0, "wrong number input");                
                return;
            }
            if (!(checkBox_jpg.Checked || checkBox_png.Checked || checkBox_bmp.Checked))
            {
                label_errorOffsetText(8, 0, "no filter specified");                
                return;
            }

            if (textBox_directory.Text == "" && comboBox_direct_paths.Items.Count == 0)
            {
                label_errorOffsetText(-15, 0, "input files not specified");                
                return;
            }
            if (!(user_width >= 0 && user_width <= 8000 && user_height >= 0 && user_height <= 8000 &&
                coord_x >= -8000 && user_width <= 8000 && user_height >= -8000 && user_height <= 8000))
            {
                label_errorOffsetText(-180, 0, "specified parameter is beyond reason");
                return;
            }
            
            // main stuff
            {
                try
                {
                    Application.UseWaitCursor = true;

                    string saving_format = comboBox_extensions.Text;

                    // serializacja //
                    {
                        updateCurrentStateOfProperties();
                        using (FileStream fileStream = new FileStream(serialize_dir, FileMode.Create))
                            serializer.Serialize(fileStream, big_property);
                    }

                    await Task.Run(() =>
                    {
                        // ładowanie z różnych miejsc
                        {
                            loadFromDirecory();
                            loadFromDirectPaths();

                            // if no files were captured
                            if (input_list.Count == 0)
                            {
                                Application.UseWaitCursor = false;
                                return;
                            }
                        }

                        clearOutputDir();

                        // wycinanie zdjęć //
                        {
                            string path_to_save = "";


                            Parallel.ForEach(input_list, img =>
                            {
                                using (System.Drawing.Bitmap bitmap = new Bitmap(user_width, user_height))
                                {
                                    using (Graphics gr = Graphics.FromImage(bitmap))
                                    {
                                        gr.DrawImage(img.getBitmap(), -coord_x, -coord_y);

                                        img.ToString();
                                        path_to_save = output_dir + "/" + img.getFileName();

                                        if (saving_format == ".jpg") bitmap.Save(trimExtension(path_to_save) + ".jpg", ImageFormat.Jpeg);
                                        else if (saving_format == ".png") bitmap.Save(trimExtension(path_to_save) + ".png", ImageFormat.Png);
                                        else bitmap.Save(trimExtension(path_to_save) + ".bmp", ImageFormat.Bmp);

                                        img.releaseBitmap();
                                    }
                                }
                            }
                            );

                            // wcześniejszy zwykły foreach loop
                            {
                                /*
                                foreach (var img in input_list)
                                {
                                    using (System.Drawing.Bitmap bitmap = new Bitmap(user_width, user_height))
                                    {
                                        using (Graphics gr = Graphics.FromImage(bitmap))
                                        {
                                            gr.DrawImage(img.getBitmap(), -coord_x, -coord_y);

                                            img.ToString();
                                            path_to_save = Environment.CurrentDirectory.ToString() + output_dir + "/" + img.getFileName();

                                            if (comboBox_extensions.Text == ".jpg") bitmap.Save(trimExtension(path_to_save) + ".jpg", ImageFormat.Jpeg);
                                            else if (comboBox_extensions.Text == ".png") bitmap.Save(trimExtension(path_to_save) + ".png", ImageFormat.Png);
                                            else bitmap.Save(trimExtension(path_to_save) + ".bmp", ImageFormat.Bmp);

                                            gr.Dispose();
                                            bitmap.Dispose();
                                        }
                                    }
                                }
                                */
                            }
                        }
                    });
                }
                catch(OutOfMemoryException)
                {
                    label_errorOffsetText(-15, 0, "out of memory");
                    Application.UseWaitCursor = false;
                    return;
                }
                catch (AccessViolationException)
                {
                    label_errorOffsetText(-15, 0, "access violation");
                    Application.UseWaitCursor = false;
                    return;
                }
                catch (Win32Exception)
                {
                    label_errorOffsetText(-15, 0, "windows exception");
                    Application.UseWaitCursor = false;
                    return;
                }
                catch
                {
                    label_errorOffsetText(-15, 0, "something went wrong");
                    Application.UseWaitCursor = false;
                    return;
                }

                // if no files were captured
                if (input_list.Count == 0)
                {
                    label_errorOffsetText(8, 0, "no files captured");
                    Application.UseWaitCursor = false;
                    return;
                }


                // Clearing list
                input_list.Clear();

                label_errorOffsetText(42, 0, "DONE");
                Application.UseWaitCursor = false;
            }
        }

        // see output folder
        private void button_see_output_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            if (Directory.Exists(output_dir))
                Process.Start(Environment.CurrentDirectory.ToString() + explorer_output_dir);
                //Process.Start(output_dir);
            //Process.Start(@"c:\temp");

            else
            {
                label_errorOffset(-20, 0);
                label_error.Text = "unable to open directory";
            }
        }




        // update state to serialize //
        private void updateCurrentStateOfProperties()
        {
            // ComboBox //
            big_property.saving_to = comboBox_extensions.Text;

            // CheckBox //
            big_property.checkBox_jpg = checkBox_jpg.Checked;
            big_property.checkBox_png = checkBox_png.Checked;
            big_property.checkBox_bmp = checkBox_bmp.Checked;

            // Crop info //
            big_property.crop_point_x = int.Parse(textBox_cropp_x.Text);
            big_property.crop_point_y = int.Parse(textBox_cropp_y.Text);

            big_property.width = int.Parse(textBox_rec_width.Text);
            big_property.height = int.Parse(textBox_rec_height.Text);

            // Directory //
            big_property.folder_dir = textBox_directory.Text;
        }

        // error label handling //
        private void label_errorOffset(int off_x, int off_y)
        {
            tmp_location = original_position;
            tmp_location.Offset(off_x, off_y);
            label_error.Location = tmp_location;
        }
        private void label_errorOffsetText(int off_x, int off_y, string text)
        {
            label_errorOffset(off_x, off_y);
            label_error.Text = text;
        }

        // loading from directory //
        private void loadingInputFiles(string dir)
        {
            if (!Directory.Exists(dir)) return;

            string intersertion_ = "/";

            if (checkBox_jpg.Checked == true)
            {
                string[] fileArray1 = Directory.GetFiles(dir + intersertion_, "*.jpg");
                foreach (string file in fileArray1)
                {
                    Bitmap bm = new Bitmap(file);
                    input_list.Add(new ImageProperties(destileFileName(file), bm));
                }
                string[] fileArray2 = Directory.GetFiles(dir + intersertion_, "*.jpeg");
                foreach (string file in fileArray2)
                {
                    Bitmap bm = new Bitmap(file);
                    input_list.Add(new ImageProperties(destileFileName(file), bm));
                }
            }
            if (checkBox_png.Checked == true)
            {
                string[] fileArray1 = Directory.GetFiles(dir + intersertion_, "*.png");
                foreach (string file in fileArray1)
                {
                    Bitmap bm = new Bitmap(file);
                    input_list.Add(new ImageProperties(destileFileName(file), bm));
                }
            }
            if (checkBox_bmp.Checked == true)
            {
                string[] fileArray1 = Directory.GetFiles(dir + intersertion_, "*.bmp");
                foreach (string file in fileArray1)
                {
                    Bitmap bm = new Bitmap(file);
                    input_list.Add(new ImageProperties(destileFileName(file), bm));
                }
            }
        }
        private void loadFromDirecory()
        {
            string dir = textBox_directory.Text;
            if (!Directory.Exists(dir))
            {
                label_errorOffsetText(-10, 0, "directory doesn't exist");
                return;
            }

            loadingInputFiles(dir);
        }


        private string destileFileName(string full_input)
        {
            return Path.GetFileName(full_input);
        }
        private string trimExtension(string file_name)
        {
            string edited = "";
            char[] char_array = file_name.ToCharArray();

            int index = 0;
            while (char_array[index] != '.')
            {
                edited += char_array[index];
                index++;
            }

            return edited;
        }


        // loading from paths //
        private void loadFromDirectPaths()
        {
            foreach (string file in comboBox_direct_paths.Items)
            {
                Bitmap bm = new Bitmap(file);
                input_list.Add(new ImageProperties(destileFileName(file), bm));
            }
        }

        // Getting ready for next croping //
        private void clearOutputDir()
        {
            //string[] fileArray = Directory.GetFiles(output_dir);
            string[] fileArray = Directory.GetFiles(output_dir);
            foreach (string file in fileArray) File.Delete(file);
        }


        // Direct paths handling //
        private void button_adding_to_direct_paths_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            if (comboBox_direct_paths.Text == "") return;
            else if (!File.Exists(comboBox_direct_paths.Text))
            {
                label_errorOffsetText(0, 0, "file doesn't exist");
                return;
            }

            comboBox_direct_paths.Items.Add(comboBox_direct_paths.Text);
            comboBox_direct_paths.Text = "";

            updateDirectPathCount();
        }
        private void button_deleting_from_direct_paths_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            comboBox_direct_paths.Items.Remove(comboBox_direct_paths.Text);
            comboBox_direct_paths.Text = "";

            updateDirectPathCount();
        }
        private void button_clearing_direct_paths_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            comboBox_direct_paths.Items.Clear();
            comboBox_direct_paths.Text = "";

            updateDirectPathCount();
        }
        private void updateDirectPathCount()
        {
            label_direct_paths_count.Text = comboBox_direct_paths.Items.Count.ToString();
        }



        // Drag and Drop handling //
        private void File_dropped_directory(object sender, DragEventArgs e)
        {
            //textBox_directory.Text = "";

            string[] file_paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string p in file_paths)
            {
                //textBox_directory.Text += p;
                textBox_directory.Text = p;
            }
        }
        private void File_dropped_direct_path(object sender, DragEventArgs e)
        {
            string[] file_paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string p in file_paths)
                comboBox_direct_paths.Items.Add(p);

            updateDirectPathCount();
        }

        private void File_entered(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}