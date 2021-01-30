using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


            // temp input

            //1 0 0 0 1 0 0 1 0 0 1 1 1 0 0 0 0 1 1 1 1 0 0 0 0 1 1 0 0 1 1 1 1 0 0 0 0 0 1 1 1 1
            // DoTempFunc();
            //CalcOddsInString("1 0 0 0 1 0 0 1 0 0 1 1 1 0 0 0 0 1 1 1 1 0 0 0 0 1 1 0 0 1 1 1 1 0 0 0 0 0 1 1 1 1","1",' ');
        }


        private void PrintToAnswerBox(string answer)
        {
            lblAnswer.Text = answer;
        }


        private void DoTempFunc()
        {

            var evenCount = 0;

            // delete when done
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    evenCount++;
            }
            PrintToAnswerBox((evenCount + 1).ToString());
        }


        private void CalcOddsInString(string s, string targetChar, string delimiter)
        {
            String[] arr = Array.Empty<string>();
            if (String.IsNullOrEmpty(delimiter))
            {
                char[] lettersArr = s.ToCharArray();
                arr = lettersArr.Select(c => c.ToString()).ToArray();
            }
            else
            {
                arr = s.Split(delimiter[0]);
            }

            double population = arr.Length;
            double hitCount = 0.0;

            foreach (var val in arr)
            {
                if (val.Equals(targetChar))
                    hitCount++;
            }

            PrintToAnswerBox($"percentage = {hitCount}/{population} = {hitCount/population}");
        }

        private void btnParseString_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtInputString.Text) || String.IsNullOrWhiteSpace(txtTargetSymbol.Text) || txtDelimiter == null)
            {
                MessageBox.Show("Error","Please check inputs and try again.",MessageBoxButtons.OK);
                return;
            }
            // need to account for empty delimiter input
            var input = txtInputString.Text;
            var target = txtTargetSymbol.Text;
            var delimiter = txtDelimiter.Text;

            CalcOddsInString(s: input, targetChar: target, delimiter: delimiter);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // clear every input and answer box
            // maybe we can do a loop and clear all text boxes at once or something
            txtInputString.Clear();
            txtTargetSymbol.Clear();
            txtDelimiter.Clear();
            lblAnswer.Text = String.Empty;
        }


        //TODO: create a func to compare 2 collections or "sets"

    }
}
