"use strict";

const events = require("./events");

module.exports.register = async function(server) {
    await events.register( server );
};