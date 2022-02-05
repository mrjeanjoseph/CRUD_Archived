const express = require('express');

const app = express();
const port = 2022;

app.get('/', (request, response) => {
    response.send("<h1>Hello");
});

app.listen(port, () => console.log('Server running on port ' + port));