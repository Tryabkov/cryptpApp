using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;


namespace crypto
{
    /// <summary>
    /// Interaction logic for GraphWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private DispatcherTimer timerUpd = null;
        private DispatcherTimer timerLoad = null;
        public MainWindow()
        {

            InitializeComponent();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            adminGrid.Margin = new Thickness(274, 100, 0, 0);
            stackpanel_1.Margin = new Thickness(0,0,0,0);
            searchAdminStackPandel.Visibility = Visibility.Visible;
            graphAdminStackPandel.Visibility = Visibility.Collapsed;

            walletSearchTextblock.Visibility = Visibility.Visible;
            statisticTextblock.Visibility = Visibility.Collapsed;

            adminSearchButtonImg.Source = (ImageSource)this.FindResource("searchBlackDrawingImage");
            adminGraphButtonImg.Source = (ImageSource)this.FindResource("graphGrayDrawingImage");
        }

        private void GraphButton_Click(object sender, RoutedEventArgs e)
        {
            adminGrid.Margin = new Thickness(238, 80, 0, 0);
            //stackpanel_1.Margin = new Thickness(0, -30, 0, 0);
            searchAdminStackPandel.Visibility = Visibility.Collapsed;
            graphAdminStackPandel.Visibility = Visibility.Visible;

            walletSearchTextblock.Visibility = Visibility.Collapsed;
            statisticTextblock.Visibility = Visibility.Visible;

            adminSearchButtonImg.Source = (ImageSource)this.FindResource("searchGrayDrawingImage");
            adminGraphButtonImg.Source = (ImageSource)this.FindResource("graphBlackDrawingImage");
        }

        private void LastWeekButton_Click(object sender, RoutedEventArgs e)
        {
            LastWeekButton.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            LastWeekButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            LastMonthButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastMonthButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            AllTimeButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            AllTimeButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekBlock.Visibility = Visibility.Visible;
            LastMounthBlock.Visibility = Visibility.Collapsed;
            AllTimeBlock.Visibility = Visibility.Collapsed;

            LastWeekButton.Style = this.FindResource("BlackButtonStyle_r8") as Style;
            LastMonthButton.Style = this.FindResource("GrayButtonStyle") as Style;
            AllTimeButton.Style = this.FindResource("GrayButtonStyle") as Style;

        }

        private void LastMonthButton_Click(object sender, RoutedEventArgs e)
        {
            LastMonthButton.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            LastMonthButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            LastWeekButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastWeekButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            AllTimeButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            AllTimeButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekBlock.Visibility = Visibility.Collapsed;
            LastMounthBlock.Visibility = Visibility.Visible;
            AllTimeBlock.Visibility = Visibility.Collapsed;

            LastWeekButton.Style = this.FindResource("GrayButtonStyle") as Style;
            LastMonthButton.Style = this.FindResource("BlackButtonStyle_r8") as Style;
            AllTimeButton.Style = this.FindResource("GrayButtonStyle") as Style;
        }

        private void AllTimeButton_Click(object sender, RoutedEventArgs e)
        {

            AllTimeButton.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            AllTimeButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));

            LastMonthButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastMonthButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekButton.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastWeekButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));


            LastWeekBlock.Visibility = Visibility.Collapsed;
            LastMounthBlock.Visibility = Visibility.Collapsed;
            AllTimeBlock.Visibility = Visibility.Visible;

            LastWeekButton.Style = this.FindResource("GrayButtonStyle") as Style;
            LastMonthButton.Style = this.FindResource("GrayButtonStyle") as Style;
            AllTimeButton.Style = this.FindResource("BlackButtonStyle_r8") as Style;
        }

        private void LastWeekButton2_Click(object sender, RoutedEventArgs e)
        {
            LastWeekButton2.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            LastWeekButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            LastMonthButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastMonthButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            AllTimeButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            AllTimeButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekButton2.Style = this.FindResource("BlackButtonStyle_r8") as Style;
            LastMonthButton2.Style = this.FindResource("GrayButtonStyle") as Style;
            AllTimeButton2.Style = this.FindResource("GrayButtonStyle") as Style;

        }

        private void LastMonthButton2_Click(object sender, RoutedEventArgs e)
        {
            LastMonthButton2.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            LastMonthButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            LastWeekButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastWeekButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            AllTimeButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            AllTimeButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekButton2.Style = this.FindResource("GrayButtonStyle") as Style;
            LastMonthButton2.Style = this.FindResource("BlackButtonStyle_r8") as Style;
            AllTimeButton2.Style = this.FindResource("GrayButtonStyle") as Style;
        }

        private void AllTimeButton2_Click(object sender, RoutedEventArgs e)
        {

            AllTimeButton2.Background = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
            AllTimeButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));

            LastMonthButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastMonthButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekButton2.Background = new SolidColorBrush(Color.FromArgb(255, 226, 231, 236));
            LastWeekButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));

            LastWeekButton2.Style = this.FindResource("GrayButtonStyle") as Style;
            LastMonthButton2.Style = this.FindResource("GrayButtonStyle") as Style;
            AllTimeButton2.Style = this.FindResource("BlackButtonStyle_r8") as Style;
        }

        private void chatTextBox_MouseDown(object sender, RoutedEventArgs e)
        {
            ChatButton.Visibility = Visibility.Visible;
            chatTextBox.Text = "";
            chatTextBox.Foreground = new SolidColorBrush(Color.FromArgb(255, 24, 25, 27));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void AddDayButton_Click(object sender, RoutedEventArgs e)
        {
            if (addDayGrid.Visibility == Visibility.Visible)
            {
                addDayGrid.Visibility = Visibility.Collapsed;
            }
            else addDayGrid.Visibility = Visibility.Visible;
        }

        private void AddWalletButton_Click(object sender, RoutedEventArgs e)
        {
            if (addWalletGrid.Visibility == Visibility.Visible)
            {
                addWalletGrid.Visibility = Visibility.Collapsed;
            }
            else addWalletGrid.Visibility = Visibility.Visible;
        }

        private void SumInCript_Click(object sender, RoutedEventArgs e)
        {
            if (AdminCheckMarkScale.ScaleY == 1)
            {
                AdminCheckMarkScale.ScaleY = -1;
                adminWalletSelectorGrid.Visibility = Visibility.Collapsed;
            }
            else
            {
                AdminCheckMarkScale.ScaleY = 1;
                adminWalletSelectorGrid.Visibility = Visibility.Visible;
            }
        }

        private void adminWalletSelector_Selected(object sender, SelectionChangedEventArgs e)
        {
            adminWalletSelectorGrid.Visibility = Visibility.Collapsed;
            AdminCheckMarkScale.ScaleY = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainGrid.Visibility = Visibility.Visible;
            logIn.Visibility = Visibility.Collapsed;
        }

        private void ToggleBorder1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var OnStoryBack = (Storyboard)this.FindResource("OnToggleButtonBackground");
            var OnStoryMargin = (Storyboard)this.FindResource("OnToggleButtonMargin");
            var OffStoryBack = (Storyboard)this.FindResource("OffToggleButtonBackground");
            var OffStoryMargin = (Storyboard)this.FindResource("OffToggleButtonMargin");

            if (ToggleEllipce1.Margin == new Thickness(11, 0, 0, 0))
            {
                OffStoryBack.Begin(ToggleBorder1);
                OffStoryMargin.Begin(ToggleEllipce1);
            }
            else
            {
                OnStoryBack.Begin(ToggleBorder1);
                OnStoryMargin.Begin(ToggleEllipce1);
            }
        }

        private void ToggleBorder2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var OnStoryBack = (Storyboard)this.FindResource("OnToggleButtonBackground");
            var OnStoryMargin = (Storyboard)this.FindResource("OnToggleButtonMargin");
            var OffStoryBack = (Storyboard)this.FindResource("OffToggleButtonBackground");
            var OffStoryMargin = (Storyboard)this.FindResource("OffToggleButtonMargin");

            if (ToggleEllipce2.Margin == new Thickness(11, 0, 0, 0))
            {
                OffStoryBack.Begin(ToggleBorder2);
                OffStoryMargin.Begin(ToggleEllipce2);
            }
            else
            {
                OnStoryBack.Begin(ToggleBorder2);
                OnStoryMargin.Begin(ToggleEllipce2);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //((Button)sender).Background. = new BitmapImage(new Uri(@"\myserver\folder1\Customer Data\sample.png"));
        }

        private void choosedEng(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "English";
            eng.Visibility = Visibility.Visible;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedFr(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Français";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Visible;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedEs(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Español";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Visible;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedGe(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Deutsch";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Visible;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }

        private void choosedIt(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Italiano";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Visible;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedCh(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "中文";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Visible;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedRu(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Русский";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Visible;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedPo(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Português";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Visible;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }

        private void choosedPl(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Polski";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Visible;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedJa(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "日本語";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Visible;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedKo(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "한국어";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Visible;
            tu.Visibility = Visibility.Collapsed;
        }
        private void choosedTu(object sender, RoutedEventArgs e)
        {
            languageTextBlock.Text = "Türkçe";
            eng.Visibility = Visibility.Collapsed;
            fr.Visibility = Visibility.Collapsed;
            es.Visibility = Visibility.Collapsed;
            ge.Visibility = Visibility.Collapsed;
            it.Visibility = Visibility.Collapsed;
            ch.Visibility = Visibility.Collapsed;
            ru.Visibility = Visibility.Collapsed;
            po.Visibility = Visibility.Collapsed;
            pl.Visibility = Visibility.Collapsed;
            ja.Visibility = Visibility.Collapsed;
            ko.Visibility = Visibility.Collapsed;
            tu.Visibility = Visibility.Visible;
        }

        private void LanguageButton_Click(object sender, RoutedEventArgs e)
        {
            var OnLanguageHeight = (Storyboard)this.FindResource("OnLanguageHeight");
            var OffLanguageHeight = (Storyboard)this.FindResource("OffLanguageHeight");

            if (languageGrid.Visibility == Visibility.Collapsed)
            {
                languageGrid.Visibility = Visibility.Visible;
                OnLanguageHeight.Begin(languageGrid);
            }
            else
            {
                OffLanguageHeight.Begin(languageGrid);
            }
        }

        private void RemoveLangAnimation(object? sender, EventArgs e)
        {
            languageGrid.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            updateAnimation.Visibility = Visibility.Visible;
            timerUpd = new DispatcherTimer();
            timerUpd.Tick += new EventHandler(RemoveUpdate);
            timerUpd.Interval = new TimeSpan(0, 0, 0, 0, 3500);
            timerUpd.Start();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            onFound.Visibility = Visibility.Visible;

        }

        private void RemoveUpdate(object sender, EventArgs e)
        {
            updateAnimation.Visibility = Visibility.Collapsed;
            timerUpd.Stop();
        }
        private void RemoveLoading(object sender, EventArgs e)
        {
            loadingAnimation.Visibility = Visibility.Collapsed;
            timerLoad.Stop();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            logIn.Visibility = Visibility.Collapsed;
        }

        private void removeOnFound_Click(object sender, RoutedEventArgs e)
        {
            onFound.Visibility = Visibility.Collapsed;
            loadingAnimation.Visibility = Visibility.Visible;

            timerLoad = new DispatcherTimer();
            timerLoad.Tick += new EventHandler(RemoveLoading);
            timerLoad.Interval = new TimeSpan(0, 0, 0, 0, 5000);
            timerLoad.Start();
        }

        private void checkbox_mouseEnter(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            StackPanel stackPanel = (StackPanel)button.Content;
            (stackPanel.Children.OfType<Ellipse>().FirstOrDefault()).Stroke = new SolidColorBrush(Color.FromArgb(255, 211, 217, 223));
        }

        private void checkbox_mouseLeave(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            StackPanel stackPanel = (StackPanel)button.Content;
            (stackPanel.Children.OfType<Ellipse>().FirstOrDefault()).Stroke = new SolidColorBrush(Color.FromArgb(255, 232, 236, 240));
        }

        private void checkbox_click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            StackPanel stackPanel = (StackPanel)button.Content;
            if ((stackPanel.Children.OfType<Image>().LastOrDefault()).Visibility == Visibility.Visible)
            {
                (stackPanel.Children.OfType<Image>().LastOrDefault()).Visibility = Visibility.Collapsed;
            }
            else (stackPanel.Children.OfType<Image>().LastOrDefault()).Visibility = Visibility.Visible;
        }

        private void clipImage_MouseEnter(object sender, MouseEventArgs e)
        {
            textbox_image.Source = (ImageSource)this.FindResource("clip_blackDrawingImage");
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));
            chatTextBox.Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));
        }

        private void clipImage_MouseLeave(object sender, MouseEventArgs e)
        {
            textbox_image.Source = (ImageSource)this.FindResource("clip_grayDrawingImage");
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            chatTextBox.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void adminSearchButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            Grid stackPanel = (Grid)button.Content;
            (stackPanel.Children.OfType<Popup>().LastOrDefault()).IsOpen = !(stackPanel.Children.OfType<Popup>().LastOrDefault()).IsOpen;
        }

        private void adminSearchButtonClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void generateSeed_MouseEnter(object sender, MouseEventArgs e)
        {
            generateSeed.Source = (ImageSource)this.FindResource("circle_arrow_blackDrawingImage");
        }

        private void generateSeed_MouseLeave(object sender, MouseEventArgs e)
        {
            generateSeed.Source = (ImageSource)this.FindResource("circle_arrow_grayDrawingImage");
        }

        private void closeAddWalletGridButton_click(object sender, MouseButtonEventArgs e)
        {
            addWalletGrid.Visibility = Visibility.Collapsed;
        }

        private void closeAddDayGridButton_click(object sender, MouseButtonEventArgs e)
        {
            addDayGrid.Visibility = Visibility.Collapsed;
        }

        private void video1_init(object sender, EventArgs e)
        {
            video1.LoadedBehavior = MediaState.Play;
        }

        private void startSearching_Click(object sender, RoutedEventArgs e)
        {
            OnFoundListBox.Items.Add(new ListItem());
        }

        private void BORDER_MouseEnter(object sender, MouseEventArgs e)
        {
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));
            chatTextBox.Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));
        }

        private void BORDER_MouseLeave(object sender, MouseEventArgs e)
        {
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            chatTextBox.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void chatTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));
        }

        private void chatTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            BORDER.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }


        private void leftSettingsButon_Click(object sender, RoutedEventArgs e)
        {
            searchButtonImg.Source = (ImageSource)this.FindResource("searchGrayDrawingImage");
            graphButtonImg.Source = (ImageSource)this.FindResource("graphGrayDrawingImage");
            settingsButtonImg.Source = (ImageSource)this.FindResource("settingsBlackDrawingImage");
            chatButtonImg.Source = (ImageSource)this.FindResource("chatGrayDrawingImage");
            avatarButtonImg.Source = (ImageSource)this.FindResource("adminGrayDrawingImage");
        }

        private void leftChatButton_Click(object sender, RoutedEventArgs e)
        {
            searchButtonImg.Source = (ImageSource)this.FindResource("searchGrayDrawingImage");
            graphButtonImg.Source = (ImageSource)this.FindResource("graphGrayDrawingImage");
            settingsButtonImg.Source = (ImageSource)this.FindResource("settingsGrayDrawingImage");
            chatButtonImg.Source = (ImageSource)this.FindResource("chatBlackDrawingImage");
            avatarButtonImg.Source = (ImageSource)this.FindResource("adminGrayDrawingImage");
        }


        private void leftGraphButon_Click(object sender, RoutedEventArgs e)
        {
            searchButtonImg.Source = (ImageSource)this.FindResource("searchGrayDrawingImage");
            graphButtonImg.Source = (ImageSource)this.FindResource("graphBlackDrawingImage");
            settingsButtonImg.Source = (ImageSource)this.FindResource("settingsGrayDrawingImage");
            chatButtonImg.Source = (ImageSource)this.FindResource("chatGrayDrawingImage");
            avatarButtonImg.Source = (ImageSource)this.FindResource("adminGrayDrawingImage");
        }


        private void avatarButton_Click(object sender, RoutedEventArgs e)
        {
            searchButtonImg.Source = (ImageSource)this.FindResource("searchGrayDrawingImage");
            graphButtonImg.Source = (ImageSource)this.FindResource("graphGrayDrawingImage");
            settingsButtonImg.Source = (ImageSource)this.FindResource("settingsGrayDrawingImage");
            chatButtonImg.Source = (ImageSource)this.FindResource("chatGrayDrawingImage");
            avatarButtonImg.Source = (ImageSource)this.FindResource("adminBlackDrawingImage");
        }

        private void leftSearchButton_Click(object sender, RoutedEventArgs e)
        {
            searchButtonImg.Source = (ImageSource)this.FindResource("searchBlackDrawingImage");
            graphButtonImg.Source = (ImageSource)this.FindResource("graphGrayDrawingImage");
            settingsButtonImg.Source = (ImageSource)this.FindResource("settingsGrayDrawingImage");
            chatButtonImg.Source = (ImageSource)this.FindResource("chatGrayDrawingImage");
            avatarButtonImg.Source = (ImageSource)this.FindResource("adminGrayDrawingImage");
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Background = new SolidColorBrush(Color.FromArgb(255, 239, 242, 245));

        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void WalletSearching_Click(object sender, RoutedEventArgs e)
        {
            onFound.Visibility = Visibility.Visible;
        }
    }
}
