using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LB2.models
{
    public partial class AddInstrument : Form
    {
        public AddInstrument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть ID",
                    "Помилка, поле не можу бути пустим",
                    MessageBoxButtons.OK
                );
                return;
            }

            if (textBox2.Text.Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть вартість",
                    "Помилка, поле не можу бути пустим",
                    MessageBoxButtons.OK
                );
                return;
            }
            else
            {
                int num;
                try
                {
                    num = Convert.ToInt32(textBox2.Text);
                }
                catch (Exception)
                {
                    textBox2.Text = string.Empty;
                    MessageBox.Show(
                        "Уводьте лише числа",
                        "Помилка, уводьте лише числа",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                if (num < 0)
                {
                    textBox2.Text = string.Empty;
                    MessageBox.Show(
                        "Вартість не може бути від'ємною",
                        "Помилка, вартість не може бути від'ємною",
                        MessageBoxButtons.OK
                    );

                    return;
                }
            }
            if (comboBox1.SelectedIndex != -1)
            {
                string projectPath = Directory
                    .GetParent(Directory.GetCurrentDirectory())
                    .Parent.FullName;
                string folderName = Path.Combine(projectPath, "Studio");
                var filePaths = Directory.GetFiles(folderName, "Instruments.txt");

                List<Instrument> instruments = new List<Instrument> { };

                foreach (string path in filePaths)
                {
                    string json = File.ReadAllText(path);
                    if (!string.IsNullOrEmpty(json))
                        instruments.AddRange(JsonConvert.DeserializeObject<List<Instrument>>(json));
                }

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.drum,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 1:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.bassGuitar,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;

                    case 2:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.rhythmGuitar,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 3:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.leadGuitar,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 4:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.synthesizer,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 5:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.piano,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 6:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.saxophone,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 7:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.violoncello,
                                double.Parse(textBox2.Text)
                            )
                        );
                        break;
                    case 8:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.violin,
                                double.Parse(textBox2.Text)
                            )
                        );

                        break;
                    case 9:
                        instruments.Add(
                            new Instrument(
                                textBox1.Text,
                                TypeOfInstrument.accordion,
                                double.Parse(textBox2.Text)
                            )
                        );

                        break;
                }

                string pathData = Path.Combine(folderName, "Instruments.txt");
                string jsonData = JsonConvert.SerializeObject(instruments);
                File.WriteAllText(pathData, jsonData);
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Виберіть тип інструменту",
                    "Помилка, виберіть тип інструменту",
                    MessageBoxButtons.OK
                );

                return;
            }
        }

        private void AddInstrument_Load(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
