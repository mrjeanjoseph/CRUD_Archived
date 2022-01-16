const axios = require("axios");

const cheerio = require("cheerio");

const express = require("express");

const app = express()

const PORT = 2022;
const localhost = "localhost";
app.listen(PORT, function(){
    console.log(`server is running on ${localhost}:${PORT}`);
})
