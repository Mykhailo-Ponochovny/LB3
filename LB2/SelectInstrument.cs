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
    public partial class SelectInstrument : Form
    {
        Form1 form1 = (Form1)Application.OpenForms["Form1"];

        List<Instrument> instruments = new List<Instrument> { };

        public SelectInstrument()
        {
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            var filePaths = Directory.GetFiles(folderName, "Instruments.txt");

            foreach (string path in filePaths)
            {
                string json = File.ReadAllText(path);
                instruments.AddRange(JsonConvert.DeserializeObject<List<Instrument>>(json));
            }

            InitializeComponent();
            foreach (var instrument in instruments)
            {
                comboBox1.Items.Add(instrument.id);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1 != null && comboBox1.SelectedIndex >= 0)
            {
                form1.SelectedStudio.addFewInstruments(
                    new List<Instrument> { instruments[comboBox1.SelectedIndex] }
                );

                form1.SelectedStudio.saveData();
                Close();
            }
        }
    }
}
