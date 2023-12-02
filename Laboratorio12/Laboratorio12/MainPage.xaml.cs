using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<TaskModel> myList = new List<TaskModel>
            {

               new TaskModel{Title="Monday", Description="¡Listen Friday I'm In Love! by the cure", IsCompleted="True"}
               
            myListView.ItemSource = myList;
        }
    }
}
