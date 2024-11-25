using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerApp.Views;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var entityTemplate = new DataTemplate(typeof(TextCell));
        entityTemplate.SetBinding(TextCell.TextProperty,"Name");

        lstEntities.ItemTemplate = entityTemplate;
        lstEntities.ItemsSource = App.EntityList.GetEntities(); // Get from database
    }
}