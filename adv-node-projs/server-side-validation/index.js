const express = require('express');
const path = require('path');
const port = 2022;
const app = express();
const bodyParser = require('body-parser');

let urlencoded = bodyParser.urlencoded({ urlencoded: false});

app.use(bodyParser.json());
app.use(urlencoded);
app.use(express.static(__dirname + '/public'));

app.get('/', (request, response) => {
    response.sendFile(path.join(__dirname + '/dashboard.html'));
});

app.listen(port, () => console.log('Server running on port ' + port));