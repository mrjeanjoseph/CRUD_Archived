const express = require("express");
const path = require("path");

const app = express();
app.get("/*", function(request, response) {
    response.sendFile(path.resolve("frontend", "index.html"));
});

app.listen(process.env.PORT || 2022, function(){
    console.log("Server is running...,")
})