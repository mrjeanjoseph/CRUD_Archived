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

            let apiKey = '8f886488638f4ae9b49d7a6c1c840c2f';
            // const proxy = "https://cors-anywhere.herokuapp.com/";
            const apiUrl = `https://api.openweathermap.org/data/2.5/weather?lat=${ lat }&lon=${ lon }&appid=${ apiKey }`;

           fetch(apiUrl)
                .then(response => {
                    return response.json();
                })
                .then(data => {
                     const { temp } = data.main;
                     const { description } = data.weather[2].description;

                     temperatureDegree.textContent = temp;
                     temperatureDescription.textContent = data.weather[2];
                     console.log(description);

                     locationTimezone.textContent = data.name;
                });
        });
    }
});