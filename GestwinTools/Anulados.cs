using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestwinTools
{
    public partial class Anulados : Form
    {
        public Anulados()
        {
            InitializeComponent();
        }
        private string query;
        private string servidor;

        private void Anulados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings();
            NpgsqlConnection con = new NpgsqlConnection(servidor);
            //string query = "SELECT serie, numero, codigo, descricao, data_hora, funcionario_nome FROM public.documento_linha WHERE documento_anulado='true' ORDER BY data_hora DESC;";
            if (!string.IsNullOrEmpty(txt_nome_funcionario.Text))
            {
                query = "SELECT public.documento.serie, public.documento.numero, public.documento_comercial_linha.descricao_reduzida, public.documento_comercial_linha.data_hora_envio, public.documento.funcionario_nome FROM public.documento_comercial_linha INNER JOIN public.documento ON public.documento_comercial_linha._id_documento = public.documento._id WHERE public.documento_comercial_linha.anulado='true' AND public.documento.funcionario_nome = '" + txt_nome_funcionario.Text + "' AND public.documento_comercial_linha.data_hora_envio > '" + dtp_inicio.Value + "' AND public.documento_comercial_linha.data_hora_envio < '" + dtp_final.Value + "' ORDER BY public.documento_comercial_linha.data_hora_envio DESC;";
            }
            else
            {
                query = "SELECT public.documento.serie, public.documento.numero, public.documento_comercial_linha.descricao_reduzida, public.documento_comercial_linha.data_hora_envio, public.documento.funcionario_nome FROM public.documento_comercial_linha INNER JOIN public.documento ON public.documento_comercial_linha._id_documento = public.documento._id WHERE public.documento_comercial_linha.anulado='true' AND public.documento_comercial_linha.data_hora_envio > '" + dtp_inicio.Value + "' AND public.documento_comercial_linha.data_hora_envio < '" + dtp_final.Value + "' ORDER BY public.documento_comercial_linha.data_hora_envio DESC;";
            }
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Série";
            dataGridView1.Columns[1].HeaderText = "Número";
            dataGridView1.Columns[2].HeaderText = "Produto";
            dataGridView1.Columns[3].HeaderText = "Data";
            dataGridView1.Columns[4].HeaderText = "Funcionário";
        }
        public string settings()
        {
            string[] file = System.IO.File.ReadAllLines(@"c:\GestwinTools\Settings.txt");
            string ip = file[0].Substring(3, file[0].Length - 3);
            string database = file[1].Substring(9, file[1].Length - 9);
            string password = file[2].Substring(9, file[2].Length - 9);
            string port = file[3].Substring(5, file[3].Length - 5);

            servidor = "Server=" + ip + "; Port=" + port + "; User Id=postgres; Password=" + password + "; Database=" + database + ";";
            return servidor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings();
            NpgsqlConnection con = new NpgsqlConnection(servidor);
            //string query = "SELECT serie, numero, codigo, descricao, data_hora, funcionario_nome FROM public.documento_linha WHERE documento_anulado='true' ORDER BY data_hora DESC;";
            if (!string.IsNullOrEmpty(txt_nome_funcionario.Text))
            {
                query = "SELECT public.documento.serie, public.documento.numero, public.documento_comercial_linha.descricao_reduzida, public.documento_comercial_linha.data_hora_envio, public.documento.funcionario_nome FROM public.documento_comercial_linha INNER JOIN public.documento ON public.documento_comercial_linha._id_documento = public.documento._id WHERE public.documento_comercial_linha.anulado='true' AND public.documento.funcionario_nome = '" + txt_nome_funcionario.Text + "' AND public.documento_comercial_linha.data_hora_envio > '" + dtp_inicio.Value + "' AND public.documento_comercial_linha.data_hora_envio < '" + dtp_final.Value + "' ORDER BY public.documento_comercial_linha.data_hora_envio DESC;";
            }
            else
            {
                query = "SELECT public.documento.serie, public.documento.numero, public.documento_comercial_linha.descricao_reduzida, public.documento_comercial_linha.data_hora_envio, public.documento.funcionario_nome FROM public.documento_comercial_linha INNER JOIN public.documento ON public.documento_comercial_linha._id_documento = public.documento._id WHERE public.documento_comercial_linha.anulado='true' AND public.documento_comercial_linha.data_hora_envio > '" + dtp_inicio.Value + "' AND public.documento_comercial_linha.data_hora_envio < '" + dtp_final.Value + "' ORDER BY public.documento_comercial_linha.data_hora_envio DESC;";
            }
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            StreamWriter sw = File.CreateText(@"c:\GestwinTools\Lista_Anulados.xls");
            try
            {
                con.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                sw.WriteLine("Serie" + "\t" + "Numero" + "\t" + "Produto" + "\t" + "Data" + "\t" + "Funcionario");
                while (dr.Read())
                {
                    sw.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" + dr[2].ToString() + "\t" + dr[3].ToString() + "\t" + dr[4].ToString());
                }
                MessageBox.Show("Arquivo gerado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            finally
            {
                sw.Close();
                con.Close();
            }
        }
    }
}
