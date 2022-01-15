"use strict";

const events = require("./events");
const sql = require("mssql");

const client = async function(server, config ) {
    let pool = null;

    const closePool = async function() {
        try {
            await pool.close();
            pool = null;

        } catch (error) {
            pool = null;
            console.log( error );
        }
    };

    const getConnection = async function() {
        try {
            if (pool) {
                return pool;
            }
            pool = await sql.connect( config );
            pool.on("error", function( error ) {
                console.log(error);
                await closePool();
            });
            return pool;
        } catch (error) {
            pool = null;
            console.log( error );
        }
    };

    return {
        events: await events.register( {
            sql, getConnection
        })
    };
};

module.exports = client;