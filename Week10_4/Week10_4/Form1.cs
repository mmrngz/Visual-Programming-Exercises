using System.Data.SQLite;
using System.IO;

namespace Week10_4
{
    public partial class Form1 : Form
    {
        public string dbName = "users.db";

        public Form1()
        {
            InitializeComponent();
        }


        public void manageDatabase()
        {
            try
            {
                if (!File.Exists(dbName))
                {
                    SQLiteConnection.CreateFile(dbName);

                    using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand(con);
                        cmd.CommandText = "CREATE TABLE users(id INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, password TEXT NOT NULL, name TEXT, address TEXT NOT NULL, age INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT))";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE user_books(id INTEGER NOT NULL UNIQUE, user_id INTEGER NOT NULL, book_name TEXT NOT NULL, author TEXT NOT NULL, page_count INTEGER NOT NULL, PRIMARY KEY(id), FOREIGN KEY (user_id) REFERENCES users(id) )";
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            manageDatabase();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO users(email,password,name,address,age) VALUES(@email,@password,@name,@address,@age)";
                    cmd.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                    cmd.Parameters.AddWithValue("@password", txtPasswordRegister.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You are registered successfully!");
                    tabControl1.SelectedIndex = 0;
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void handleLogout()
        {
            this.Visible = true;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM users WHERE email=@email AND password=@password";
                    cmd.Parameters.AddWithValue("@email",txtEmailSignIn.Text);
                    cmd.Parameters.AddWithValue("@password",txtPasswordSignIn.Text);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        dataReader.Close();
                        con.Close();
                        MessageBox.Show("Your credentials are not correct");
                        return;
                    }
                    
                    dataReader.Read();
                    /*
                    string email1 = dataReader.GetValue(1).ToString();
                    string email2 = dataReader.GetString(1);
                    string email3 = dataReader[1].ToString();
                    string email4 = dataReader["email"].ToString();
                    */
                    int id = int.Parse(dataReader["id"].ToString());
                    string email = dataReader["email"].ToString();
                    string password = dataReader["password"].ToString();
                    string name = dataReader["name"].ToString();    
                    string address = dataReader["address"].ToString();
                    int age = int.Parse(dataReader["age"].ToString());

                    User user1 = new User(id,email,password,name,address,age);


                    dataReader.Close();
                    con.Close();
                    this.Visible = false;

                    //txtEmailSignIn.Text = "";
                    //txtPasswordSignIn.Text = "";


                    Form2 frm2 = new Form2();
                    frm2.user = user1;
                    frm2.LogoutEvent += handleLogout;
                    frm2.ShowDialog();

                    

                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}