//This is the backend server
const express = require('express');
const bodyParser = require("body-parser");
const path = require("path");
const httpMsgs = require("http-msgs");

const app = express();
app.listen(2022);
app.use(bodyParser.urlencoded({ extended: false }));

app.use(express.static("assets"));
app.get("/", function (req, res) {
    res.sendFile(path.join(__dirname, "index.html"));
});

app.post("/ajaxdemo", function (req, res) {
    var data = req.body;
    console.log(data);

    httpMsgs.sendJSON(req, res, {
        from: "server"
    });
});