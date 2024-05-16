Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim wo = New WeatherOptions()
        Dim weather = wo.GetRandomWeatherOptions()


        weatherIconlabel.Text = weather.WeatherIcon
        weatherTextLabel.Text = weather.WeatherText
        weatherDescriptionLabel.Text = weather.WeatherDescription

    End Sub
End Class