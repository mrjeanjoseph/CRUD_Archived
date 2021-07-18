const express = require("express");
const app = express();
const dotenv = require(“dotenv”);

dotenv.config();

app.use("/static", express.static("public"));

app.use(express.urlencoded({ extended: true}));

app.set("view engine", "ejs");


app.get('/',(req, res) => {
    res.render('todo.ejs');
});

app.get('/',(req, res) => {
    console.log(req.body);
});

app.listen(3000, () => console.log("Server Up and running"));