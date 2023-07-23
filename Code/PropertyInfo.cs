using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop_Job
{
    public class PropertyInfo
    {
        public string saving_to;

        public bool checkBox_jpg;
        public bool checkBox_png;
        public bool checkBox_bmp;


        public string folder_dir;

        public int crop_point_x;
        public int crop_point_y;

        public int width;
        public int height;

        public bool enabled_directories;
        public bool enabled_direct_paths;

        public PropertyInfo()
        {
            checkBox_jpg = false; checkBox_png = false; checkBox_bmp = false;
            saving_to = ".jpg";

            folder_dir = "";
            crop_point_x = 0; crop_point_y = 0; width = 0; height = 0;
            enabled_directories = true;     enabled_direct_paths = false;
        }        
    }
}