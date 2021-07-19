window.addEventListener("load", () => {
    let lon;
    let lat;
    let temperatureDescription = document.querySelector(".temperature-description");
    let temperatureDegree = document.querySelector(".temperature-degree");
    let locationTimezone = document.querySelector(".location-timezone");

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(longLatResult => {
            lon = longLatResult.coords.longitude;
            lat = longLatResult.coords.latitude;

            // let apiKey = '8f886488638f4ae9b49d7a6c1c840c2f';
            const proxy = "https://cors-anywhere.herokuapp.com/";
            // const apiUrl = `https://api.openweathermap.org/data/2.5/weather?lat=${ lat }&lon=${ lon }&appid=${ apiKey }`;
            const apiurl2 = `${ proxy }https://api.darksky.net/forecast/fd9d9c6418c23d94745b836767721ad1${lat},${lon}`;


           fetch(apiurl2)
                .then(response => {
                    return response.json();
                })
                .then(data => {
                    console.log(data);
                     const { temperature, summary } = data.currently;
                });
                // temperatureDegree.textContent = temperature;
                // temperatureDescription.textContent = summary;
        });
    }
});