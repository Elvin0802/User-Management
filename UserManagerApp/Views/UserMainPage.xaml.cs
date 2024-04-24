using System.Windows;
using UserManagement.Models;

namespace UserManagement.Views;

public partial class UserMainPage : Window
{
    List<City> AzCities;

    List<User>? Users;

    public UserMainPage()
    {
        InitializeComponent();

        AzCities = JsonOpers.GetCities();
        Users = JsonOpers.Read();

        CitiesCB.ItemsSource = AzCities;

        lb.ItemsSource = Users;
    }

    private void UserAddButton_Click(object sender, RoutedEventArgs e)
    {
        var u = new User(NameText.Text, SurnameText.Text, (AzCities[CitiesCB.SelectedIndex]).ToString(),
                (bool)male.IsChecked!, (bool)CheckStep.IsChecked!);

        Users!.Add(u);

        lb.Items.Refresh();

        MessageBox.Show("User Added.","Operaion",MessageBoxButton.OK,MessageBoxImage.Information);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        JsonOpers.Write(Users!);
        MessageBox.Show("Users Saved.","Operaion",MessageBoxButton.OK,MessageBoxImage.Information);
    }
}
