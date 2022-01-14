"use strict";

module.exports.register = async function(server) {
    server.route( {
        method: "GET",
        path: "/",
        handler: async function(request, h) {
            return "Bel Travay lakay tout bon vre";
        }
    });
};