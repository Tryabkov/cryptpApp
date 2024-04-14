using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Reflection.PortableExecutable;
using System.Windows.Threading;

namespace crypto
{
    public class MainWindowViewModel : BaseViewModel
    {
        private DispatcherTimer timer = null;
        private string _searchButtonImage;
        private string _graphButtonImage;
        private string _settingsButtonImage;
        private string _chatButtonImage;
        private string _accountButtonImage;
        private string _adminSearchButtonImage;
        private string _adminGraphButtonImage;
        private string _loginVisibility;
        private string _searchWindowVisibility;
        private string _graphWindowVisibility;
        private string _settingsWindowVisibility;
        private string _chatWindowVisibility;
        private string _accountWindowVisibility;
        private string _promtBlockVisibility;
        private string _chatVisibility;
        private string _sendButtonVisibility = "Collapsed";
        private string _graphStackPanelVisibility = "Collapsed";
        private ObservableCollection<string> _chat = new ObservableCollection<string>();
        private string _text = "Your question here...";
        private string _img1 = "/resourses/checkBox_Off.png";
        private string _img2 = "/resourses/checkBox_Off.png";
        private string _img3 = "/resourses/checkBox_Off.png";
        private string _img4 = "/resourses/checkBox_Off.png";
        private string _img5 = "/resourses/checkBox_Off.png";
        private string _img6 = "/resourses/checkBox_Off.png";
        private string _img7 = "/resourses/checkBox_Off.png";
        private string _img8 = "/resourses/checkBox_Off.png";
        private string _img9 = "/resourses/checkBox_Off.png";
        private string _img10 = "/resourses/checkBox_Off.png";



        private ObservableCollection<Wallet> _wallets = new ObservableCollection<Wallet>() {
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))),
        new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27)))};

        public string LoginVisibility { get => _loginVisibility; set { _loginVisibility = value; OnPropertyChanged(); } }
        public string SearchButtonImage { get => _searchButtonImage; set { _searchButtonImage = value; OnPropertyChanged(); } }
        public string GraphButtonImage { get => _graphButtonImage; set { _graphButtonImage = value; OnPropertyChanged(); } }
        public string SettingsButtonImage { get => _settingsButtonImage; set { _settingsButtonImage = value; OnPropertyChanged(); } }
        public string ChatButtonImage { get => _chatButtonImage; set { _chatButtonImage = value; OnPropertyChanged(); } }
        public string AccountsButtonImage { get => _accountButtonImage; set { _accountButtonImage = value; OnPropertyChanged(); } }
        public string AdminSearchButtonImage { get => _adminSearchButtonImage; set { _adminSearchButtonImage = value; OnPropertyChanged(); } }
        public string AdminGraphButtonImage { get => _adminGraphButtonImage; set { _adminGraphButtonImage = value; OnPropertyChanged(); } }

        public string SearchWindowVisibility { get => _searchWindowVisibility; set { _searchWindowVisibility = value; OnPropertyChanged(); } }
        public string GraphWindowVisibility { get => _graphWindowVisibility; set { _graphWindowVisibility = value; OnPropertyChanged(); } }
        public string SettingsWindowVisibility { get => _settingsWindowVisibility; set { _settingsWindowVisibility = value; OnPropertyChanged(); } }
        public string ChatWindowVisibility { get => _chatWindowVisibility; set { _chatWindowVisibility = value; OnPropertyChanged(); } }
        public string AccountsWindowVisibility { get => _accountWindowVisibility; set { _accountWindowVisibility = value; OnPropertyChanged(); } }
        public string PromtBlockVisibility { get => _promtBlockVisibility; set { _promtBlockVisibility = value; OnPropertyChanged(); } }
        public string ChatVisibility { get => _chatVisibility; set { _chatVisibility = value; OnPropertyChanged(); } }
        public string SendButtonVisibility { get => _sendButtonVisibility; set { _sendButtonVisibility = value; OnPropertyChanged(); } }
        public string GraphStackPanelVisibility { get => _graphStackPanelVisibility; set { _graphStackPanelVisibility = value; OnPropertyChanged(); } }
        public ObservableCollection<string> Chat { get => _chat; set { _chat = value; OnPropertyChanged(); } }
        public string Text { get => _text; set { _text = value; OnPropertyChanged(); } }
        public string Img1 { get => _img1; set { _img1 = value; OnPropertyChanged(); } }
        public string Img2 { get => _img2; set { _img2 = value; OnPropertyChanged(); } }
        public string Img3 { get => _img3; set { _img3 = value; OnPropertyChanged(); } }
        public string Img4 { get => _img4; set { _img4 = value; OnPropertyChanged(); } }
        public string Img5 { get => _img5; set { _img5 = value; OnPropertyChanged(); } }
        public string Img6 { get => _img6; set { _img6 = value; OnPropertyChanged(); } }
        public string Img7 { get => _img7; set { _img7 = value; OnPropertyChanged(); } }
        public string Img8 { get => _img8; set { _img8 = value; OnPropertyChanged(); } }
        public string Img9 { get => _img9; set { _img9 = value; OnPropertyChanged(); } }
        public string Img10 { get => _img10; set { _img10 = value; OnPropertyChanged(); } }

        //public string LastWeekButtonStyle { get => _lastWeekButtonStyle; set { _lastWeekButtonStyle = value; OnPropertyChanged(); } }
        //public string LastMonthButtonStyle { get => _lastMonthButtonStyle; set { _lastMonthButtonStyle = value; OnPropertyChanged(); } }
        //public string AllTimeButtonStyle { get => _allTimeButtonStyle; set { _allTimeButtonStyle = value; OnPropertyChanged(); } }


        public ObservableCollection<Wallet> Wallets { get => _wallets; set { _wallets = value; OnPropertyChanged(); } }


        public MainWindowViewModel()
        {
            SearchButtonImage = "/resourses/search_black.png";
            GraphButtonImage = "/resourses/grapf_white.png";
            SettingsButtonImage = "/resourses/settings_white.png";
            ChatButtonImage = "/resourses/chat_white.png";
            AccountsButtonImage = "/resourses/avatar_white.png";
            AdminSearchButtonImage = "/resourses/search_black_gray.png";
            AdminGraphButtonImage = "/resourses/grapf_white_gray.png";

            LoginVisibility = "Visible";
            SearchWindowVisibility = "Visible";
            GraphWindowVisibility = "Collapsed";
            SettingsWindowVisibility = "Collapsed";
            ChatWindowVisibility = "Collapsed";
            AccountsWindowVisibility = "Collapsed";

            PromtBlockVisibility = "Visible";
            ChatVisibility = "Collapsed";

        }

        public ICommand SearchButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    
                    SearchButtonImage = "/resourses/search_black.png";
                    GraphButtonImage = "/resourses/grapf_white.png";
                    SettingsButtonImage = "/resourses/settings_white.png";
                    ChatButtonImage = "/resourses/chat_white.png";
                    AccountsButtonImage = "/resourses/avatar_white.png";

                    SearchWindowVisibility = "Visible";
                    GraphWindowVisibility = "Collapsed";
                    SettingsWindowVisibility = "Collapsed";
                    ChatWindowVisibility = "Collapsed";
                    AccountsWindowVisibility = "Collapsed";
                });
            }
        }
        public ICommand GraphButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    SearchButtonImage = "/resourses/search_white.png";
                    GraphButtonImage = "/resourses/grapf_black.png";
                    SettingsButtonImage = "/resourses/settings_white.png";
                    ChatButtonImage = "/resourses/chat_white.png";
                    AccountsButtonImage = "/resourses/avatar_white.png";

                    SearchWindowVisibility = "Collapsed";
                    GraphWindowVisibility = "Visible";
                    SettingsWindowVisibility = "Collapsed";
                    ChatWindowVisibility = "Collapsed";
                    AccountsWindowVisibility = "Collapsed";
                });
            }
        }
        public ICommand SettingsButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    SearchButtonImage = "/resourses/search_white.png";
                    GraphButtonImage = "/resourses/grapf_white.png";
                    SettingsButtonImage = "/resourses/settings_black.png";
                    ChatButtonImage = "/resourses/chat_white.png";
                    AccountsButtonImage = "/resourses/avatar_white.png";

                    SearchWindowVisibility = "Collapsed";
                    GraphWindowVisibility = "Collapsed";
                    SettingsWindowVisibility = "Visible";
                    ChatWindowVisibility = "Collapsed";
                    AccountsWindowVisibility = "Collapsed";
                });
            }
        }
        public ICommand ChatButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    SearchButtonImage = "/resourses/search_white.png";
                    GraphButtonImage = "/resourses/grapf_white.png";
                    SettingsButtonImage = "/resourses/settings_white.png";
                    ChatButtonImage = "/resourses/chat_black.png";
                    AccountsButtonImage = "/resourses/avatar_white.png";

                    SearchWindowVisibility = "Collapsed";
                    GraphWindowVisibility = "Collapsed";
                    SettingsWindowVisibility = "Collapsed";
                    ChatWindowVisibility = "Visible";
                    AccountsWindowVisibility = "Collapsed";
                });
            }
        }
        public ICommand AccountsButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    SearchButtonImage = "/resourses/search_white.png";
                    GraphButtonImage = "/resourses/grapf_white.png";
                    SettingsButtonImage = "/resourses/settings_white.png";
                    ChatButtonImage = "/resourses/chat_white.png";
                    AccountsButtonImage = "/resourses/avatar_black.png";

                    SearchWindowVisibility = "Collapsed";
                    GraphWindowVisibility = "Collapsed";
                    SettingsWindowVisibility = "Collapsed";
                    ChatWindowVisibility = "Collapsed";
                    AccountsWindowVisibility = "Visible";
                });
            }
        }
        public ICommand AdminSearchButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    AdminSearchButtonImage = "/resourses/search_black_gray.png";
                    AdminGraphButtonImage = "/resourses/grapf_white_gray.png";
                    GraphStackPanelVisibility = "Collapsed";
                });
            }
        }
        public ICommand AdminGraphButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    AdminSearchButtonImage = "/resourses/search_white_gray.png";
                    AdminGraphButtonImage = "/resourses/grapf_black_gray.png";
                    GraphStackPanelVisibility = "Visible";
                });
            }
        }
        public ICommand SendButton_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (Text != "" && Text != "Your question here...")
                    {
                        Chat.Add(Text);
                        Text = "";
                        PromtBlockVisibility = "Collapsed";
                        ChatVisibility = "Visible";
                    }
                });
            }
        }

        public ICommand Start_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    timer = new DispatcherTimer();
                    timer.Tick += new EventHandler(TimerStop);
                    timer.Interval = new TimeSpan(0, 0, 0, 0, 3500);
                    timer.Start();
                });
            }
        }

        public ICommand Stop_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    TimerStop(null, null);
                    
                });
            }
        }

        public void TimerStop(object sender, EventArgs e)
        {

            timer.Stop();
            Wallets.Add(new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))));
            Wallets.Add(new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), new SolidColorBrush(Color.FromArgb(255, 24, 25, 27))));
            Wallets[0] = new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 24, 25, 27)), new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)));
            Wallets[1] = new Wallet("Bitcoin", "BTC", "0.26 BTC", "$18,775", "54.21%", "seed rain sun growth plant harvest repeat...", "Mar 6, 18:03, 2024", new SolidColorBrush(Color.FromArgb(255, 24, 25, 27)), new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)));
        }

        #region
        public ICommand CheckBox1_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/chackBox_On.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox2_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/chackBox_On.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox3_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/chackBox_On.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox4_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/chackBox_On.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox5_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/chackBox_On.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox6_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/chackBox_On.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox7_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/chackBox_On.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox8_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/chackBox_On.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox9_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/checkBox_Off.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/chackBox_On.png";
                    Img10 = "/resourses/checkBox_Off.png";

                });
            }
        }

        public ICommand CheckBox10_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Img1 = "/resourses/chackBox_On.png";
                    Img2 = "/resourses/checkBox_Off.png";
                    Img3 = "/resourses/checkBox_Off.png";
                    Img4 = "/resourses/checkBox_Off.png";
                    Img5 = "/resourses/checkBox_Off.png";
                    Img6 = "/resourses/checkBox_Off.png";
                    Img7 = "/resourses/checkBox_Off.png";
                    Img8 = "/resourses/checkBox_Off.png";
                    Img9 = "/resourses/checkBox_Off.png";
                    Img10 = "/resourses/chackBox_On.png";

                });
            }
        }
        #endregion

        public class Wallet
        {
            public string name { get; set; }
            public string nameShort { get; set; }
            public string amount { get; set; }
            public string price { get; set; }
            public string percent { get; set; }
            public string seedPhrase { get; set; }
            public string date { get; set; }
            public SolidColorBrush background { get; set; }
            public SolidColorBrush foreground { get; set; }

            public Wallet(string name, string nameShort, string amount, string price, string percent, string seedName, string date, SolidColorBrush background, SolidColorBrush foreground)
            {
                this.name = name;
                this.nameShort = nameShort;
                this.amount = amount;
                this.price = price;
                this.percent = percent;
                this.seedPhrase = seedName;
                this.date = date;
                this.background = background;
                this.foreground = foreground;
            }
        }
    }
}