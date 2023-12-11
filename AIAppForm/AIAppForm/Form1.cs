using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIAppForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon tat chuong trinh ","Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            txtKQ.Text = "";
        }

       

        private List<string> GetInputChemicals()
        {
            // Assuming chemicals are comma-separated in the textbox
            string Input = txtInput.Text.Trim();

            // Split the input text by commas and remove any leading or trailing whitespaces
            List<string> inputChemicals = Input.Split(',').Select(chemical => chemical.Trim()).ToList();

            return inputChemicals;
        }
        private List<string> GetOutputChemicals()
        {
            // Assuming chemicals are comma-separated in the textbox
            string Output = txtOutput.Text.Trim();

            // Split the input text by commas and remove any leading or trailing whitespaces
            List<string> outputChemicals = Output.Split(',').Select(chemical => chemical.Trim()).ToList();

            return outputChemicals;
        }

        private List<PTHH> LocRules(List<PTHH> R, List<string> TG)
        {
            List<PTHH> sat = new List<PTHH>();

            foreach (PTHH rule in R)
            {
                if (rule.VeTrai.All(chemical => TG.Contains(chemical)))
                {
                    sat.Add(rule);
                }
            }

            return sat;
        }
        private PTHH GetRule(List<PTHH> sat)
        {
            
            return sat.FirstOrDefault();
        }

        private void SDT(List<string> GT)
        {
            // Reset data structures
            List<string> TG = new List<string>(GT);

            // Create a copy of the rules list for processing
            List<PTHH> processingRules = new List<PTHH>(ListPTHH.Instance.LPTHH);

            List<PTHH> SAT = LocRules(processingRules, TG);

            while (!KLSubset(TG) && SAT.Any())
            {
                PTHH rule = GetRule(SAT);
                string newChemical = rule.VePhai;

                if (!TG.Contains(newChemical))
                {
                    TG.Add(newChemical);
                }
                processingRules.Remove(rule);
                SAT = LocRules(processingRules, TG);
            }

            if (KLSubset(TG))
            {
                txtKQ.Text = "Thành Công";
            }
            else
            {
                txtKQ.Text = "Không thành công";
            }
        }



        private bool KLSubset(List<string> TG)
        {
            List<string> KL = GetOutputChemicals(); 
            return KL.All(chemical => TG.Contains(chemical));
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            List<string> GT = GetInputChemicals();

            SDT(GT);
        }
    }
}
