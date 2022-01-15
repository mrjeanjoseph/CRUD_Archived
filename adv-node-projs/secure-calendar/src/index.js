"use strict";

const server = require("./server");

const startServer = async function(){
    try {
        const config = {
            host: "localhost",
            port: 2022
        };
        const app = await server(config);
        await app.start();

        console.log(`Server is listening at http://${config.host}:${config.port}`);

    } catch (error) {
        console.log("Error starting up the server", error);
    }
};

startServer();