using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Utils
{
    public static class Helper
    {
        public static void SetFixedFormSize(System.Windows.Forms.Form form, int width, int height)
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(width, height);
        }
    }
}
