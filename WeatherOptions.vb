Public Class WeatherOptions
    Public WeatherIcon As String
    Public WeatherText As String
    Public WeatherDescription As String

    Public Shared Function GetRandomWeatherOptions() As WeatherOptions
        Dim weatherOptions As New WeatherOptions()
        Dim random As New Random()

        Dim weatherItems As New List(Of WeatherOptions)()
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "☀️", .WeatherText = "Sunny", .WeatherDescription = "It's sunny out, so there is no need to take any precautions except maybe some sun screen!"})
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "🌧️", .WeatherText = "Rainy", .WeatherDescription = "There seems to be a fair amount of rain, maybe grab an umbrella or a rain coat, or something."})
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "☁️", .WeatherText = "Cloudy", .WeatherDescription = "It's cloudy today. I suppose you don't need to do anything, but don't be upset if you're not getting some vitiman D."})
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "❄️", .WeatherText = "Snowy", .WeatherDescription = "For some reason it's snowing, and that's bizarre. You should keep warm, and don't drive too much, if at all."})
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "🌪️", .WeatherText = "Tornado", .WeatherDescription = "There is a tornado warning in effect. This is real Wizard of Oz stuff. I would find some shelter and not browse this site anymore."})
        weatherItems.Add(New WeatherOptions() With {.WeatherIcon = "⚡", .WeatherText = "Thunderstorm", .WeatherDescription = "Thumderstorm! Certain to be some heavy rain and lightning. Don't get struck!"})

        Dim randomIndex As Integer = random.Next(0, weatherItems.Count)
        Return weatherItems(randomIndex)
    End Function
End Class
