using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomizerApp.Models;


namespace RandomizerApp.Views;

public partial class Main : ContentPage
{
    public Main()
    {
        InitializeComponent();
        Title = "Add New Item";
    }
    
    private async void AddEntity_OnClicked(object sender, EventArgs e)
    {
        var newEntity = new Entity();
        newEntity.Name = txtEntity.Text;
        
        App.EntityList.SaveEntity(newEntity); // Save to database

        txtEntity.Text = "";

        await DisplayAlert("Success", "Item Added!", "Ok");
    }

    private void Randomize_OnClicked(object sender, EventArgs e)
    {
        var randomEntity = App.EntityList.GetRandomEntity();

        if (randomEntity != null)
        {
            lblRandom.Text = randomEntity.Name;
        }
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        lblRandom.Text = String.Empty;
    }
}