using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// @Author: Charlls Ruiz
/// Last Modified: April 6 2022
/// 
/// Description: A simple BMI calculator that uses height in pounds and weight in inches to calculate the BMI.
/// TODO: Implement the ability to use feet and inches as height and kilograms as weight.
/// </summary>
namespace SimpleBMICalculator { 
    public partial class bmiCalculatorForm : Form {
        private int height,
                    weight;
        private double bmi;
        public bmiCalculatorForm() {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) {
            height = int.Parse(heightTextbox.Text);
            weight = int.Parse(weightTextbox.Text);

            bmi = CalculateBMI(height, weight);

            resultLabel.Text = $"BMI: {bmi}";
            classificationLabel.Text = "You are considered: " + GetClassification(bmi);
        }


        private double CalculateBMI(int height, int weight) {
            double result = 1.0 * (703 * weight) / (height * height);

            return Math.Round(result, 1);
        }

        private string GetClassification(double bmi) {
            if (bmi < 18.5) {
                return "Underweight";
            } else if (bmi >= 18.5 && bmi <= 24.9) {
                return "Healthy";
            } else if (bmi >= 25 && bmi <= 29.9) {
                return "Overweight";
            } else if (bmi >= 30 && bmi <= 39.9) {
                return "Obese";
            } else { // bmi > 40
                return "Extremely Obese";
            }
        }
    }
}
