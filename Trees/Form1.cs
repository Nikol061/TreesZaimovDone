using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Trees
{
    public partial class Form1 : Form
    {
        string connstr = "server = 10.6.0.33;" +
             " port = 3306; " +
             "user = PC1; " +
             "password = 1111;" +
             " database = trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int id = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection NOW opened");

            MySqlCommand query = new MySqlCommand("Select * from otdel", connect);
            MySqlDataReader readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items1 = new List<ComboBoxItem>();

            while (readerCombo.Read())
            {
                ComboBoxItem item1 = new ComboBoxItem();
                item1.Text = readerCombo[1].ToString();
                item1.Value = (int)readerCombo[0];

                items1.Add(item1);
            }
            readerCombo.Close();
            cmb.DataSource = items1;
            cmb.DisplayMember = "Text";
            cmb.ValueMember = "Value";
            //
            query = new MySqlCommand("Select * from class", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items2 = new List<ComboBoxItem>();
          
            while (readerCombo.Read())
            {
                ComboBoxItem item2 = new ComboBoxItem();
                item2.Text = readerCombo[1].ToString();
                item2.Value = (int)readerCombo[0];

                items2.Add(item2);
            }
            readerCombo.Close();
            cmb2.DataSource = items2;
            cmb2.DisplayMember = "Text";
            cmb2.ValueMember = "Value";
            //
            List<ComboBoxItem> items3 = new List<ComboBoxItem>();
            query = new MySqlCommand("Select * from razred", connect);
            readerCombo = query.ExecuteReader();
            
            while (readerCombo.Read())
            {
                ComboBoxItem item3 = new ComboBoxItem();
                item3.Text = readerCombo[1].ToString();
                item3.Value = (int)readerCombo[0];

                items3.Add(item3);
            }
            readerCombo.Close();
            cmb3.DataSource = items3;
            cmb3.DisplayMember = "Text";
            cmb3.ValueMember = "Value";
            

            //
            List<ComboBoxItem> items4 = new List<ComboBoxItem>();
            query = new MySqlCommand("Select * from family", connect);
            readerCombo = query.ExecuteReader();
            

            while (readerCombo.Read())
            {
                ComboBoxItem item4 = new ComboBoxItem();
                item4.Text = readerCombo[1].ToString();
                item4.Value = (int)readerCombo[0];

                items1.Add(item4);
            }
            readerCombo.Close();
            cmb4.DataSource = items4;
            cmb4.DisplayMember = "Text";
            cmb4.ValueMember = "Value";
            //
            List<ComboBoxItem> items5 = new List<ComboBoxItem>();
            query = new MySqlCommand("Select * from rod", connect);
            readerCombo = query.ExecuteReader();
           

            while (readerCombo.Read())
            {
                ComboBoxItem item5 = new ComboBoxItem();
                item5.Text = readerCombo[1].ToString();
                item5.Value = (int)readerCombo[0];

                items5.Add(item5);
            }
            readerCombo.Close();
            cmb5.DataSource = items5;
            cmb5.DisplayMember = "Text";
            cmb5.ValueMember = "Value";
            //
            List<ComboBoxItem> items6 = new List<ComboBoxItem>();
            query = new MySqlCommand("Select * from vid", connect);
            readerCombo = query.ExecuteReader();
           

            while (readerCombo.Read())
            {
                ComboBoxItem item6 = new ComboBoxItem();
                item6.Text = readerCombo[1].ToString();
                item6.Value = (int)readerCombo[0];

                items6.Add(item6);
            }
            readerCombo.Close();
            cmb6.DataSource = items6;
            cmb6.DisplayMember = "Text";
            cmb6.ValueMember = "Value";           

            connect.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `trees_zaimov`.`tree`" +
                "(`name`, `imageUrl`," +
                "`otdel_id`, `class_id`, `razred_id`," +
                "`family_id`, `rod_id`, `vid_id`," +
                "description, DateLastUpdate)" +
                "VALUES(@name,@img, @otdel, @class," +
                "@razred, @family, @rod, @vid,@info, @dateReg)";

            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MySqlCommand query = new MySqlCommand(sql, connect);

            query.Parameters.AddWithValue("@name", txt.Text);
            query.Parameters.AddWithValue("@img",txt4 .Text);
            query.Parameters.AddWithValue("@otdel",cmb.SelectedValue);
            query.Parameters.AddWithValue("@class", cmb2.SelectedValue);
            query.Parameters.AddWithValue("@razred", cmb3.SelectedValue);
            query.Parameters.AddWithValue("@family", cmb4.SelectedValue);
            query.Parameters.AddWithValue("@rod", cmb5.SelectedValue);
            query.Parameters.AddWithValue("@vid", cmb6.SelectedValue); 
            query.Parameters.AddWithValue("@info", txt3.Text);
            query.Parameters.AddWithValue("@DateReg", DateAndTime.Now);

            query.ExecuteNonQuery();
            MessageBox.Show("dobavih zapis");


        }
    }
}
