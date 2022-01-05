const express = require('express');
const exphbs = require('express-handlebars');
const bodyParser = require('body-parser');
const mysql = require('mysql');

const app = express();
const port = process.env.PORT || 2022;

// const port = 5000;



app.listen(port, function() {
    console.log(`Listening on port ${port}`);
})