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
            new CustomDataObject { ImageLocation = "Assets/image1.png" },
            new CustomDataObject { ImageLocation = "Assets/image2.png" },
            new CustomDataObject { ImageLocation = "Assets/image3.png" }
            };

            // DataContext 설정
            this.DataContext = this;
        }

    }
}
