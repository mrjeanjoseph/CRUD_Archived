"use strict";

const express = require("express");

const eventController = require("../controllers/eventController");

const router = express.Router();

const { getEvents } = eventController;

router.get('/events', getEvents);
//Unable to connect to db error persists

module.exports = { routes: router };