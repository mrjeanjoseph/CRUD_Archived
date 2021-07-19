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
            const apiUrl = `https://api.openweathermap.org/data/2.5/weather?lat=${ lat }&lon=${ lon }&appid=${ apiKey }`;

            fetch(apiUrl)
                .then(response => {
                    return response.json();
                })
                .then(data => {
                    console.log(data);
                    const { temperature, summary } = data.currently
                });
                temperatureDegree.textContent = temperature;
                temperatureDescription.textContent = summary;
        });
    }
});