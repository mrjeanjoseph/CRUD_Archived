'use strict';

const express = require("express");
const config = require("./config");
const cors = require("cors");
const bodyParser = require("body-parser");
const eventRoutes = require("./routes/eventRoutes");

const app = express();

app.use(cors());
app.use(bodyParser.json());
app.use("/api", eventRoutes.routes)

app.listen(config.port, function() {
    // console.log(`Server is listening on http://${ config.host}:${ config.port }`);
    console.log(`Server is listening on ${ config.port }`);
});