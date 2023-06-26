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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();

        Random Rand = new Random();

        List<String> firstNames = new List<String>
            {
                "Александр",
                "Михаил",
                "Кирилл",
                "Алексей",
                "Денис",
                "Виктор",
                "Дмитрий",
                "Даниил",
                "Матвей",
                "Григорий"
            };

        List<String> lastNames = new List<String>
            {
                "Иванов",
                "Смирнов",
                "Кузнецов",
                "Попов",
                "Васильев",
                "Петров",
                "Соколов",
                "Михайлов",
                "Новиков",
                "Федоров",
                "Морозов",
                "Волков",
                "Алексеев",
                "Лебедев",
                "Семенов",
                "Егоров",
                "Павлов",
                "Козлов",
                "Степанов",
                "Николаев",
                "Орлов",
                "Андреев",
                "Макаров",
                "Никитин",
                "Захаров",
                "Зайцев",
                "Соловьев",
                "Борисов",
                "Яковлев",
                "Григорьев",
                "Романов",
                "Воробьев",
                "Сергеев",
                "Кузьмин",
                "Фролов",
                "Александров",
                "Дмитриев",
                "Королев",
                "Гусев",
                "Киселев"
            };

        List<String> firsts = new List<String>
            {
                "Нападение",
                "Разорение",
                "Падение",
                "Непонимание",
                "Разлука",
                "Отчаяние",
                "Атака"
            };

        List<String> lasts = new List<String>
            {
                "Танка",
                "Розбiников",
                "Никиты",
                "Востока",
                "Хлорофила",
                "Компьютера",
                "Эона",
                "Марта",
                "Девственников"
            };


        List<String> generatedAuthors = new List<String>();

        public MainWindow()
        {
            InitializeComponent();

            int count = 1000;
   

            for (int i = 0; i < count; i++)
            {
                string author = firstNames[Rand.Next(0, 9)] + " " + lastNames[Rand.Next(0, 39)];
                generatedAuthors.Add(author);

                Book b = new Book(
                            Rand.Next(1, 1000),
                            firsts[Rand.Next(0, 6)] + " " + lasts[Rand.Next(0, 8)],
                            author,
                            Rand.Next(1, 30) + "." + Rand.Next(1, 12) + "." + Rand.Next(1700, 2017),
                            (Rand.Next(1, 10) + Rand.Next(1, 10) + Rand.Next(1, 10)) / 3,
                            (Rand.Next(1, 10) + Rand.Next(1, 10) + Rand.Next(1, 10)) / 3,
                            Rand.Next(100, 123456)
                            );
                books.Add(b);
            }

            ResultTable.ItemsSource = books;
            SearchCombo.ItemsSource = generatedAuthors;


        }

        private void SearchButt_Click(object sender, RoutedEventArgs e)
        {
            ResultTable.ItemsSource = books.Where(x=>x.Author == SearchCombo.SelectedValue.ToString());
        }

        private void SearchReset_Click(object sender, RoutedEventArgs e)
        {
            ResultTable.ItemsSource = books;
        }
    }
}
