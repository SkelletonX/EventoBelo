using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Diagnostics;


namespace EventoBelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.MainWindow = this;
            pictureBox1.ImageLocation = "http://www.ragezone.com.br/image.php?u=58110&dateline=144053176";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetCString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Globals.UpdateLogs("Status da Conexão : " + connection.State);  //info
                Globals.UpdateLogs("User : " + connection.WorkstationId);  //info
                Globals.UpdateLogs("Banco de dados : " + connection.Database);  //info
                Globals.UpdateLogs("Versão SQL : " + connection.ServerVersion); //info
               
                MessageBox.Show("Sistema desenvolvido por Skelleton [RZBR]"); //info
              
                

            }

        }



        static private string GetCString()
        { return Convert.ToString(ConfigurationManager.ConnectionStrings["GetCString"]); }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = GetCString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Active (ActiveID, Title, Description, Content, AwardContent, HasKey ,EndDate, IsOnly, Type, ActionTimeContent, IsAdvance, GoodsExchangeTypes, GoodsExchangeNum, limitType, limitValue, IsShow, ActiveType, IconID)" + "Values (@ActiveID, @Title, @Description, @Content, @AwardContent, @HasKey, @EndDate, @IsOnly, @Type, @ActionTimeContent, @IsAdvance, @GoodsExchangeTypes, @GoodsExchangeNum, @limitType, @limitValue, @IsShow, @ActiveType, @IconID)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ActiveID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Title", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Description", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Content", textBox4.Text);
                    cmd.Parameters.AddWithValue("@AwardContent", textBox5.Text);
                    cmd.Parameters.AddWithValue("@HasKey", "3");
                    cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse (textBox6.Text));
                    cmd.Parameters.AddWithValue("@IsOnly", "1");
                    cmd.Parameters.AddWithValue("@Type", "1");
                    cmd.Parameters.AddWithValue("@ActionTimeContent", textBox7.Text);
                    cmd.Parameters.AddWithValue("@IsAdvance", "False");
                    cmd.Parameters.AddWithValue("@GoodsExchangeTypes", "11");
                    cmd.Parameters.AddWithValue("@GoodsExchangeNum", "3");
                    cmd.Parameters.AddWithValue("@limitType", "1");
                    cmd.Parameters.AddWithValue("@limitValue", "0");
                    cmd.Parameters.AddWithValue("@IsShow", "False");
                    cmd.Parameters.AddWithValue("@ActiveType", "0");
                    cmd.Parameters.AddWithValue("@IconID", "3");



                    cmd.ExecuteNonQuery();
                    
                 
                }
               
                Globals.UpdateLogs("Dados Enviados para " + connection.DataSource);
                Globals.UpdateLogs("Banco de dados : " + connection.Database);


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string connectionString = GetCString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Active_Award (ActiveID, ItemID, Count, ValidDate, StrengthenLevel, AttackCompose, DefendCompose, LuckCompose, AgilityCompose, Gold, Money, Sex, Mark)" + "Values (@ActiveID, @ItemID, @Count, @ValidDate, @StrengthenLevel, @AttackCompose, @DefendCompose, @LuckCompose, @AgilityCompose, @Gold, @Money, @Sex, @Mark)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {



                        cmd.Parameters.AddWithValue("@ActiveID", textBox8.Text);
                        cmd.Parameters.AddWithValue("@ItemID", textBox9.Text);
                        cmd.Parameters.AddWithValue("@Count", textBox10.Text);
                        cmd.Parameters.AddWithValue("@ValidDate", textBox11.Text);
                        cmd.Parameters.AddWithValue("@StrengthenLevel", textBox12.Text);
                        cmd.Parameters.AddWithValue("@AttackCompose", textBox13.Text);
                        cmd.Parameters.AddWithValue("@DefendCompose", textBox14.Text);
                        cmd.Parameters.AddWithValue("@LuckCompose", textBox15.Text);
                        cmd.Parameters.AddWithValue("@AgilityCompose", textBox16.Text);
                        cmd.Parameters.AddWithValue("@Gold", "1");
                        cmd.Parameters.AddWithValue("@Money", textBox17.Text);
                        cmd.Parameters.AddWithValue("@Sex", "0");
                        cmd.Parameters.AddWithValue("@Mark", "0");




                        cmd.ExecuteNonQuery();
                    }
                    Globals.UpdateLogs("Dados Enviados para " + connection.DataSource);
                    Globals.UpdateLogs("Banco de dados : " + connection.Database);

                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //this.Text = "Navigating";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(textBox18.Text);
            Globals.UpdateLogs("ActiveList.Ashx atualizado!");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.ragezone.com.br/member.php?u=58110");
            Process.Start("http://www.facebook.com.br/bysdfsdf");
            
        }
    }
}