namespace Crop_Job
{
    internal class ImageProperties
    {
        string m_file_name { get; set; }
        System.Drawing.Bitmap m_bitmap { get; set; }

        public ImageProperties(string name, System.Drawing.Bitmap bitmap)
        {
            m_file_name = name;
            m_bitmap = bitmap;
        }


        public string getFileName() { return m_file_name; }
        public System.Drawing.Bitmap getBitmap() { return m_bitmap; }
        public void releaseBitmap()
        {
            m_bitmap.Dispose();
        }
    }
}