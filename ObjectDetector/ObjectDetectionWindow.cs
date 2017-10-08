using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDetector
{
    public partial class ObjectDetectionWindow : Form
    {
        private readonly MainWindow mainWindow;
        public ObjectDetectionWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            pb_detectedObject.Image = this.mainWindow.Bitmap;
        }

        private void OknoDetekcjiObiektu_Load(object sender, EventArgs e)
        {

        }
    }
}
