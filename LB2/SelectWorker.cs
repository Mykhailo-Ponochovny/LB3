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
    public partial class SelectWorker : Form
    {
        Form1 form1 = (Form1)Application.OpenForms["Form1"];

        List<Worker> workers = new List<Worker> { };

        public SelectWorker()
        {
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            var filePaths = Directory.GetFiles(folderName, "Workers.txt");

            foreach (string path in filePaths)
            {
                string json = File.ReadAllText(path);
                workers.AddRange(JsonConvert.DeserializeObject<List<Worker>>(json));
            }

            InitializeComponent();
            foreach (var worker in workers)
            {
                comboBox1.Items.Add(worker.id);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1 != null && comboBox1.SelectedIndex >= 0)
            {
                if (
                    !form1.SelectedStudio.workersDic.ContainsKey(
                        workers[comboBox1.SelectedIndex].id
                    )
                )
                {
                    form1.SelectedStudio.addEmployee(workers[comboBox1.SelectedIndex]);
                }

                form1.SelectedStudio.saveData();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void SelectWorker_Load(object sender, EventArgs e) { }
    }
}
