using Xamarin.Forms;

namespace AccesibilidadDemo.Pages
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
    
}
