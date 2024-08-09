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
            //���������� ����������� �������
            n = Convert.ToInt32(comboBox1.Text);
            //������� ���������� �������� � ����� �������
            dataGridView1.RowCount = n + 1; dataGridView1.ColumnCount = n + 1;
            //���������� ����. � ���. �������� ��������� �������
            minZn = Convert.ToInt32(comboBox2.Text);
            maxZn = Convert.ToInt32(comboBox3.Text);
            //������� ������ � ������ ����� �� ����� ����� � �������� �������
            dataGridView1.Width = 135 * (n + 1);
            dataGridView1.Height = 33 * (n + 1);
            //������� �������
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                { dataGridView1.Rows[i].Cells[j].Value = " "; }
            }
            //������� ����������� �������
            label4.Text = "max ������� ������� ��������� = ";
            Random rnd = new Random();
            for (i = 1; i <= n; i++)
            {//������� ��������� a[I,j] � ������ �� � �����
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = rnd.Next(minZn, maxZn);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
            //��������� ����� � ��������
            for (i = 1; i <= n; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i);
            }
            for (j = 1; j <= n; j++)
            {
                dataGridView1.Rows[0].Cells[j].Value = Convert.ToString(j);

            }
            
            // ������� max �������� ������� ���������

            max = Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value);
            n = Convert.ToInt32(comboBox1.Text);
            for (i = 1; i <= n; i++)
            {
                if (max < Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value))
                {
                    max = Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value);
                }
            }
            label4.Text = "max ������� ������� ��������� = " + Convert.ToString(max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            // ������� ������� ComboBox1-4
            for (i = 1; i <= 7; i++)
            {
                comboBox1.Items.Add(Convert.ToString(i + 1));
                comboBox2.Items.Add(Convert.ToString(i - 15));
                comboBox3.Items.Add(Convert.ToString(i));

            }
        }
    }
}