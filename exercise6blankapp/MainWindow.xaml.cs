using aspnetcoreapi.Modeller;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace exercise6blankapp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<Student> studentlist = new ObservableCollection<Student>();

        public ObservableCollection<Course> courselist = new ObservableCollection<Course>();
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
            gatherstudents();
            gathercourses();
        }
        private async void gatherstudents() 
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44391/api/student");
            var content = await response.Content.ReadAsStringAsync();
            Student[] getStudents = JsonConvert.DeserializeObject<Student[]>(content);
            foreach (var student in getStudents)
            {
                studentlist.Add(student);
            }

        }
        private async void gathercourses()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44391/api/courses");
            var content = await response.Content.ReadAsStringAsync();
            Course[] getCourses = JsonConvert.DeserializeObject<Course[]>(content);
            foreach (var course in getCourses)
            {
                courselist.Add(course);
            }

        }

    }
}
