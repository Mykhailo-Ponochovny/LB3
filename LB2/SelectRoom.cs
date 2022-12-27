using LB2.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class SelectRoom : Form
    {
        Form1 form1 = (Form1)Application.OpenForms["Form1"];

        List<Room> rooms = new List<Room> { };

        public SelectRoom()
        {
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            var filePaths = Directory.GetFiles(folderName, "Rooms.txt");

            foreach (string path in filePaths)
            {
                string json = File.ReadAllText(path);
                rooms.AddRange(JsonConvert.DeserializeObject<List<Room>>(json));
            }

            InitializeComponent();
            foreach (var instrument in rooms)
            {
                comboBox1.Items.Add(instrument.num);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1 != null && comboBox1.SelectedIndex >= 0)
            {
                form1.SelectedStudio.addRoom(rooms[comboBox1.SelectedIndex]);

                form1.SelectedStudio.saveData();
                Close();
            }
        }
    }
}
