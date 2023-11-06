
using Syncfusion.Maui.DataGrid;
using System.Globalization;

namespace MauiApp1
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            dataGrid.AutoGeneratingColumn += SfDataGrid_AutoGeneratingColumn;
        }

        private void SfDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if ( e.Column.MappingName == "TaskPending")
            {
                e.Cancel = true;
            }
        }
    }
}


