using csmic;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AdvancedCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InputInterpreter interpreter = new InputInterpreter();

        private List<HistoryItem> historyItems = new List<HistoryItem>();

        private List<VariableItem> variableItems = new List<VariableItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                var input = this.txtInput.Text;

                await Task.Run(() =>
                {
                    this.interpreter.Interpret(input);
                    this.historyItems.Add(new HistoryItem() { Input = input, Output = this.interpreter.Output });
                    this.variableItems = this.interpreter.Variables.Select(kp => new VariableItem() { VariableName = kp.Key, Value = kp.Value.Value.ToString(), ExpressionVisibility = kp.Value.Type == VariableType.Equation ? Visibility.Visible : Visibility.Hidden, ExpressionComputation = "" }).ToList();
                    foreach(var expressionVariable in this.variableItems.Where(v => v.ExpressionVisibility == Visibility.Visible))
                    {
                        this.interpreter.Interpret(expressionVariable.Value);
                        expressionVariable.ExpressionComputation = this.interpreter.Output;
                    }
                });

                this.txtInput.Clear();

                this.lvHistory.ItemsSource = this.historyItems;
                this.lvHistory.Items.Refresh();

                this.lvVariableList.ItemsSource = this.variableItems;
                this.lvVariableList.Items.Refresh();

                this.lvHistory.Items.MoveCurrentToLast();
                this.lvHistory.ScrollIntoView(this.lvHistory.Items.CurrentItem);
            }
        }

        private void btnFx_Click(object sender, RoutedEventArgs e)
        {
            if(this.rdFxDefinitions.Height.Value == 0)
            {
                this.rdFxDefinitions.Height = new GridLength(1, GridUnitType.Star);
            }
            else
            {
                this.rdFxDefinitions.Height = new GridLength(0, GridUnitType.Pixel);
            }
        }
    }
}
