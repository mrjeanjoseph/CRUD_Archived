"use strict";

const fs = require("fs-extra");
const { join } = require("path");

//It is best practice to keep sql files separated from the rest of the project 
const loadSqlQueries = async function (folderName) {
    const filePath = join(process.cwd(), "src", "data", folderName);
    const files = await fs.readdir(filePath);
    const sqlFiles = files.filter(function (f) {
        f.endsWith(".sql")
    });
    const queries = {};

    for (const sqlFile of sqlFiles) {
        const query = fs.readFileSync(join(filePath, sqlFile), { encoding: "UTF-8" });

        queries[sqlFile.replace(".sql", "")] = query;
    }
    return queries;
};

module.exports = { loadSqlQueries };
