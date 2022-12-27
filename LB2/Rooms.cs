using LB2.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LB2
{
    public partial class Rooms : Form
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        List<Instrument> instruments = new List<Instrument>();
        List<Worker> workers = new List<Worker>();

        List<Instrument> selectInstruments = new List<Instrument>();
        List<Worker> selectWorkers = new List<Worker>();

        public Rooms()
        {
            InitializeComponent();
            string folderName = Path.Combine(projectPath, "Studio");
            var filePathsW = Directory.GetFiles(folderName, "Workers.txt");
            var filePathsI = Directory.GetFiles(folderName, "Instruments.txt");

            foreach (string path in filePathsW)
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(json))
                    workers.AddRange(JsonConvert.DeserializeObject<List<Worker>>(json));
            }

            foreach (var item in workers)
            {
                comboBox1.Items.Add(item.id);
            }

            foreach (string path in filePathsI)
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(json))
                    instruments.AddRange(JsonConvert.DeserializeObject<List<Instrument>>(json));
            }

            foreach (var item in instruments)
            {
                comboBox3.Items.Add(item.id);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void Rooms_Load(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectInstruments.Add(instruments[comboBox3.SelectedIndex]);
            comboBox4.Items.Clear();
            foreach (var item in selectInstruments)
            {
                comboBox4.Items.Add(item.id);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectWorkers.Add(workers[comboBox1.SelectedIndex]);
            comboBox2.Items.Clear();
            foreach (var item in selectWorkers)
            {
                comboBox2.Items.Add(item.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть ID",
                    "Помилка, поле не може бути пустим",
                    MessageBoxButtons.OK
                );
                return;
            }
            else
            {
                int num;
                try
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    textBox1.Text = string.Empty;
                    MessageBox.Show(
                        "Уводьте лише числа",
                        "Помилка, уводьте лише числа",
                        MessageBoxButtons.OK
                    );
                    return;
                }
            }

            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            var filePaths = Directory.GetFiles(folderName, "Rooms.txt");

            List<Room> rooms = new List<Room> { };

            foreach (string path in filePaths)
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(json))
                    rooms.AddRange(JsonConvert.DeserializeObject<List<Room>>(json));
            }

            List<string> instrumentsId = new List<string>();
            List<string> workersId = new List<string>();

            foreach (var id in selectInstruments)
            {
                instrumentsId.Add(id.id);
            }
            foreach (var id in selectWorkers)
            {
                workersId.Add(id.id);
            }

            rooms.Add(
                new Room(
                    num: int.Parse(textBox1.Text),
                    instrumentsId: instrumentsId,
                    workersId: workersId,
                    instruments: comboBox4.Items.Count,
                    workers: comboBox2.Items.Count
                )
            );
            string pathData = Path.Combine(folderName, "Rooms.txt");
            string jsonData = JsonConvert.SerializeObject(rooms);
            File.WriteAllText(pathData, jsonData);

            Close();
        }
    }
}
