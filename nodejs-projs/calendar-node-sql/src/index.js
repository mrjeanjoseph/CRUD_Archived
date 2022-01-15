"use strict";

const config = require("./config");
const server = require("./server");

const startServer = async function() {
    try{
        // const config = { 
        //     host: "localhost", 
        //     port: 2022
        // };

        const app = await server(config);
        await app.start();

        console.log(`Server running at http://${config.host}:${config.port} all day - everyday!`);
    } catch(err){
        console.log("Startup Error detected - ", err);
    }
}

startServer();