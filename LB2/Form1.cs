using LB2.models;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;

namespace LB2
{
    public partial class Form1 : Form
    {
        List<Studio> studios = new List<Studio>();
        List<Instrument> instruments = new List<Instrument>();
        List<Room> rooms = new List<Room>();
        List<Worker> workers = new List<Worker>();

        Studio SelectStudio = null;

        internal Studio SelectedStudio
        {
            set => SelectStudio = value;
            get => SelectStudio;
        }

        internal List<Room> AddNewRoom
        {
            get => rooms;
            set => rooms = value;
        }
        internal List<Instrument> AddNewInstrument
        {
            get => instruments;
            set => instruments = value;
        }

        public Form1()
        {
            InitializeComponent();
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            var filePaths = Directory.GetFiles(folderName, "*.json");

            foreach (string path in filePaths)
            {
                string json = File.ReadAllText(path);
                Studio newStudio = JsonConvert.DeserializeObject<Studio>(json);
                studios.Add(newStudio);
                comboBox1.Items.Add(newStudio.getName());
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e) { }

        private void Form1_Load_2(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxName.Text.Trim().Length == 0)
            {
                textBoxName.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Уведіть назву студії";
                return;
            }

            if (textBoxAdress.Text.Length == 0 || textBoxAdress.Text.Trim().Length == 0)
            {
                textBoxAdress.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Уведіть адресу студії";
                return;
            }

            if (textBoxTrackPrice.Text.Length == 0 || textBoxTrackPrice.Text.Trim().Length == 0)
            {
                textBoxTrackPrice.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Уведіть вартість одного треку";
                return;
            }
            else
            {
                double num;
                try
                {
                    num = Convert.ToDouble(textBoxTrackPrice.Text);
                }
                catch (Exception)
                {
                    textBoxTrackPrice.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Уводьте лише числа";
                    return;
                }
                if (num < 0)
                {
                    textBoxTrackPrice.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Вартість не може бути від'ємною";
                    return;
                }
            }

            if (textBoxTrackTime.Text.Length == 0 || textBoxTrackTime.Text.Trim().Length == 0)
            {
                textBoxTrackTime.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Уведіть час створення одного треку";
                return;
            }
            else
            {
                double num;
                try
                {
                    num = Convert.ToDouble(textBoxTrackTime.Text);
                }
                catch (Exception)
                {
                    textBoxTrackTime.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Уводьте лише числа";
                    return;
                }
                if (num < 0)
                {
                    textBoxTrackTime.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Час створенняь не може бути від'ємним";
                    return;
                }
            }

            List<Room> rooms = new List<Room>();
            List<Instrument> instrument = new List<Instrument>();
            Dictionary<string, Worker> workersDic = new Dictionary<string, Worker>();
            Studio studio = new Studio(
                textBoxName.Text,
                textBoxAdress.Text,
                Convert.ToDouble(textBoxTrackPrice.Text),
                Convert.ToDouble(textBoxTrackTime.Text),
                rooms,
                instrument,
                workersDic
            );

            richTextBox1.Text = studio.ToString();

            studios.Add(studio);
            comboBox1.Items.Add(studio.getName());
            comboBox1.SelectedIndex = studios.Count - 1;
            resultLabel.ForeColor = Color.Green;
            resultLabel.Text = "Строрено нову студію";
            clearField();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "Спочатку додайте хоча б одну студію";
                resultLabel.ForeColor = Color.Red;
                return;
            }
            SelectedStudio = studios[comboBox1.SelectedIndex];
            resultLabel.ForeColor = Color.Green;
            richTextBox1.Text = SelectedStudio.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rooms roomsForm = new Rooms();
            roomsForm.ShowDialog();
            resultLabel.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "Спочатку додайте хочаб одну студію";
                resultLabel.ForeColor = Color.Red;
                return;
            }
            richTextBox1.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studios[comboBox1.SelectedIndex].saveData();

            richTextBox1.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "Спочатку додайте хочаб одну студію";
                resultLabel.ForeColor = Color.Red;
                return;
            }
            Studio newStudio = (Studio)studios[comboBox1.SelectedIndex].Clone();
            string originName = studios[comboBox1.SelectedIndex].getName();
            studios.Add(newStudio);
            comboBox1.Items.Add(newStudio.getName());
            comboBox1.SelectedIndex = studios.Count - 1;
            richTextBox1.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = Color.Green;
            resultLabel.Text =
                $"Створено копію студії {originName} із назвою {studios[comboBox1.SelectedIndex].getName()}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddInstrument addInstrument = new AddInstrument();
            addInstrument.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (SelectedStudio != null)
            {
                SelectRoom selectRoom = new SelectRoom();
                selectRoom.Show();
                richTextBox1.Text = SelectedStudio.ToString();
            }
        }

        private void clearField()
        {
            textBoxName.Text = string.Empty;
            textBoxAdress.Text = string.Empty;

            textBoxTrackPrice.Text = string.Empty;
            textBoxTrackTime.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (SelectedStudio != null)
            {
                SelectWorker selectWorker = new SelectWorker();
                selectWorker.Show();
                richTextBox1.Text = SelectedStudio.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (SelectedStudio != null)
            {
                SelectInstrument selectInstrument = new SelectInstrument();
                selectInstrument.Show();
                richTextBox1.Text = SelectedStudio.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            string result = "";

            if (comboBox2.SelectedIndex >= 0)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        var filePaths = Directory.GetFiles(folderName, "Workers.txt");

                        foreach (string path in filePaths)
                        {
                            string json = File.ReadAllText(path);
                            if (!string.IsNullOrEmpty(json))
                            {
                                workers.Clear();
                                workers.AddRange(JsonConvert.DeserializeObject<List<Worker>>(json));
                            }
                        }

                        foreach (var worker in workers)
                        {
                            result += worker.ToString() + "\n";
                        }
                        richTextBox1.Text = result;
                        richTextBox1.Update();
                        break;
                    case 1:
                        var filePathsI = Directory.GetFiles(folderName, "Instruments.txt");

                        foreach (string path in filePathsI)
                        {
                            string json = File.ReadAllText(path);
                            if (!string.IsNullOrEmpty(json))
                            {
                                instruments.Clear();
                                instruments.AddRange(
                                    JsonConvert.DeserializeObject<List<Instrument>>(json)
                                );
                            }
                        }
                        foreach (var instrument in instruments)
                        {
                            result += instrument.ToString() + "\n";
                        }
                        richTextBox1.Text = result;
                        richTextBox1.Update();
                        break;
                    case 2:
                        var filePathsR = Directory.GetFiles(folderName, "Rooms.txt");

                        foreach (string path in filePathsR)
                        {
                            string json = File.ReadAllText(path);
                            if (!string.IsNullOrEmpty(json))
                            {
                                rooms.Clear();
                                rooms.AddRange(JsonConvert.DeserializeObject<List<Room>>(json));
                            }
                        }
                        foreach (var room in rooms)
                        {
                            result += room.ToString() + "\n";
                        }
                        richTextBox1.Text = result;
                        richTextBox1.Update();
                        break;
                }
            }
        }
    }
}
