using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorNaukowyCsharp
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Historia_Load(object sender, EventArgs e)
        {
            HistoryTxt.Clear();
            foreach (var item in Common.history)
            {
                HistoryTxt.Text += item + "\n";
            }
        }

        private void ClearHistory_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ClearHistory.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Czy jesteś pewien że chcesz wyczyścić historię?", "Wyczyść historię", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                {
                    if (dr == DialogResult.OK)
                    {
                        HistoryTxt.Clear();
                        Common.history.Clear();
                    }
                }                 
                ClearHistory.Checked = false;
            }
        }       
    }
}
