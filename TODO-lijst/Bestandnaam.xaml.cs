﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace TODO_lijst
{
    /// <summary>
    /// Interaction logic for Bestandnaam.xaml
    /// </summary>
    public partial class Bestandnaam : Window
    {
        MainWindow _mainWindow;
     
    
        string fileName;
        public Bestandnaam(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            comboboxbestanden.Items.Add("None");

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //alle bestanden die met json eindigen komen in de combobox
            string[] files = Directory.GetFiles(desktopPath,"*.json");

           
            foreach (string file in files)
            {
                 fileName = Path.GetFileName(file);
                comboboxbestanden.Items.Add(fileName);
            }
           
        }

        private void Toevoegen_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtbestandNaam.Text != "")
                {
                    if (Path.GetExtension(txtbestandNaam.Text).Equals(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        string BestandNaam = txtbestandNaam.Text;

                        MessageBox.Show("Bestand toegevoegd!");


                        _mainWindow.BestandToegvoegen(BestandNaam);


                    }
                    else
                        MessageBox.Show("Je moet .json achter bestandnaam zetten!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Je moet eerst een bestandnaam intypen!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmbxbestanden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            listboxbestand.Items.Clear();

            try
            {
                if (comboboxbestanden.SelectedItem != null && comboboxbestanden.SelectedItem.ToString() != "None")
                {
                    string selectedFileName = comboboxbestanden.SelectedItem.ToString();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, selectedFileName);

                    string fileContent = File.ReadAllText(filePath);

                    //Om de tekst mooi in de list te tonen
                    string[] splitsen = fileContent.Split(',');
                    foreach (string s in splitsen)
                    {
                        listboxbestand.Items.Add(s.Trim('[', ']', '"'));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bewerken_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comboboxbestanden.SelectedItem != null && comboboxbestanden.SelectedItem.ToString() != "None")
                {
                    string selectedFileName = comboboxbestanden.SelectedItem.ToString();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, selectedFileName);
                    string fileContent = File.ReadAllText(filePath);

                    //gegevens versturen naar de window van bewerken
                    _mainWindow.GegevensBewerkenOpenen(fileContent,selectedFileName,filePath);
                }
                else
                    MessageBox.Show("Selecteer eerst een bestand om te bewerken!","Fout",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void Verwijderen_click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                if (comboboxbestanden.SelectedItem != null && comboboxbestanden.SelectedItem.ToString() != "None")
                {
                    string selectedFileName = comboboxbestanden.SelectedItem.ToString();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, selectedFileName);

                    //het bestand verwijderen uit het bureaublad en combobox
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        MessageBox.Show("Het bestand is verwijderd!");

                        // Verwijder het geselecteerde item uit de combobox
                        comboboxbestanden.Items.Remove(comboboxbestanden.SelectedItem);

                        // Wis de selectie in de combobox
                        comboboxbestanden.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Het geselecteerde bestand kan niet worden gevonden.");
                    }
                }
                else
                {
                     MessageBox.Show("Selecteer eerst een bestand om te verwijderen!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message, "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            //heel het programma sluiten
            _mainWindow.Close();
          
        }
    }
}
