using System;
using System.Collections.Generic;
using AccesibilidadDemo.Service;
using Xamarin.Forms;

namespace AccesibilidadDemo.Pages
{
    public partial class Lista2Page : ContentPage
    {
        class Person
        {
            public Person(string name, Color color)
            {
                this.Name = name;
                this.Color = color;
            }

            public string Name { private set; get; }

            public Color Color { private set; get; }
        };
        public Lista2Page()
        {
            InitializeComponent();

            List<Person> people = new List<Person>
            {
                new Person("Maria",  Color.Green),
                new Person("Ana", Color.Green),

                new Person("Pedro", Color.Red),
                new Person("Juan", Color.Green)
            };

            lista.ItemsSource = people;
        }

        void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            var people = list.ItemsSource as List<Person>;
            people.Add(new Person("Alumno " + people.Count, Color.Green));



            lista.ItemsSource = new List<Person>(people);

            DependencyService.Get<IAccessibility>().PostVoiceOver("Datos de los alumnos actualizados");


            list.IsRefreshing = false;
        }
    }
}
