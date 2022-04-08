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
/// Last Modified: April 7 2022
/// 
/// Description: A simple BMI calculator that uses the Imperial & Metric system for calculations.
/// </summary>
namespace SimpleBMICalculator { 
    public partial class bmiCalculatorForm : Form {
        private double height,
                       weight,
                       bmi;
        private string mode;
        public bmiCalculatorForm() {
            InitializeComponent();
            mode = "Imperial"; // Initial mode will be Imperial
        }
        private void modeButton_Click(object sender, EventArgs e) {
            ChangeMode();
        }
        private void calculateButton_Click(object sender, EventArgs e) {
            

            if(mode == "Imperial") {
                weight = double.Parse(weightTextbox.Text);
                int feetInInches = int.Parse(heightFeetTextbox.Text) * 12; // formula to convert feet to inches (feet * 12)
                height = feetInInches + int.Parse(heightInchesTextbox.Text);
                bmi = ImperialCalculation(height, weight);
            }else{ // mode == "Metric"
                weight = double.Parse(weightTextbox.Text);
                double feetInMeters = int.Parse(heightFeetTextbox.Text) * 0.3048; // formula to convert feet to meters (feet * 0.3048)
                double inchesInMeters = int.Parse(heightInchesTextbox.Text) * 0.0254; // formula to conver inches to meters (feet * 0.0254)
                height = feetInMeters + inchesInMeters;
                bmi = MetricCalculation(height, weight);
            }

            resultLabel.Text = $"BMI: {bmi}";
            classificationLabel.Text = "You are considered: " + GetClassification(bmi);
        }
        private double ImperialCalculation(double height, double weight) {
            double result = (703 * weight) / (height * height);

            return Math.Round(result, 1);
        }
        private double MetricCalculation(double height, double weight) {
            double result =  weight / (height * height);

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
        private void ChangeMode() {
            if (mode == "Imperial") {
                mode = "Metric";
                weightLabel.Text = "Weight(kg)";
            } else {
                mode = "Imperial";
                weightLabel.Text = "Weight(lbs)";
            }
            modeButton.Text = mode;
        }
    }
}
