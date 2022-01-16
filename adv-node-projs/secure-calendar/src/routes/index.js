"use strict";

const api = require("./api");

module.exports.register = async function(server) {

    await api.register( server );

    server.route({
        method: "GET",
        path: "/",
        handler: async function(request, h) {
            return "<h1>Welcome to Calendar App!</h1>";
        }
    });
};