const express = require("express");
const app = express();
const dotenv = require("dotenv");
const mongoose = require("mongoose");

const TodoTask = require("./models/TodoTask");

dotenv.config();

app.use("/static", express.static("public"));

app.use(express.urlencoded({ extended: true}));

mongoose.set("useFindAndModify", false);

mongoose.connect(process.env.DB_CONNECT, { useNewUrlParser: true }, () => {
    console.log("Connected to db!");

    app.listen(3000, () => console.log("Server Up and running"));
})

app.set("view engine", "ejs");


app.get('/',(req, res) => {
    res.render('todo.ejs');
});

app.get('/',(req, res) => {
    console.log(req.body);
});