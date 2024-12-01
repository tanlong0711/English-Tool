
namespace EnglishRandomTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt.Font = new Font("Arial", 24);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
            };
            string[] day2 =
            {
            };
            string[] day3 =
            {
            };
            string[] day4 =
            {
            };
            string[] day5 =
            {
            };
            string[] day6 = 
            {
            };
            string[] day7 =
            {
            };
            string[] day8 =
            {
            };
            string[] day9 =
            {
            };
            string[] day10 = 
            {
            };
            string[] day11 =
            {
            };
            string[] day12 =
            {
            };
            string[] day13 =
            {
            };
            string[] day14 =
            {
            };
            string[] dayt15 =
            {
            };
            string[] day16 =
            {
            };
            string[] day17 =
            {
            };
            string[] day18 =
            {
            };
                    
            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day8, day9, day10, day11, day12, day13, day14, dayt15, day16);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
            };
            string[] day2 =
            {
            };
            string[] day3 =
            {
            };
            string[] day4 =
            {
            };
            string[] day5 =
            {
            };
            string[] day6 = 
            {
            };
            string[] day7 =
            {
            };
            string[] day8 =
            {
            };
            string[] day9 =
            {
            };
            string[] day10 =
            {
            };
            string[] day11 =
            {
            };
            string[] day12 =
            {
            };
            string[] day13 =
            {
            };
            string[] day14 =
            {
            };
            string[] day15 =
            {
            };
            string[] day16 =
            {
            };
            string[] day17 =
            {
            };
            string[] day18 =
            {
            };
            string[] day19 =
            {
            };
            string[] day20 =
            {
            };
            string[] day21 =
            {
            };
            string[] day22 =
            {
            };
                
            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }
    }
}
