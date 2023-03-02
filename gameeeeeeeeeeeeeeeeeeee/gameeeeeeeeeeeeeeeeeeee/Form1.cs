using System.Security.Cryptography.Pkcs;

namespace gameeeeeeeeeeeeeeeeeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = random.Next(2, 12);
            label1.Text = "Игрок №1\nвыбросил число: " + Convert.ToString(p1);
            StreamWriter write_text;
            FileInfo file = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p1.txt");
            write_text = file.AppendText();
            write_text.WriteLine(p1);
            write_text.Close();
            label3.Text = "Ход игрока №2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"p2", "");
            int p2 = random.Next(2, 12);
            label2.Text = "Игрок №2\nвыбросил число: " + Convert.ToString(p2);
            StreamWriter write_text;
            FileInfo file = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p2.txt");
            write_text = file.AppendText();
            write_text.WriteLine(p2);
            write_text.Close();
            label3.Text = "Подсчёт\nрезультатов...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Игрок №1";
            label2.Text = "Игрок №2";
            FileInfo file = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p1.txt");
            file.Delete();
            FileInfo file2 = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p2.txt");
            file2.Delete();

            label3.Text = "Ход игрока №1";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p1.txt");
            StreamReader stream1 = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p2.txt");


            string a = @"I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p1.txt";
            string b = File.ReadAllText(a);

            string a1 = @"I:\\244-ИСП\\244ИСП\\ОАиП\\Сергеев\\gameeeeeeeeeeeeeeeeeeee\\p2.txt";
            string b1 = File.ReadAllText(a1);

            int player1 = 0 + Convert.ToInt32(b);
            int player2 = 0 + Convert.ToInt32(b1);
            if (player1 > player2)
            {
                label3.Text = "Выйграл игрок №1\nИгрок №1 выбросил: " + player1 + "\nИгрок №2 выбросил: " + player2;
            }
            else if (player2 > player1)
            {
                label3.Text = "Выйграл игрок №2\nИгрок №1 выбросил: "+player1 + "\nИгрок №2 выбросил: " +player2;
            }
            else
            {
                label3.Text = "Игра сыграна в ничью!\nИгрок №1 выбросил: "+player1 + "\nИгрок №2 выбросил: " +player2;
            }
            stream.Close();
            stream1.Close();
        }
    }
}