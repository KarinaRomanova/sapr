using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace spr
{
    public partial class Form1 : Form
    {
        bool nodes_ready, sealings_ready, rod_ready, cut_ready, load_ready, node_loads_ready, rod_loads_ready = false;

        int[,] node_coord;
        int[,] rod_coord;
        int[,] node_loads;
        int[,] rod_loads;
        int[] cut_k;
        int[,] sealings;
        string saved_sealings, saved_nodes, saved_rod, saved_cut, saved_load, saved_nodes_load, saved_rods_load;
        public static int nodes_summ;
        public static int empty_nodes_load;
        public static int empty_sealings;
        public static int empty_rod_load;
        public static int rod_summ;
        public static int to_i = 1;
        int saved_notes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void nodes_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                start_menu();
                if (node_coord != null)
                {
                    Array.Clear(node_coord);
                }
                nodes_ready = false;
                result.Text = null;
                nodes_menu();

            }
            else
            {
                start_menu();
                main_label.Text = "Для изменения нажмите СБРОС";
                result.Text = saved_nodes;
                reset_button.Visible = true;
                result.Visible = true;
                main_label.Visible = true;
            }
        }
        private void start_menu()
        {
            ready2.Visible = false;
            z.Visible = false;
            ready.Visible = false;
            sealings_clear.Visible = false;
            reset_button.Visible = false;
            x_coord.Text = null;
            y_coord.Text = null;
            result.Visible = false;
            result_qx.Visible = false;
            main_label.Visible = false;
            textBox1.Visible = false;
            second_y.Visible = false;
            second_label.Visible = false;
            second_x.Visible = false;
            qx.Visible = false;
            second_save.Visible = false;
            qy.Visible = false;
            OK.Visible = false;
            reset_button_1.Visible = false;
            x_coord.Visible = false;
            save.Visible = false;
            button1.Visible = false;
            loads_clear.Visible = false;
            y_coord.Visible = false;
            to_i = 1;
        }
        void reset_menu()
        {
            saved_sealings= saved_nodes= saved_rod= saved_cut= saved_load= saved_nodes_load= saved_rods_load = "";
             nodes_ready= sealings_ready= rod_ready=cut_ready= load_ready= node_loads_ready= rod_loads_ready = false;
            
            try
            {
                Array.Clear(node_coord);
                Array.Clear(rod_coord);
                Array.Clear(node_loads);
                Array.Clear(rod_loads);
                Array.Clear(cut_k);
                Array.Clear(sealings);
            }
            catch(ArgumentNullException e)
            {

            }

        }
        private void nodes_menu()
        {
            start_menu();
            main_label.Visible = true;
            textBox1.Visible = true;
            OK.Visible = true;
            main_label.Text = "Введите количество узлов";


        }

        private void OK_Click(object sender, EventArgs e)
        {

            if (Int32.Parse(textBox1.Text) < 2)
            {
                MessageBox.Show("Не менее 2 узлов!");
                return;
            }
            nodes_summ = Int32.Parse(textBox1.Text);

            rod_summ = nodes_summ - 1;
            start_menu();
            x_coord.Visible = true;
            y_coord.Visible = true;
            save.Visible = true;
            main_label.Visible = true;
            main_label.Text = "Введите координаты " + to_i + " узла";
            node_coord = new int[nodes_summ, 3];
            rod_coord = new int[rod_summ, 3];
            cut_k = new int[rod_summ];
            node_loads = new int[nodes_summ, 3];
            rod_loads = new int[rod_summ, 3];
            sealings = new int[nodes_summ, 4];
            result.Visible = true;
            result.Text = "N    x    y";
            textBox1.Text = null;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            start_menu();
        }



        private void save_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                if (to_i < nodes_summ)
                {
                    try
                    {
                        node_coord[to_i - 1, 0] = to_i;
                        node_coord[to_i - 1, 1] = int.Parse(x_coord.Text);
                        node_coord[to_i - 1, 2] = int.Parse(y_coord.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите число!");
                        return;

                    }

                    result.Text += "\n" + to_i + "    " + x_coord.Text + "    " + y_coord.Text;
                    reset_button.Visible = true;

                    x_coord.Text = null;
                    y_coord.Text = null;

                    to_i++;
                    main_label.Text = "Введите координаты " + to_i + " узла";


                }
                else if (to_i == nodes_summ)
                {
                    try
                    {
                        node_coord[to_i - 1, 0] = to_i;
                        node_coord[to_i - 1, 1] = int.Parse(x_coord.Text);
                        node_coord[to_i - 1, 2] = int.Parse(y_coord.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите число!");
                        return;
                    }
                    result.Text += "\n" + to_i + "    " + x_coord.Text + "    " + y_coord.Text;
                    nodes_ready = true;
                    saved_nodes = result.Text;
                    main_label.Text = "Для изменения нажмите СБРОС";
                    save.Visible = false;
                    x_coord.Visible = false;
                    y_coord.Visible = false;


                }
            }
            else if (!rod_ready)
            {
                if ((int.Parse(y_coord.Text) >= 1) && (int.Parse(x_coord.Text) >= 1) && (int.Parse(x_coord.Text) <= nodes_summ) && (int.Parse(y_coord.Text) <= nodes_summ) && int.Parse(y_coord.Text) != int.Parse(x_coord.Text))
                {
                    if (to_i < rod_summ)

                    {
                        try
                        {
                            rod_coord[to_i - 1, 0] = to_i;
                            rod_coord[to_i - 1, 1] = int.Parse(x_coord.Text);
                            rod_coord[to_i - 1, 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;

                        }

                        result.Text += "\n" + to_i + "    " + x_coord.Text + "    " + y_coord.Text;
                        reset_button.Visible = true;

                        x_coord.Text = null;
                        y_coord.Text = null;

                        to_i++;
                        main_label.Text = "Введите узлы " + to_i + " стержня";
                        reset_button_1.Visible = true;

                    }
                    else if (to_i == rod_summ)
                    {
                        try
                        {
                            rod_coord[to_i - 1, 0] = to_i;
                            rod_coord[to_i - 1, 1] = int.Parse(x_coord.Text);
                            rod_coord[to_i - 1, 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }
                        result.Text += "\n" + to_i + "    " + x_coord.Text + "    " + y_coord.Text;
                        rod_ready = true;
                        saved_rod = result.Text;
                        main_label.Text = "Для изменения нажмите СБРОС";
                        save.Visible = false;
                        x_coord.Visible = false;
                        y_coord.Visible = false;
                        reset_button_1.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Некорректное значение узлов!");
                    return;
                }

            }
            else if (!cut_ready)
            {
                if (to_i < rod_summ)
                {
                    try
                    {
                        cut_k[to_i - 1] = Int32.Parse(textBox1.Text);
                        result.Text += "\n" + to_i + "    " + Int32.Parse(textBox1.Text);
                        to_i++;
                        main_label.Text = "Введите k для " + to_i + "стержня";
                        textBox1.Text = null;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите число!");
                    }
                }
                else if (to_i == rod_summ)
                {
                    cut_k[to_i - 1] = Int32.Parse(textBox1.Text);
                    result.Text += "\n" + to_i + "    " + Int32.Parse(textBox1.Text);
                    main_label.Text = "Введите k для " + to_i + "стержня";
                    textBox1.Visible = false;
                    save.Visible = false;
                    main_label.Text = "Для изменения нажмите СБРОС";
                    saved_cut = result.Text;
                    cut_ready = true;
                }
            }
            else if (!load_ready)
            {
                if (( (int.Parse(x_coord.Text) >= 1) && (int.Parse(x_coord.Text) <= nodes_summ)))
                {
                    if (empty_nodes_load > 1 && !node_loads_ready)
                    {

                        try
                        {

                            empty_nodes_load--;
                            result_qx.Text += "\n" + x_coord.Text + "   " + Int32.Parse(second_y.Text) + "   " + Int32.Parse(y_coord.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 0] = int.Parse(x_coord.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 1] = int.Parse(second_y.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }


                    }
                    else if (empty_nodes_load == 1)

                    {
                        try
                        {

                            empty_nodes_load--;
                            result_qx.Text += "\n" + x_coord.Text + "   " + Int32.Parse(second_y.Text) + "   " + Int32.Parse(y_coord.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 0] = int.Parse(x_coord.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 1] = int.Parse(second_y.Text);
                            node_loads[nodes_summ - (empty_nodes_load + 1), 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }

                        x_coord.Visible = second_y.Visible = y_coord.Visible = false;
                        save.Visible = false;
                        saved_nodes_load = result_qx.Text;
                        main_label.Text = "Для изменения нажмите СБРОС";

                        node_loads_ready = true;
                        if (rod_loads_ready)
                        {
                            load_ready = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректные значения!");
                }
            }
            else if (!sealings_ready)
            {
                if (((int.Parse(x_coord.Text) >= 1) &&(int.Parse(y_coord.Text) == 1 || int.Parse(y_coord.Text) == 0) && (int.Parse(second_y.Text) == 1 || int.Parse(second_y.Text) == 0) && (int.Parse(z.Text) == 1 || int.Parse(z.Text) == 0) && (int.Parse(x_coord.Text) <= nodes_summ))) {
                    if (empty_sealings > 1)
                    {

                        try
                        {

                            empty_sealings--;
                            result.Text += "\n" + x_coord.Text + "   " + Int32.Parse(second_y.Text) + "   " + Int32.Parse(y_coord.Text) + "   " + Int32.Parse(z.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 0] = int.Parse(x_coord.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 1] = int.Parse(second_y.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 2] = int.Parse(y_coord.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 3] = int.Parse(z.Text);
                            x_coord.Text = second_y.Text = y_coord.Text = z.Text = "";
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }


                    }
                    else if (empty_sealings == 1)

                    {

                        try
                        {

                            empty_sealings--;
                            result.Text += "\n" + x_coord.Text + "   " + Int32.Parse(second_y.Text) + "   " + Int32.Parse(y_coord.Text) + "   " + Int32.Parse(z.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 0] = int.Parse(x_coord.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 1] = int.Parse(second_y.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 2] = int.Parse(y_coord.Text);
                            sealings[nodes_summ - (empty_sealings + 1), 3] = int.Parse(z.Text);
                            x_coord.Text = second_y.Text = y_coord.Text = "";
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }




                        x_coord.Visible = ready2.Visible = second_y.Visible = y_coord.Visible = z.Visible = false;
                        save.Visible = false;
                        sealings_ready = true;
                        ready2.Visible = false;
                        
                        main_label.Text = "Для изменения нажмите СБРОС";

                    }
                    
                }
                else
                {
                    MessageBox.Show("Введите корректные значения!");
                }
            }

        }
    


        private void second_save_Click(object sender, EventArgs e)
        {
            if (((int.Parse(second_x.Text) >= 1) && (int.Parse(second_x.Text) <= rod_summ))) {
                if (!load_ready)
                {
                    if (empty_rod_load > 1 && !node_loads_ready)
                    {

                        try
                        {

                            empty_rod_load--;
                            result.Text += "\n" + second_x.Text + "   " + Int32.Parse(qx.Text) + "   " + Int32.Parse(qy.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 0] = int.Parse(x_coord.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 1] = int.Parse(second_y.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }


                    }
                    else if (empty_rod_load == 1)

                    {
                        try
                        {

                            empty_rod_load--;
                            result.Text += "\n" + second_x.Text + "   " + Int32.Parse(qx.Text) + "   " + Int32.Parse(qy.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 0] = int.Parse(x_coord.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 1] = int.Parse(second_y.Text);
                            rod_loads[rod_summ - (empty_rod_load + 1), 2] = int.Parse(y_coord.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введите число!");
                            return;
                        }

                        qx.Visible = second_x.Visible = qy.Visible = false;
                        second_save.Visible = false;
                        second_label.Visible = false;
                        saved_rods_load = result.Text;
                        rod_loads_ready = true;
                        if (node_loads_ready)
                        {
                            load_ready = true;
                        }
                    } }
                else
                {
                    MessageBox.Show("Введите корректные значения!");
                }
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                MessageBox.Show("Введите все узлы!");
                return;
            }
            else if (!rod_ready)
            {
                MessageBox.Show("Введите все стержни!");
                return;
            }
            else if (!cut_ready)
            {
                start_menu();
                to_i = 1;
                main_label.Text = "Введите k для " + to_i + "стержня";
                textBox1.Visible = true;
                main_label.Visible = true;
                save.Visible = true;
                result.Visible = true;

                result.Text = "N    k";
                button1.Visible = true;
            }
            else if (cut_ready)
            {
                start_menu();
                main_label.Text = "Для изменения нажмите СБРОС";
                result.Visible = true;
                result.Text = saved_cut;
                button1.Visible = true;
                main_label.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_menu();
            Array.Clear(cut_k);
            cut_ready = false;
            result.Text = null;

        }

        private void reset_button_Click_1(object sender, EventArgs e)
        {
            start_menu();
            Array.Clear(node_coord);
            Array.Clear(rod_coord);
            nodes_ready = false;
            result.Text = null;
        }

        private void rods_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                MessageBox.Show("Введите все узлы!");
                return;
            }
            else if (!rod_ready)
            {
                start_menu();
                to_i = 1;
                x_coord.Visible = true;
                y_coord.Visible = true;
                save.Visible = true;
                main_label.Visible = true;
                main_label.Text = "Введите узлы " + to_i + " стержня";
                result.Text = "N    S    E";
                result.Visible = true;
            }
            else if (rod_ready)
            {
                start_menu();
                main_label.Text = "Для изменения нажмите СБРОС";
                result.Text = saved_rod;
                reset_button_1.Visible = true;
                result.Visible = true;
                main_label.Visible = true;
            }
        }


        private void reset_button_1_Click(object sender, EventArgs e)
        {
            start_menu();
            Array.Clear(rod_coord);
            rod_ready = false;
            result.Text = null;
        }



        private void sealing_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                MessageBox.Show("Введите все узлы!");
                return;
            }
            else if (!rod_ready)
            {
                MessageBox.Show("Введите все стержни!");
                return;
            }
            else if (!cut_ready)
            {
                MessageBox.Show("Введите все сечения!");
                return;
            }
            else if (!load_ready)
            {

                MessageBox.Show("Введите все нагрузки!");
                return;


            }
            else if (!sealings_ready)
            {

                start_menu();
                main_label.Text = "Введите номер узла и параметры k заделки";
                empty_sealings = nodes_summ;
                result.Visible = main_label.Visible = x_coord.Visible = save.Visible = second_y.Visible = y_coord.Visible = z.Visible = ready2.Visible = true;
                x_coord.Text = second_y.Text = y_coord.Text = z.Text = "";
                result.Text = "N   k1   k2   k3";

            }
            else if (sealings_ready)
            {
                start_menu();
                main_label.Text = "Для изменения нажмите СБРОС";
                result.Text = saved_sealings;
                sealings_clear.Visible = true;
                result.Visible = true;
                main_label.Visible = true;
                ready2.Visible = false;
            }
        }

        private void loads_clear_Click(object sender, EventArgs e)
        {
            start_menu();
            Array.Clear(rod_loads);
            Array.Clear(node_loads);
            load_ready = false;
            node_loads_ready = false;
            rod_loads_ready = false;
            result.Text = null;
        }
        private void sealings_clear_Click(object sender, EventArgs e)
        {
            start_menu();
            Array.Clear(sealings);

            sealings_ready = false;

            result.Text = null;
        }
        private void ready_Click(object sender, EventArgs e)
        {
            node_loads_ready = rod_loads_ready = load_ready = true;
            ready.Visible = false;
            saved_nodes_load = result_qx.Text;
            saved_rods_load = result.Text;
            start_menu();
            main_label.Text = "Для изменения нажмите СБРОС";

        }

 
        
        String path = @"C:\Users\roman\Downloads\1.txt";
        private void Save_File_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                saveFileDialog1.ShowDialog();
                path = saveFileDialog1.FileName;
                using (StreamWriter stream = new StreamWriter(path, true))
                {
                    if (nodes_ready)
                    {
                        stream.WriteLine("node_coord");
                        stream.WriteLine(nodes_summ);
                        for (int i = 0; i < nodes_summ; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                stream.Write("{0}\t", node_coord[i, j]);
                            }
                            stream.WriteLine();
                        }
                    }
                    if (rod_ready)
                    {
                        stream.WriteLine("rod_coord");
                        for (int i = 0; i < rod_summ; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                stream.Write("{0}\t", rod_coord[i, j]);
                            }
                            stream.WriteLine();
                        }
                    }
                    if (cut_ready)
                    {
                        stream.WriteLine("cut_k");
                        for (int i = 0; i < rod_summ; i++)
                        {

                            stream.Write("{0}\t", cut_k[i]);

                            stream.WriteLine();
                        }
                    }

                    if (load_ready)
                    {
                        stream.WriteLine("node_loads");
                        for (int i = 0; i < nodes_summ; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                stream.Write("{0}\t", node_coord[i, j]);
                            }
                            stream.WriteLine();
                        }
                        stream.WriteLine("rod_loads");
                        for (int i = 0; i < rod_summ; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                stream.Write("{0}\t", rod_loads[i, j]);
                            }
                            stream.WriteLine();
                        }
                    }
                    if (sealings_ready)
                    {
                        stream.WriteLine("sealings");
                        for (int i = 0; i < nodes_summ; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                MessageBox.Show(sealings[i, j] + "");
                                stream.Write("{0}\t", sealings[i, j]);
                            }
                            stream.WriteLine();
                        }
                    }
                }
            }


        } 
        

        private void ready2_Click(object sender, EventArgs e)
        {
            start_menu();
            main_label.Text = "Для изменения нажмите СБРОС";
            result.Text = saved_sealings;
            sealings_clear.Visible = true;
            sealings_ready = true;
            result.Visible = true;
            main_label.Visible = true;
        }
    
        private async void Open_File_Click(object sender, EventArgs e)
        {    var fileContent = string.Empty;
        var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    start_menu();
                    reset_menu();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        String varr="";
                        string? line;
                        int i = 0;
                        int j = 0;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                         
                            if (line.Equals("node_coord") || !nodes_ready)
                            {
                                
                                nodes_ready = true;
                                line = await reader.ReadLineAsync();
                              
                                foreach (char k in line)
                                {
                                    if (k != '\n')
                                    {
                                        varr += k;
                                    }
                                }

                                try { nodes_summ = Int32.Parse(varr); }
                                catch (ArithmeticException u)
                                {
                                    MessageBox.Show("Ошибка арифметики");
                                }
                                varr = "";
                                node_coord = new int[nodes_summ, 3];
                                line = await reader.ReadLineAsync();
                               
                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        saved_nodes += k;
                                        varr += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_nodes += "   ";
                                        try { node_coord[i, j] = Int32.Parse(varr); }
                                        catch(Exception gg)
                                        {
                                            MessageBox.Show("im crying");
                                        }
                                        varr = "";
                                        j++;
                                        if (j == 3)
                                        {
                                            saved_nodes += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }


                                }

                            }
                            else if (nodes_ready && !line.Equals("rod_coord")  && !rod_ready)
                            {   
                                varr = "";
                                

                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        saved_nodes += k;
                                        varr += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_nodes += "   ";
                                        if (i < nodes_summ && j < 3)
                                        {
                                            node_coord[i, j] = Int32.Parse(varr);
                                            varr = "";
                                        j++;
                                        }
                                        
                                        
                                        if (j == 3)
                                        {
                                            saved_nodes += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }
                                   

                                }
                            }
                            else if (line.Equals("rod_coord"))
                            {
                                
                                varr = "";

                                i = j = 0;
                                rod_summ = nodes_summ-1;
                                rod_ready = true;
                                rod_coord = new int[rod_summ, 3];



                            }
                            else if (rod_ready && !line.Equals("cut_k")&& !cut_ready)
                            {
                               
                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        saved_rod += k;
                                        varr += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_rod += "   ";
                                        if (i < rod_summ && j < 3)
                                        {
                                            try { rod_coord[i, j] = Int32.Parse(varr); }
                                            catch( Exception rod_ex)
                                            {
                                                MessageBox.Show("File Error");
                                            }
                                            varr = "";
                                            j++;
                                        }


                                        if (j == 3)
                                        {
                                            saved_rod += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }


                                }
                            }
                            else if (line.Equals("cut_k"))
                            {
                                varr = "";

                                i = j = 0;
                               
                                cut_ready = true;
                                cut_k = new int [rod_summ];



                            }
                            else if (cut_ready && !line.Equals("node_loads") && !node_loads_ready)
                            {
                                saved_cut += line+"\n";

                                cut_k[i] = Int32.Parse(line);
                                        i++;



                                
                            }
                            else if (line.Equals("node_loads"))
                            {
                                varr = "";

                                i = j = 0;

                                node_loads_ready = true;
                                node_loads = new int[nodes_summ, 3];



                            }
                            else if (node_loads_ready && !line.Equals("rod_loads") && !line.Equals("sealings") && !rod_loads_ready && !sealings_ready)
                            {
                                
                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        saved_nodes_load +=k;
                                        varr += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_nodes_load += "   ";
                                        if (i < nodes_summ && j < 3)
                                        {
                                            try { node_loads[i, j] = Int32.Parse(varr); }
                                            catch (Exception rod_ex)
                                            {
                                                MessageBox.Show("File Error");
                                            }
                                            varr = "";
                                            j++;
                                        }


                                        if (j == 3)
                                        {
                                            saved_nodes_load += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }


                                }
                            }
                            else if (line.Equals("rod_loads"))
                            {
                                if (!node_loads_ready) { node_loads_ready = true;
                                node_loads = new int[nodes_summ, 3];}
                                varr = "";

                                i = j = 0;

                                rod_loads_ready = true;
                                rod_loads = new int[rod_summ, 3];



                            }
                            else if (rod_loads_ready && !line.Equals("rod_loads") && !line.Equals("sealings")  && !sealings_ready)
                            {
                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        saved_rods_load += k;
                                        varr += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_rods_load += "   ";
                                        if (i < rod_summ && j < 3)
                                        {
                                            try { rod_loads[i, j] = Int32.Parse(varr); }
                                            catch (Exception rod_ex)
                                            {
                                                MessageBox.Show("File Error");
                                            }
                                            varr = "";
                                            j++;
                                        }


                                        if (j == 3)
                                        {
                                            saved_rods_load += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }


                                }
                            }
                            else if (line.Equals("sealings"))
                            {
                                load_ready = true;
                                
                                if (!node_loads_ready )
                                {
                                    node_loads_ready = true;
                                    node_loads = new int[nodes_summ, 3];
                                }
                                if (!rod_loads_ready)
                                {
                                    rod_loads_ready = true;
                                    rod_loads = new int[rod_summ, 3];
                                }
                                varr = "";

                                i = j = 0;

                                sealings_ready = true;
                                sealings = new int[nodes_summ, 4];



                            }
                            else if (sealings_ready)
                            {
                                
                                foreach (char k in line)
                                {
                                    if (k != '\t' && k != '\n')
                                    {
                                        varr += k;
                                        saved_sealings += k;
                                    }
                                    else if (k == '\t')
                                    {
                                        saved_sealings += "   ";
                                        if (i < nodes_summ && j < 4)
                                        {
                                            try { sealings[i, j] = Int32.Parse(varr); }
                                            catch (Exception rod_ex)
                                            {
                                                MessageBox.Show("File Error");
                                            }
                                            varr = "";
                                            j++;
                                        }


                                        if (j == 4)
                                        {
                                            saved_sealings += "\n";
                                            i++;
                                            j = 0;
                                        }
                                    }


                                }
                            }

                        }
                       

                    }
                }
            }

        }

        private void Process_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рассчет произведен!");
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (!nodes_ready)
            {
                MessageBox.Show("Введите все узлы!");
                return;
            }
            else if (!rod_ready)
            {
                MessageBox.Show("Введите все стержни!");
                return;
            }
            else if (!cut_ready)
            {
                MessageBox.Show("Введите все сечения!");
                return;
            }
            else if (!load_ready)
            {


                start_menu();
                ready.Visible = true;
                result_qx.Text = "N  Qx  Qy";
                result.Text = "N  Fx  Fy";
                main_label.Text = "Введите номер узла и нагрузки";
                x_coord.Text = "N";
                second_y.Text = "Fx";
                y_coord.Text = "Fy";
                second_label.Text = "Введите номер стержня и нагрузки";
                second_x.Text = "N";
                qx.Text = "Qx";
                qy.Text = "Qy";
                empty_nodes_load = nodes_summ;
                empty_rod_load = rod_summ;
                main_label.Visible = x_coord.Visible = y_coord.Visible = second_y.Visible = save.Visible = second_label.Visible = second_x.Visible = qx.Visible = qy.Visible = second_save.Visible = result.Visible = result_qx.Visible =loads_clear.Visible= true;


            }
            else if (load_ready)
            {
               
                    start_menu();
                    main_label.Text = "Для изменения нажмите СБРОС";
                    result.Visible=result_qx.Visible = true;
                result_qx.Text = saved_nodes_load;
                result.Text = saved_rods_load;

                    button1.Visible = true;
                    main_label.Visible = true;

                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void x_coord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void y_coord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void second_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void second_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void qx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void qy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void second_x_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void z_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void qy_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void qx_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}