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

        //definen las propiedades 
        //de la vista xaml.c al tipo lista
        //tipo de coleccion , porpiedad de tipo task.
        // lo  mismo que title set y get

        //que propiedades son 
        //modelos=objetos de la base de datos
        //modelo que simula la infor de la bd
        //rn odel creo una clase de tipo taskmodels



        //Configura el ListView para que muestre el título y la descripción de cada tarea.


        public int Id { get; set; }
        public string Description { get; set; }
        public bool iscompleted { get; set; }

        String title;
        public String Title
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

        private List<Taskmodels> Taskmodels;
          
        public TaskViewModel()
        {
            Tasks= new ObservableCollection<Taskmodels>();
            Taskmodels = new List<Taskmodels>();
            Save = new Command(() =>
            {

                Taskmodel task = new TaskModel();
                task.Title = this.Title;
                TaskViewModel.Add(task);
            });
            Get = new Command(() =>
            {

                Tasks = new ObservavleCollection<TaskModel>(Tas)



            });

    }
}
