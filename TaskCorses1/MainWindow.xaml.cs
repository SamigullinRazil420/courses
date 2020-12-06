using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TaskCorses1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Models.Application> applications;
        public MainWindow()
        {
            InitializeComponent();

            applications = new ObservableCollection<Models.Application>()
            {
                new Models.Application(){Name="Zoom",ImgPath="ApplicationImages/zoom.png", Description="Zoom — " +
                "программа для организации видеоконференций, " +
                "разработанная компанией Zoom Video Communications. Она предоставляет сервис видеотелефонии, " +
                "который позволяет подключать одновременно до 100 устройств бесплатно, " +
                "с 40-минутным ограничением для бесплатных аккаунтов."},
                new Models.Application(){Name="Cortana",ImgPath="ApplicationImages/cortana.png", Description="Виртуальная голосовая помощница с элементами" +
                " искусственного интеллекта от Microsoft для Windows Phone 8.1, " +
                "Microsoft Band, Windows 10, Android, Xbox One и iOS." },
                new Models.Application(){Name="Excel 2016",ImgPath="ApplicationImages/excel.png", Description="Программа для работы с электронными таблицами, " +
                "созданная корпорацией Microsoft для Microsoft Windows, Windows NT и Mac OS, а также Android, iOS и Windows Phone. " },
                new Models.Application(){Name="Microsoft Edge",ImgPath="ApplicationImages/edge.png", Description="Браузер от компании Microsoft," +
                " впервые выпущенный в 2015 " +
                "году одновременно с самой первой версией Windows 10. "},
                new Models.Application(){Name="Geeks 3D",ImgPath="ApplicationImages/pap.png", Description="FurMark — практически единственный тест, " +
                "применяющийся при тестировании энергопотребления видеокартами на протяжении десятилетий и часто описываемый в профильной литературе." },
                new Models.Application(){Name="Git",ImgPath="ApplicationImages/git.png", Description="Распределённая система управления версиями. " +
                "Проект был создан Линусом Торвальдсом для управления разработкой ядра Linux, первая версия выпущена 7 апреля 2005 года." +
                " На сей день его поддерживает Джунио Хамано." },
                new Models.Application(){Name="Java",ImgPath="ApplicationImages/pap.png", Description="Java – это набор технологий" +
                " (язык программирования и компьютерная платформа), предназначенных для создания и запуска программного обеспечения." },
                new Models.Application(){Name="Mail.Ru",ImgPath="ApplicationImages/pap.png", Description="Русскоязычный интернет-портал, " +
                "принадлежащий технологической компании Mail.ru Group. " },
                new Models.Application(){Name="Microsoft Azure",ImgPath="ApplicationImages/pap.png", Description="Облачная платформа компании Microsoft. " +
                "Предоставляет возможность разработки, выполнения приложений и " +
                "хранения данных на серверах, расположенных в распределённых дата-центрах." },
                new Models.Application(){Name="Microsoft Solitaire Collection",ImgPath="ApplicationImages/solit.png", Description="Это компьютерная игра, " +
                "входящая в состав Windows 10 и представляющая собой набор пасьянсов. " +
                "Этот набор заменяет пасьянсы «Косынка», «Паук» и «Свободная ячейка», которые были включены в предыдущие версии Windows, " +
                "а также добавляет два новых: «Пирамида» и «Три пика». " },
                new Models.Application(){Name="Discord",ImgPath="ApplicationImages/discord.png", Description="Проприетарный бесплатный мессенджер с " +
                "поддержкой VoIP, видеоконференций, предназначенный для использования различными сообществами по интересам, " +
                "наиболее популярен у геймеров и учащихся." },
                new Models.Application(){Name="Microsoft SQL Server 2017",ImgPath="ApplicationImages/pap.png", Description="Система управления реляционными" +
                " базами данных (РСУБД), разработанная корпорацией Microsoft. " +
                "Основной используемый язык запросов - Transact-SQL, создан совместно Microsoft и Sybase. Transact-SQL является реализацией " +
                "стандарта ANSI/ISO по структурированному языку запросов с расширениями. Используется для работы с базами данных размером от " +
                "персональных до крупных баз данных масштаба предприятия; конкурирует с другими СУБД в этом сегменте рынка." },
                new Models.Application(){Name="Microsoft SQL Server Management Studio 2018",ImgPath="ApplicationImages/sql.png", Description="Утилита из Microsoft " +
                "SQL Server 2005 и более поздних версий для конфигурирования, управления и администрирования всех компонентов Microsoft SQL Server. " +
                "Утилита включает скриптовый редактор и графическую программу, которая работает с объектами и настройками сервера." },
                new Models.Application(){Name="Microsoft Store",ImgPath="ApplicationImages/store.png", Description="Компонент операционной системы Windows," +
                " начиная с Windows 8, предназначенный для покупки и загрузки Metro/UWP-приложений, игр, фильмов, темы рабочего стола. " +
                "Microsoft Store - единственный способ покупки и загрузки универсальных приложений, а также приложений для рабочего стола в Windows RT." +
                " Первый раз появился в Windows 8 Developer Preview." },
                new Models.Application(){Name="Office",ImgPath="ApplicationImages/office.png", Description="Офисный пакет приложений, " +
                "созданных корпорацией Microsoft для операционных систем Microsoft Windows, Windows Phone, Android, macOS, iOS. " +
                "В состав этого пакета входит программное обеспечение для работы с различными типами документов: текстами, электронными таблицами, " +
                "базами данных и др. Microsoft Office является сервером OLE-объектов и его функции могут использоваться другими приложениями, а " +
                "также самими приложениями Microsoft Office. Поддерживает скрипты и макросы, написанные на VBA." },
                new Models.Application(){Name="Outlook",ImgPath="ApplicationImages/outlook.png", Description="Outlook — это программное обеспечение, " +
                "которое предназначено для работы с почтовыми ящиками." },
                new Models.Application(){Name="Paint 3D",ImgPath="ApplicationImages/paint.png", Description="Paint 3D, компании Microsoft, является одним из нескольких приложений, " +
                "представленных в обновлении для создателей Windows 10, и одним из нескольких приложений для трехмерного моделирования и печати, " +
                "которые были добавлены или улучшены в обновлении для создателей Windows 10, наряду с View 3D и 3D Builder." },
                new Models.Application(){Name="Power Point 2016",ImgPath="ApplicationImages/pp.png", Description="PowerPoint 2016 – это мощный графический" +
                " редактор для создания презентаций. Данное приложение позволяет организовать показ слайдов, на которых могут находиться: " +
                "текст, аудио и видео файлы, различные фигуры, графики, диаграммы, изображения и анимации. " },
                new Models.Application(){Name="Visio 2016",ImgPath="ApplicationImages/visio.png", Description="Microsoft Visio - это программное " +
                "обеспечение для рисования различных диаграмм: блок-схем, организационных диаграмм, планов зданий, поэтажных планов, " +
                "диаграмм потоков данных, технологических схем, моделирования бизнес-процессов, swim lane блок-схем, 3D-карт."  },
                new Models.Application(){Name="Visual Studio 2019",ImgPath="ApplicationImages/vs.png", Description="Visual Studio 2019 — это " +
                "интегрированная среда разработки с широкими возможностями для создания потрясающих приложений для Windows, Android и iOS, " +
                "а также современных веб-приложений и облачных служб." },
                new Models.Application(){Name="WhatsApp",ImgPath="ApplicationImages/pap.png", Description="WhatsApp - это бесплатное мультиплатформенное " +
                "приложение для общения через интернет, с помощью которого люди отправляют сообщения и звонят друг другу не тратя деньги на мобильную связь." },
                new Models.Application(){Name="WinRar",ImgPath="ApplicationImages/wn.png", Description="Архиватор файлов для 32- и 64-разрядных " +
                "операционных систем Windows, позволяющий создавать, изменять и распаковывать архивы RAR и ZIP, " +
                "а также работать с множеством архивов других форматов." },
                new Models.Application(){Name="Word 2016",ImgPath="ApplicationImages/word.png", Description="Текстовый процессор, предназначенный для " +
                "создания, просмотра, редактирования и форматирования текстов статей, деловых бумаг, а также иных документов, с локальным применением " +
                "простейших форм таблично-матричных алгоритмов. Выпускается корпорацией Microsoft в составе пакета Microsoft Office. " },
                new Models.Application(){Name="Xbox Game Bar",ImgPath="ApplicationImages/xbox.png", Description="Это вспомогательное приложение для " +
                "консолей Xbox 360 и Xbox One, которое поддерживается девайсами на платформах Windows 8, Windows RT, Windows Phone, Windows " +
                "Server 2012 PC, Android." },
                new Models.Application(){Name="Yandex",ImgPath="ApplicationImages/yan.png", Description="Быстрый и безопасный браузер со встроенной " +
                "технологией активной защиты Protect. Она проверяет скачиваемые файлы на вирусы, предупреждает об опасных сайтах, " +
                "защищает подключение к общественным сетям и ваши пароли." },
                new Models.Application(){Name="Безопасность Windows",ImgPath="ApplicationImages/bw.png", Description="Безопасность Windows — это служба, " +
                "которая предлагает единый интерфейс для просмотра состояния и управления функциями безопасности, такими как антивирус, " +
                "брандмауэр, производительность и прочие." },
                new Models.Application(){Name="Калькулятор",ImgPath="ApplicationImages/calc.png", Description="Калькулятор Windows - это программный " +
                "калькулятор, разработанный Microsoft и включенный в Windows . Он имеет четыре режима: стандартный, научный, программный и графический. " +
                "Стандартный режим включает цифровую клавиатуру и кнопки для выполнения арифметических операций." },
                new Models.Application(){Name="Параметры",ImgPath="ApplicationImages/par.png", Description="Параметры Windows — это приложение, которое " +
                "собирает в себе все доступные пользователю инструменты по взаимодействию с операционной системой." },



            };
            ApplicationsListView.ItemsSource = applications;
        }

        private void DescriptionApp_Click(object sender, RoutedEventArgs e)
        {
            var app = ApplicationsListView.SelectedItem as Models.Application;
            AppWindows.ApplicationDescriptionWindow window = new AppWindows.ApplicationDescriptionWindow(app);
            window.ShowDialog();
            
        }
    }
}
