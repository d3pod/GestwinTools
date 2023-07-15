namespace GestwinTools
{
    partial class Anulados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            txt_nome_funcionario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtp_final = new DateTimePicker();
            dtp_inicio = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(224, 1);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(979, 634);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_nome_funcionario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtp_final);
            panel1.Controls.Add(dtp_inicio);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 634);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, 240);
            button2.Name = "button2";
            button2.Size = new Size(113, 33);
            button2.TabIndex = 7;
            button2.Text = "Exportar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_nome_funcionario
            // 
            txt_nome_funcionario.Location = new Point(29, 155);
            txt_nome_funcionario.Name = "txt_nome_funcionario";
            txt_nome_funcionario.Size = new Size(160, 23);
            txt_nome_funcionario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 137);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Data de Inicio";
            // 
            // dtp_final
            // 
            dtp_final.Location = new Point(29, 96);
            dtp_final.Name = "dtp_final";
            dtp_final.Size = new Size(160, 23);
            dtp_final.TabIndex = 2;
            // 
            // dtp_inicio
            // 
            dtp_inicio.Location = new Point(29, 40);
            dtp_inicio.Name = "dtp_inicio";
            dtp_inicio.Size = new Size(160, 23);
            dtp_inicio.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(50, 201);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 0;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Anulados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 635);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Anulados";
            ShowIcon = false;
            Text = "Anulados";
            Load += Anulados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private TextBox txt_nome_funcionario;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtp_final;
        private DateTimePicker dtp_inicio;
        private Button button1;
    }
}