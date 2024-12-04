using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ANULink
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfileWindow : Window
    {
        private MainWindow _mainWindow;
        public ProfileWindow(MainWindow mainWindow)
        {
            this.InitializeComponent();
            _mainWindow = mainWindow;  // MainWindow ��ü �Ҵ�
        }
        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            // �Էµ� �� ��������
            string name = NameTextBox.Text;
            string position = PositionTextBox.Text;
            string Feed1 = UserFeed1.Text;
            string Feed2 = UserFeed2.Text;
            string Feed3 = UserFeed3.Text;

            // ���� â�� ������ ������Ʈ
            _mainWindow.UpdateProfile(name, position, Feed1, Feed2, Feed3);

            // â �ݱ�
            this.Close();
        }
    }
}
