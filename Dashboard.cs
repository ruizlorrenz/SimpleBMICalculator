using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBMICalculator {
    public partial class bmiCalculatorForm : Form {
        private int height,
                    weight,
                    bmi;
        public bmiCalculatorForm() {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) {
            height = int.Parse(heightTextbox.Text);
            weight = int.Parse(weightTextbox.Text);

            bmi = height + weight;

            resultLabel.Text = $"test result: {bmi}";
        }
    }
}
