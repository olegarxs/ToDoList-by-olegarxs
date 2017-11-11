using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Data.Open();
            LoadFile(true);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AnimationTextBox();
            note.Focus(); // Вставка курсора в строку ввода
            note.SelectAll();
        }

        private void AnimationTextBox() // создание анимации появление TextBox
        {
            note.Visibility = Visibility.Visible;
            DoubleAnimation tb = new DoubleAnimation() 
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(0.3)
            };
            note.BeginAnimation(TextBox.OpacityProperty,tb);
        }

        private void note_KeyUp(object sender, KeyEventArgs e) // Добавление заметки при нажатии на Enter
        {
            if(e.Key == Key.Enter)
            {
                if (note.Text == string.Empty)
                    MessageBox.Show("Вы не ввели не единого символа");
                else
                {
                    TextBlock tb = new TextBlock() // создание TextBlock для переноса строк 
                    {
                        Text = note.Text,
                        TextWrapping = TextWrapping.Wrap,
                        Width = 165
                    };

                    CheckBox cb = new CheckBox() // Создание CheckBox
                    {
                        Content = tb,
                        FontSize = 16,
                        BorderThickness = new Thickness(2),
                        LayoutTransform = new ScaleTransform(1.5, 1.5)
                    };
                    cb.Checked += cb_CheckedChanged; // Добавляяем собатие на отметку CheckBox
                    Data data = new Data();
                    TextBlock message = (TextBlock)cb.Content;
                    data.Add(message.Text); // Добавляем заметку в список 
                    Main.Children.Add(cb); // Выводим на главную страницу
                    note.Text = "";
                }
            }
        }
        
        private void LoadFile(bool param) // Загрузка файла 
        {
            Data d = new Data();
            foreach (var list in d.GetList) // Заплняем заметки на главной страницы из файлв
            {
                if (list.Status == param)
                {
                    TextBlock tb = new TextBlock()
                    {
                        Text = list.Description,
                        TextWrapping = TextWrapping.Wrap,
                        Width = 155
                    };

                    CheckBox cb = new CheckBox()
                    {
                        Content = tb,
                        FontSize = 16,
                        BorderThickness = new Thickness(2),
                        LayoutTransform = new ScaleTransform(1.5, 1.5),
                        IsChecked = !param
                    };
                    if (param == true) cb.Checked += cb_CheckedChanged;
                    else cb.Unchecked += cbFalse_CheckedChanged;
                    
                    Main.Children.Add(cb);
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e) { 
            new Data().Save();
            Environment.Exit(0);
        }// при закрытие программы записываем данные в файл

        private void cb_CheckedChanged(object sender, EventArgs e) 
        {
            //MessageBox.Show(sender.ToString().Split(new Char[] { ' ' })[1].Remove(0, 8).ToString());
            CheckBox cb = (CheckBox)sender;
            TextBlock message = (TextBlock)cb.Content;
            Data data = new Data();
            for (int i = 0; i < data.GetList.Count; i++)
            {
                if (data.GetList[i].Description == message.Text.ToString() && data.GetList[i].Status == true)
                {
                    data.GetList[i] = new tdList() { Description = message.Text.ToString(), Status = false };
                    break;
                }
            }
            Main.Children.RemoveRange(0, data.GetList.Count); //удаляет все элементы на панели 
            LoadFile(true);
        }

        private void cbFalse_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            TextBlock message = (TextBlock)cb.Content;
            Data data = new Data();
            for (int i = 0; i < data.GetList.Count; i++)
            {
                if (data.GetList[i].Description == message.Text.ToString() && data.GetList[i].Status == false)
                {
                    data.GetList[i] = new tdList() { Description = message.Text.ToString(), Status = true };
                    break;
                }
            }
            Main.Children.RemoveRange(0, data.GetList.Count); 
            LoadFile(false);
        }

        bool state = false;
        private void buttonCompleted_Click(object sender, RoutedEventArgs e)
        {

            if (state == false)
            {
                Main.Children.RemoveRange(0, new Data().GetList.Count);
                LoadFile(false);
                buttonCompleted.Content = "Закрыть завершенные";
                state = true;
            }
            else
            {
                Main.Children.RemoveRange(0, new Data().GetList.Count);
                LoadFile(true);
                buttonCompleted.Content = "Просмотреть завершенные";
                state = false;
            }
        }

    }
    
}
