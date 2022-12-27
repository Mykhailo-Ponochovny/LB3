using LB2.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

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
            if (textBox2.Text.Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть ПІБ",
                    "Помилка, поле не може бути пустим",
                    MessageBoxButtons.OK
                );
                return;
            }

            if (textBox3.Text.Length == 0 || textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть зарплатню",
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
                    num = Convert.ToInt32(textBox3.Text);
                }
                catch (Exception)
                {
                    textBox3.Text = string.Empty;
                    MessageBox.Show(
                        "Уводьте лише числа",
                        "Помилка, уводьте лише числа",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                if (num < 0)
                {
                    textBox3.Text = string.Empty;
                    MessageBox.Show(
                        "Вартість не може бути від'ємною",
                        "Помилка, вартість не може бути від'ємною",
                        MessageBoxButtons.OK
                    );

                    return;
                }
            }
            if (textBox4.Text.Length == 0 || textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "Спочатку уведіть к-сть треків",
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
                    num = Convert.ToInt32(textBox4.Text);
                }
                catch (Exception)
                {
                    textBox4.Text = string.Empty;
                    MessageBox.Show(
                        "Уводьте лише числа",
                        "Помилка, уводьте лише числа",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                if (num < 0)
                {
                    textBox4.Text = string.Empty;
                    MessageBox.Show(
                        "К-сть не може бути від'ємною",
                        "Помилка, вартість не може бути від'ємною",
                        MessageBoxButtons.OK
                    );

                    return;
                }

                string projectPath = Directory
                    .GetParent(Directory.GetCurrentDirectory())
                    .Parent.FullName;
                string folderName = Path.Combine(projectPath, "Studio");
                var filePaths = Directory.GetFiles(folderName, "Workers.txt");

                List<Worker> workers = new List<Worker> { };

                foreach (string path in filePaths)
                {
                    string json = File.ReadAllText(path);
                    if (!string.IsNullOrEmpty(json))
                        workers.AddRange(JsonConvert.DeserializeObject<List<Worker>>(json));
                }

                workers.Add(
                    new Worker(
                        textBox1.Text,
                        textBox2.Text,
                        double.Parse(textBox3.Text),
                        int.Parse(textBox4.Text)
                    )
                );
                string pathData = Path.Combine(folderName, "Workers.txt");
                string jsonData = JsonConvert.SerializeObject(workers);
                File.WriteAllText(pathData, jsonData);
                Close();
            }
        }
    }
}
