using Laboratorio12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio12.ViewModels
{
    public class TaskViewModel : ViewModelsBasic
    {


        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } // Cambié "iscompleted" a "IsCompleted" para seguir las convenciones de nomenclatura de C#

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        private List<TaskModel> taskModels; //nombre del modelo.

        public ObservableCollection<TaskModel> Tasks { get; set; } // propiedad Tasks

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();
            taskModels = new List<TaskModel>();
            Save = new Command(() =>
            {
                TaskModel task = new TaskModel(); /
                task.Title = this.Title;
                taskModels.Add(task);
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(taskModels);
            });
        }
    }
}
