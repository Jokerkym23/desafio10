using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace Desafio10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Juego> Juegos = new List<Juego>
            {
                new Juego { Equipo1 = "Barcelona", Equipo2 = "Real Madrid", Puntaje1 = 3, Puntaje2 = 2, Progreso = 85 },
                new Juego { Equipo1 = "PSG", Equipo2 = "Bayer Munich", Puntaje1 = 3, Puntaje2 = 5, Progreso = 55 },
                new Juego { Equipo1 = "BVB Dormunt", Equipo2 = "As Roma", Puntaje1 = 0, Puntaje2 = 1, Progreso = 25 },
                new Juego { Equipo1 = "Man United", Equipo2 = "Ajax", Puntaje1 = 1, Puntaje2 = 1, Progreso = 15 }
            };

            lbJuego.ItemsSource = Juegos;
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            if (lbJuego.SelectedItem != null)
            {
                var juegoSeleccionado = lbJuego.SelectedItem as Juego;
                MessageBox.Show($"Juego Seleccionado: {juegoSeleccionado.Equipo1} {juegoSeleccionado.Puntaje1} - {juegoSeleccionado.Equipo2} {juegoSeleccionado.Puntaje2}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbJuego.SelectedItem != null)
            {
                var juegoSeleccionado = lbJuego.SelectedItem as Juego;
                var infoPartido = $"Has seleccionado este partido: {juegoSeleccionado.Equipo1} {juegoSeleccionado.Puntaje1} - {juegoSeleccionado.Equipo2} {juegoSeleccionado.Puntaje2}";
                MessageBox.Show($"{infoPartido}\n\nLa información se cargara en un archivo de texto");

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\LENOVO FLEX\Desktop\Tareas de Programacion I\Desafio10\Desafio10\Partidos.txt", true))
                {
                    file.WriteLine(infoPartido);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un partido para poder generar un archivo de texto.");
            }
        }
    }
}