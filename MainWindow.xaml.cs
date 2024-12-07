using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml.Media.Imaging;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ANULink
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public class CustomDataObject
    {
        public string ImageLocation { get; set; }
    }


    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<CustomDataObject> ItemsCollection { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
            
            // 샘플 데이터 추가
            ItemsCollection = new ObservableCollection<CustomDataObject>
            {
            new CustomDataObject { ImageLocation = "ms-appx:///Assets/image1.png" },
            new CustomDataObject { ImageLocation = "ms-appx:///Assets/image2.png" },
            new CustomDataObject { ImageLocation = "ms-appx:///Assets/image3.png" }
            };

        }
        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // GridView에서 선택된 항목 가져오기
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is CustomDataObject selectedItem)
            {
                // 확대 이미지를 업데이트
                SelectedImage.Source = new BitmapImage(new Uri(selectedItem.ImageLocation));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(this);
            profileWindow.Activate();
        }
        // 프로필 업데이트 메서드
        public void UpdateProfile(string name, string position, string Feed1, string Feed2, string Feed3)
        {
            // 사용자 이름과 직책을 업데이트하는 로직을 여기에 추가
            // 예시: TextBlock이나 다른 UI 요소에 값 설정
            UserNameTextBlock.Text = name;
            UserPositionTextBlock.Text = position;
            UserFeed1.Text = Feed1;
            UserFeed2.Text = Feed2;
            UserFeed3.Text = Feed3;
        }

    }
}
