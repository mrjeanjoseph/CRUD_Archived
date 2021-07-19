window.addEventListener("load", () => {
    let lon;
    let lat;
    let zipCode;

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(longLatResult => {
            lon = longLatResult.coords.longitude;
            lat = longLatResult.coords.latitude;

            let apiKey = '8f886488638f4ae9b49d7a6c1c840c2f';
            // let proxy = "https://cors-anywhere.herokuapp.com/corsdemo";
            
            // const apiUrl = `api.openweathermap.org/data/2.5/weather?${lat}&${lon}&appid=${apiKey}`;
            // const apiUrl = `api.openweathermap.org/data/2.5/weather?zip=27610,1&appid=${apiKey}`;
            const apiUrl = `https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=${ apiKey }`;

            fetch(apiUrl)
                .then(response => {
                    return response.json();
                })
                .then(data => {
                    console.log(data);
                });
        });
    }
});