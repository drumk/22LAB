using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, n, minZn, maxZn, max;
            int[,] a = new int[100, 100];
            //считывание размерности массива
            n = Convert.ToInt32(comboBox1.Text);
            //задание количества столбцов и строк таблицы
            dataGridView1.RowCount = n + 1; dataGridView1.ColumnCount = n + 1;
            //считывание макс. и мин. значений элементов массива
            minZn = Convert.ToInt32(comboBox2.Text);
            maxZn = Convert.ToInt32(comboBox3.Text);
            //задание ширины и высоты сетки от числа строк и столбцов массива
            dataGridView1.Width = 135 * (n + 1);
            dataGridView1.Height = 33 * (n + 1);
            //очистка таблицы
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                { dataGridView1.Rows[i].Cells[j].Value = " "; }
            }
            //очистка предыдущего расчёта
            label4.Text = "max элемент главной диагонали = ";
            Random rnd = new Random();
            for (i = 1; i <= n; i++)
            {//задание элементов a[I,j] и выдача их в сетку
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = rnd.Next(minZn, maxZn);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
            //нумерация строк и столбцов
            for (i = 1; i <= n; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i);
            }
            for (j = 1; j <= n; j++)
            {
                dataGridView1.Rows[0].Cells[j].Value = Convert.ToString(j);

            }
            
            // подсчет max элемента главной диагонали

            max = Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value);
            n = Convert.ToInt32(comboBox1.Text);
            for (i = 1; i <= n; i++)
            {
                if (max < Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value))
                {
                    max = Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value);
                }
            }
            label4.Text = "max элемент главной диагонали = " + Convert.ToString(max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            // задание списков ComboBox1-4
            for (i = 1; i <= 7; i++)
            {
                comboBox1.Items.Add(Convert.ToString(i + 1));
                comboBox2.Items.Add(Convert.ToString(i - 15));
                comboBox3.Items.Add(Convert.ToString(i));

            }
        }
    }
}