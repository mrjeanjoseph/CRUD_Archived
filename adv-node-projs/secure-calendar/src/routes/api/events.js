"use strict";

module.exports.register = async function(server) {
    server.route({
        method: "GET",
        path: "/api/events",
        handler: async function(request) {
            try {
                const db = request.server.plugins.sql.client;
                const userId = "user0113";
                const res = await db.events.getEvents(userId);
                return res.recordset;

            } catch (error) {
                console.log("Error from the Events folder", error);
            }
        }
    })
}