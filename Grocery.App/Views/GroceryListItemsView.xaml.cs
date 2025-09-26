using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
    private readonly GroceryListItemsViewModel viewModel;
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
        this.viewModel = viewModel;
    }

    private void Searchbar_SearchButtonPressed(object sender, EventArgs e)
    {
        this.viewModel.Searchbar_SearchButtonPressed(sender, e);
    }
}
