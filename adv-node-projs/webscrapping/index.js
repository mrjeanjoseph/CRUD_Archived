const axios = require("axios");

const cheerio = require("cheerio");

const express = require("express");

const app = express()

//getting access to the url
const url = "https://theguardianfoundation.org/";
axios(url)
    .then(function(response){
        const html = response.data
        const $ = cheerio.load(html);
        const articles = [];
        //console.log(html);

        $(".text-site2", html).each(function() {
            const title = $(".text-site1").text();
            const url = $(this).find('a').attr("href");
            articles.push({title: title, url: url});
        });
        console.log(articles)
    }).catch(function(error){
        console.log(error);
    })


const PORT = 2022;
const localhost = "localhost";
app.listen(PORT, function(){
    console.log(`server is running on ${localhost}:${PORT}`);
})
