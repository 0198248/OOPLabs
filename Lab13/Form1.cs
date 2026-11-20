using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;

namespace WeatherFileApp
{
    public partial class MainForm : Form
    {
        private WeatherReading? _currentReading;
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetBusy(bool isBusy)
        {
            loadButton.Enabled = !isBusy;
            openButton.Enabled = !isBusy;
            saveButton.Enabled = !isBusy && _currentReading is not null;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            statusLabel.Text = "Завантаження...";
            try
            {

                _currentReading = await WeatherService.LoadLutskAsync();
                ShowReading(_currentReading);
                statusLabel.Text =
                    $"Дані отримано з {WeatherService.SourceName}.";

                temperatureText.Text = $"{_currentReading.TemperatureC:F1} °C";
                humidityText.Text = $"{_currentReading.HumidityPercent} %";
                timeText.Text = _currentReading.ObservationTime;
                CityName.Text = _currentReading.City;
                statusLabel.Text = "Дані завантажено з інтернету";
            }
            catch (HttpRequestException)
            {
                statusLabel.Text = "Не вдалося з’єднатися із сервером.";
            }
            catch (TaskCanceledException)
            {
                statusLabel.Text = "Сервер не відповів за відведений час.";
            }
            catch (JsonException)
            {
                statusLabel.Text =
                "Сервер повернув дані неочікуваного формату.";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Сталася непередбачена помилка.";
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                SetBusy(false);
            }
        }
        private void ShowReading(WeatherReading reading)
        {
            CityName.Text = reading.City;
            temperatureText.Text =
            $"{reading.TemperatureC:F1} °C";
            humidityText.Text =
            $"{reading.HumidityPercent} %";
            timeText.Text = reading.ObservationTime;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (_currentReading is null)
            {
                statusLabel.Text =
                "Спочатку завантажте або відкрийте дані.";
                return;

            }
            using SaveFileDialog dialog = new()
            {
                Title = "Зберегти дані про погоду",
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json",
                AddExtension = true,
                FileName = $"weather-{DateTime.Now:yyyy-MM-dd}.json"
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                statusLabel.Text = "Збереження скасовано.";
                return;
            }
            SetBusy(true);
            statusLabel.Text = "Збереження файла...";
            try
            {
                WeatherSnapshot snapshot = new()
                {
                    DataSource = WeatherService.SourceName,
                    SourceUrl = WeatherService.SourceUrl,
                    SavedAt = DateTimeOffset.Now,
                    Reading = _currentReading
                };
                await JsonFileService.SaveAsync(
                dialog.FileName,
                snapshot);
                statusLabel.Text =
                $"Файл збережено: {Path.GetFileName(dialog.FileName)}";
            }
            catch (UnauthorizedAccessException)
            {
                statusLabel.Text =
                "Немає дозволу на запис у вибране місце.";
            }
            catch (IOException)
            {
                statusLabel.Text =
                "Не вдалося записати файл. Можливо, він уже відкритий.";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Не вдалося зберегти файл.";
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private async void openButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new()
            {
                Title = "Відкрити дані про погоду",
                Filter = "JSON files (*.json)|*.json",
                CheckFileExists = true,
                Multiselect = false
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                statusLabel.Text = "Відкриття скасовано.";
                return;
            }
            SetBusy(true);
            statusLabel.Text = "Читання файла...";
            try
            {
                WeatherSnapshot snapshot =
                await JsonFileService.LoadAsync<WeatherSnapshot>(
                dialog.FileName);
                WeatherReading? reading = snapshot.Reading;
                if (reading is null)
                {
                    throw new JsonException(
                    "У файлі відсутній об’єкт reading.");
                }
                _currentReading = reading;
                ShowReading(reading);

                string localSavedTime = snapshot.SavedAt
                .ToLocalTime()
                .ToString("g");
                statusLabel.Text =
                $"Відкрито {Path.GetFileName(dialog.FileName)}. " +
                $"Збережено: {localSavedTime}.";
            }
            catch (JsonException)
            {
                statusLabel.Text =
                "Файл не є коректним файлом даних цього застосунку.";
            }
            catch (UnauthorizedAccessException)
            {
                statusLabel.Text =
                "Немає дозволу на читання вибраного файла.";
            }
            catch (IOException)
            {
                statusLabel.Text = "Не вдалося прочитати файл.";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Не вдалося відкрити файл.";
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                SetBusy(false);
            }
        }
    }
}
