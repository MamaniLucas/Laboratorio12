﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio12.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskView : ContentPage
    {
        public TaskView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.TaskViewModel();
        }
    }
}