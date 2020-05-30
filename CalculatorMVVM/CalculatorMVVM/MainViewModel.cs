using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatorMVVM
{
    public class MainViewModel : BindableObject
    {
        private string _editorText;
        private string _operator;
        private double n1, n2, result;
        public string EditorText { 
            get { return _editorText; }
            set { _editorText = value;
                OnPropertyChanged();
            } }
        public ICommand AddParamCommand => new Command<string>(AddValueToEditor);
        public ICommand OperationCommand => new Command<string>(Operation);
        public ICommand ClearCommand => new Command(ClearEditor);
        private void ClearEditor()
        {
            EditorText = string.Empty;
            n1 = 0;
            n2 = 0;
            result = 0;
        }
        private void AddValueToEditor(string obj)
        {            
            if (result == 0)
            {
                EditorText = string.Empty;
                EditorText += obj;
            }
            else
            {
                EditorText = string.Empty;
                EditorText += obj;
            }

        }
        private void Operation(string obj)
        {
            if (n1 == 0)
            {
                _operator = obj;
                n1 = double.Parse(EditorText);
                EditorText = string.Empty;
            }
            else if (n2 == 0 && result != 0)
            {                
                n2 = double.Parse(EditorText);
                result = Calculate(n1, n2, obj);
                EditorText = result.ToString();
                n1 = result;
                n2 = 0;
                result = 0;
            }
            else if (obj == "=")
            {
                n2 = double.Parse(EditorText);
                result = Calculate(n1, n2, _operator);
                EditorText = result.ToString();
            }
            else if (n2 == 0 && result == 0)
            {
                n2 = double.Parse(EditorText);
                EditorText = Calculate(n1, n2, obj).ToString();
            }
            else
            {
                n2 = double.Parse(EditorText);
                EditorText = string.Empty;
                n1 = result;
                result = Calculate(n1, n2, _operator);
                EditorText = result.ToString();
            }
        }

        double a = 0;
        public double Calculate (double n1, double n2, string op)
        {
            double a = 0;
            switch (op)
            {
                case "+":
                    a = n1 + n2;
                    break;
                case "-":
                    a = n1 - n2;
                    break;
                case "*":
                    a = n1 * n2;
                    break;
                case "/":
                    a = n1 / n2;
                    break;
            }
            return a;
        }
    }
}