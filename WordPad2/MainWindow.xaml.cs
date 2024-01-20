using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WordPad2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteUndo(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Undo();
        }

        private void ExecuteCut(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Cut();
        }

        private void ExecuteCopy(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Copy();
        }

        private void ExecutePaste(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Paste();
        }

        private void ExecuteDelete(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.SelectedText = string.Empty;
        }

        private void ExecuteSelectAll(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.SelectAll();
        }

        private void ExecuteInsertDateTime(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }

    public static class EditCommands
    {
        public static readonly RoutedUICommand Undo = new RoutedUICommand("Отменить", "Undo", typeof(EditCommands));
        public static readonly RoutedUICommand Cut = new RoutedUICommand("Вырезать", "Cut", typeof(EditCommands));
        public static readonly RoutedUICommand Copy = new RoutedUICommand("Копировать", "Copy", typeof(EditCommands));
        public static readonly RoutedUICommand Paste = new RoutedUICommand("Вставить", "Paste", typeof(EditCommands));
        public static readonly RoutedUICommand Delete = new RoutedUICommand("Удалить", "Delete", typeof(EditCommands));
        public static readonly RoutedUICommand SelectAll = new RoutedUICommand("Выделить все", "SelectAll", typeof(EditCommands));
        public static readonly RoutedUICommand InsertDateTime = new RoutedUICommand("Время и дата", "InsertDateTime", typeof(EditCommands));
    }
}