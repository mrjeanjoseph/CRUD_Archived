"use script";

const events = require("./events");
const sql = require("mssql");

const client = async function(server, config) {
    let pool = null;

    const closePool = async function() {
        try {
            await pool.close();
            pool = null;
        } catch (err) {
            pool = null;
            console.log("Genyen yon ere! " + err);
        }
    };

    const getConnection = async function() {
        try {
            if(pool) {
                return pool;
            }
            pool = await sql.connect(config);
            pool.on("error", async function(err) {
                console.log("Geyen yon ere!" + err);
                await closePool();
            });
            return pool; // caught up error here 
        } catch (err) {
            console.log("Genyen yon ere! " + err);
            pool = null;
        }
    };

    return {
        events: await events.register({
            sql, getConnection
        })
    };
};

module.exports = client;