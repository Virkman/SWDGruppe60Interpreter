using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SWDGruppe60Interpreter.Interpreter;
using SWDGruppe60Interpreter.Interpreter.Expressions;
using Expression = SWDGruppe60Interpreter.Interpreter.Expression;

namespace SWDGruppe60Interpreter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Question_label.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConversionContext question = new ConversionContext(TextInput_TextBox.Text);
            string fromConversion = question.getFromConversion();
            string toConversion = question.getToConversion();

            double quantity = question.getQuantity();

            Type t = Type.GetType("SWDGruppe60Interpreter.Interpreter.Expressions." + fromConversion);
            

            object convertFrom = (Expression) Activator.CreateInstance(t);

            Type[] funcParams = new Type[]{typeof(Double)};

            MethodInfo methodInfo = t.GetMethod(toConversion, funcParams);

            double doub = new double{};
            doub = quantity;
            object[] params_ = new object[]{ doub };

            String toQuantity = methodInfo.Invoke(convertFrom, params_).ToString();

            string answerToQues = question.getRepose() + toQuantity + " " + toConversion;

            Question_label.Content = answerToQues;

            //Type[] types = new Type[1];
            //types[0] = typeof(string);

            //ConstructorInfo con = t.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null,
            //    CallingConventions.HasThis, types, null);

            //Object convertFrom = (Expression) con.
        }
    }
}
