using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cocktails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drinksDataSet.Тара". При необходимости она может быть перемещена или удалена.
            this.тараTableAdapter.Fill(this.drinksDataSet.Тара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drinksDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.drinksDataSet.Продукты);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            продуктыTableAdapter.Update(drinksDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тараTableAdapter.Update(drinksDataSet);
        }
    }
}
