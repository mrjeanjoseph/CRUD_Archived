"use strict";

module.exports.register = async function(server) {
    server.route({
        method: "GET",
        path: "/",
        handler: async function(request, h) {
            return "<h1>Welcome to Calendar App!</h1>";
        }
    });
};