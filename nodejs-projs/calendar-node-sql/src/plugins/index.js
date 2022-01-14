"use strict";

const sql = require("./sql");

module.exports.register = async function(server) {
    await server.register(sql);
}