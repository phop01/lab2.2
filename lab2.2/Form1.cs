namespace lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int arr_index = 0;
        string[] arrid = new string[1000];
        string[] arrname = new string[1000];
        int[] arrscore = new int[1000];

        //
        int[] c_score = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_idx, max_value, min_value, min_idx;
        // arr ?????????????????? ??.?????? A ????? n * 4 + ??? B+ ????? n * 3.5 ..... ?????????
        float[] all_grade = new float[8];

        // ?????????????????? A  , B  , C , D , F ???????????????
        int[] n_grade = new int[8];

        private void save_button_Click(object sender, EventArgs e)
        {
            arrid[arr_index] = text_id_student.Text;
            arrname[arr_index] = text_name.Text;
            arrscore[arr_index] = int.Parse(text_point.Text);

            arr_index++;
            text_name.Text = "";
            text_id_student.Text = "";
            text_point.Text = string.Empty;

            max_value = arrscore.Max();
            max_idx = arrscore.ToList().IndexOf(max_value);
            //max
            student_max.Text = $"{arrid[max_idx]}";
            name_max.Text = $"{arrname[max_idx]}";
            socre_max.Text = $"{arrscore[max_idx]}";
            //find min value by c_arr and length
            c_score = new int[arr_index];
            stop = arr_index;
            sub_arr_length = stop;
            Array.Copy(arrscore, start, c_score, 0, sub_arr_length);
            min_value = c_score.Min();
            
            min_idx = arrscore.ToList().IndexOf(min_value);
            //min
            student_min.Text = $"{arrid[min_idx]}";
            name_min.Text = $"{arrname[min_idx]}";
            socre_min.Text = $"{arrscore[min_idx]}";
            //
            avg_point.Text = $"{(double)arrscore.Sum() / (double)arr_index:0.00}";
            //
            int point = arrscore[arr_index - 1];
            if (point >= 80 && point <= 100)
            {
                // n of A 
                n_grade[0] += 1;
                textBox_A.Text = n_grade[0].ToString();
                all_grade[0] = n_grade[0] * 4;

            }
            else if (point >= 75 && point <= 79)
            {
                // n of B+
                n_grade[1] += 1;
                textBox_B_pass.Text = n_grade[1].ToString();
                all_grade[1] = n_grade[1] * 3.5f;
            }
            else if (point >= 70 && point <= 74)
            {
                // n of B
                n_grade[2] += 1;
                textBox_B.Text = n_grade[2].ToString();
                all_grade[2] = n_grade[2] * 3.0f;

            }
            else if (point >= 65 && point <= 69)
            {
                // C+
                n_grade[3] += 1;
                textBox_C_pass.Text = n_grade[3].ToString();
                all_grade[3] = n_grade[3] * 2.5f;
            }
            else if (point >= 60 && point <= 64)
            {
                // C
                n_grade[4] += 1;
                textBox_C.Text = n_grade[4].ToString();
                all_grade[4] = n_grade[4] * 2.0f;
            }
            else if (point >= 55 && point <= 59)
            {
                // D+
                n_grade[5] += 1;
                textBox_D_pass.Text = n_grade[5].ToString();
                all_grade[5] = n_grade[5] * 1.5f;
            }
            else if (point >= 50 && point <= 54)
            {
                //D
                n_grade[6] += 1;
                textBox_D.Text = n_grade[6].ToString();
                all_grade[6] = n_grade[6] * 1.0f;
            }
            else
            {
                //F
                n_grade[7] += 1;
                textBox_F.Text = n_grade[7].ToString();
            }

            text_avg.Text = $"{(double)all_grade.Sum() / (double)arr_index:0.00}";



        }
    }
}
