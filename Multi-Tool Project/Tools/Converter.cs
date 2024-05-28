using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
            InitializeUnitTypeComboBox();
        }
        private void InitializeUnitTypeComboBox()
        {
            comboBoxUnitType.Items.AddRange(new string[]
            {
                "Area",
                "Bytes",
                "Currency",
                "Energy",
                "Length",
                "Mass",
                "Temperature",
                "Time",
                "Volume"
            });

            comboBoxUnitType.SelectedIndexChanged += ComboBoxUnitType_SelectedIndexChanged;
        }
        private void ComboBoxUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUnitType = comboBoxUnitType.SelectedItem.ToString();
            comboBoxUnitFrom.Items.Clear();
            comboBoxUnitTo.Items.Clear();

            switch (selectedUnitType)
            {
                case "Area":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Square Meter", "Square Kilometer", "Square Mile", "Acre" , "Hectare" , "Square Centimeter"
                        , "Square Feet" , "Square Millimeters" , "Square Yards" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Square Meter", "Square Kilometer", "Square Mile", "Acre" , "Hectare" , "Square Centimeter" 
                        , "Square Feet" , "Square Millimeters" , "Square Yards" });
                    break;
                case "Bytes":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Byte", "Kilobyte", "Megabyte", "Gigabyte" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Byte", "Kilobyte", "Megabyte", "Gigabyte" });
                    break;
                case "Energy":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Joule", "Calorie", "Watt-hour" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Joule", "Calorie", "Watt-hour" });
                    break;
                case "Length":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile", "Yard", "Foot" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile", "Yard", "Foot" });
                    break;
                case "Mass":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound", "Ounce" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound", "Ounce" });
                    break;
                case "Temperature":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    break;
                case "Time":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Second", "Minute", "Hour", "Day" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Second", "Minute", "Hour", "Day" });
                    break;
                case "Volume":
                    comboBoxUnitFrom.Items.AddRange(new string[] { "Liter", "Milliliter", "Gallon", "Cubic Meter" });
                    comboBoxUnitTo.Items.AddRange(new string[] { "Liter", "Milliliter", "Gallon", "Cubic Meter" });
                    break;
            }

            comboBoxUnitFrom.SelectedIndex = 0;
            comboBoxUnitTo.SelectedIndex = 0;
        }
        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = double.Parse(textBoxInput.Text);
                string unitFrom = comboBoxUnitFrom.SelectedItem.ToString();
                string unitTo = comboBoxUnitTo.SelectedItem.ToString();
                string unitType = comboBoxUnitType.SelectedItem.ToString();

                double outputValue = ConvertUnits(inputValue, unitFrom, unitTo, unitType);
                textBoxOutput.Text = outputValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private double ConvertUnits(double value, string fromUnit, string toUnit, string unitType)
        {
            switch (unitType)
            {
                case "Area":
                    return ConvertArea(value, fromUnit, toUnit);
                case "Bytes":
                    return ConvertBytes(value, fromUnit, toUnit);
                case "Energy":
                    return ConvertEnergy(value, fromUnit, toUnit);
                case "Length":
                    return ConvertLength(value, fromUnit, toUnit);
                case "Mass":
                    return ConvertMass(value, fromUnit, toUnit);
                case "Temperature":
                    return ConvertTemperature(value, fromUnit, toUnit);
                case "Time":
                    return ConvertTime(value, fromUnit, toUnit);
                case "Volume":
                    return ConvertVolume(value, fromUnit, toUnit);
                default:
                    throw new NotImplementedException("This unit type conversion is not implemented.");
            }
        }

        private double ConvertArea(double value, string fromUnit, string toUnit)
        {
            // Convert from the input unit to Square Meters (m²)
            double valueInSquareMeters = value;
            switch (fromUnit)
            {
                case "Square Meter":
                    valueInSquareMeters = value;
                    break;
                case "Square Kilometer":
                    valueInSquareMeters = value * 1_000_000; // 1 km² = 1,000,000 m²
                    break;
                case "Square Mile":
                    valueInSquareMeters = value * 2_589_988.11; // 1 mi² = 2,589,988.11 m²
                    break;
                case "Acre":
                    valueInSquareMeters = value * 4_046.85642; // 1 ac = 4,046.85642 m²
                    break;
                case "Hectare": 
                    valueInSquareMeters = value * 10000; // 1 hectare = 10000 square meters
                    break;
                case "Square Centimeters":
                    valueInSquareMeters = value * 0.0001; // 1 square centimeter = 0.0001 square meters
                    break;
                case "Square Feet":
                    valueInSquareMeters = value * 0.092903; // 1 square foot = 0.092903 square meters
                    break;
                case "Square Millimeters":
                    valueInSquareMeters = value * 0.000001; // 1 square millimeter = 0.000001 square meters
                    break;
                case "Square Yards":
                    valueInSquareMeters = value * 0.836127; // 1 square yard = 0.836127 square meters
                    break;
                default:
                    throw new NotImplementedException($"Conversion from {fromUnit} is not implemented.");
            }

            // Convert from Square Meters (m²) to the output unit
            double convertedValue = valueInSquareMeters;
            switch (toUnit)
            {
                case "Square Meter":
                    convertedValue = valueInSquareMeters;
                    break;
                case "Square Kilometer":
                    convertedValue = valueInSquareMeters / 1_000_000; // 1 km² = 1,000,000 m²
                    break;
                case "Square Mile":
                    convertedValue = valueInSquareMeters / 2_589_988.11; // 1 mi² = 2,589,988.11 m²
                    break;
                case "Acre":
                    convertedValue = valueInSquareMeters / 4_046.85642; // 1 ac = 4,046.85642 m²
                    break;
                case "Hectare":
                    convertedValue = valueInSquareMeters / 10000; // 1 hectare = 10000 square meters
                    break;
                case "Square Centimeters":
                    convertedValue = valueInSquareMeters / 0.0001; // 1 square centimeter = 0.0001 square meters
                    break;
                case "Square Feet":
                    convertedValue = valueInSquareMeters / 0.092903; // 1 square foot = 0.092903 square meters
                    break;
                case "Square Millimeters":
                    convertedValue = valueInSquareMeters / 0.000001; // 1 square millimeter = 0.000001 square meters
                    break;
                case "Square Yards":
                    convertedValue = valueInSquareMeters / 0.836127; // 1 square yard = 0.836127 square meters
                    break;
                default:
                    throw new NotImplementedException($"Conversion to {toUnit} is not implemented.");
            }

            return convertedValue;
        }

        private double ConvertBytes(double value, string fromUnit, string toUnit)
        {
            // Convert from the input unit to Bytes (B)
            double valueInBytes = value;
            switch (fromUnit)
            {
                case "Byte":
                    valueInBytes = value;
                    break;
                case "Kilobyte":
                    valueInBytes = value * 1024; // 1 KB = 1024 B
                    break;
                case "Megabyte":
                    valueInBytes = value * 1_048_576; // 1 MB = 1024 * 1024 B = 1,048,576 B
                    break;
                case "Gigabyte":
                    valueInBytes = value * 1_073_741_824; // 1 GB = 1024 * 1024 * 1024 B = 1,073,741,824 B
                    break;
                default:
                    throw new NotImplementedException($"Conversion from {fromUnit} is not implemented.");
            }

            // Convert from Bytes (B) to the output unit
            double convertedValue = valueInBytes;
            switch (toUnit)
            {
                case "Byte":
                    convertedValue = valueInBytes;
                    break;
                case "Kilobyte":
                    convertedValue = valueInBytes / 1024; // 1 KB = 1024 B
                    break;
                case "Megabyte":
                    convertedValue = valueInBytes / 1_048_576; // 1 MB = 1,048,576 B
                    break;
                case "Gigabyte":
                    convertedValue = valueInBytes / 1_073_741_824; // 1 GB = 1,073,741,824 B
                    break;
                default:
                    throw new NotImplementedException($"Conversion to {toUnit} is not implemented.");
            }

            return convertedValue;
        }

        private double ConvertEnergy(double value, string fromUnit, string toUnit)
        {
            // Implement conversion logic for Energy
            throw new NotImplementedException("Energy conversion is not implemented.");
        }

        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            double valueInMeters = value;
            switch (fromUnit)
            {
                case "Meter":
                    valueInMeters = value;
                    break;
                case "Kilometer":
                    valueInMeters = value * 1000; // 1 km = 1000 m
                    break;
                case "Mile":
                    valueInMeters = value * 1609.344; // 1 mi = 1609.344 m
                    break;
                case "Yard":
                    valueInMeters = value * 0.9144; // 1 yd = 0.9144 m
                    break;
                case "Foot":
                    valueInMeters = value * 0.3048; // 1 ft = 0.3048 m
                    break;
                default:
                    throw new NotImplementedException($"Conversion from {fromUnit} is not implemented.");
            }

            double convertedValue = valueInMeters;
            switch (toUnit)
            {
                case "Meter":
                    convertedValue = valueInMeters;
                    break;
                case "Kilometer":
                    convertedValue = valueInMeters / 1000; // 1 km = 1000 m
                    break;
                case "Mile":
                    convertedValue = valueInMeters / 1609.344; // 1 mi = 1609.344 m
                    break;
                case "Yard":
                    convertedValue = valueInMeters / 0.9144; // 1 yd = 0.9144 m
                    break;
                case "Foot":
                    convertedValue = valueInMeters / 0.3048; // 1 ft = 0.3048 m
                    break;
                default:
                    throw new NotImplementedException($"Conversion to {toUnit} is not implemented.");
            }

            return convertedValue;
        }

        private double ConvertMass(double value, string fromUnit, string toUnit)
        {
            // Implement conversion logic for Mass
            throw new NotImplementedException("Mass conversion is not implemented.");
        }

        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            // Implement conversion logic for Temperature
            throw new NotImplementedException("Temperature conversion is not implemented.");
        }

        private double ConvertTime(double value, string fromUnit, string toUnit)
        {
            // Implement conversion logic for Time
            throw new NotImplementedException("Time conversion is not implemented.");
        }

        private double ConvertVolume(double value, string fromUnit, string toUnit)
        {
            // Implement conversion logic for Volume
            throw new NotImplementedException("Volume conversion is not implemented.");
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}