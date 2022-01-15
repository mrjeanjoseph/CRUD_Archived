
"use strict";

const fs = require("fs-extra");
const { join } = require(" path ");

const loadSqlQueries = async function (folderName) {
    const filePath = join(process.cwd(), "src", "data", folderName);
    const files = await fs.readdir(filePath);
    const sqlFiles = files.filter(function (f) {
        f.endsWith(".sql")
    });

    const queries = {};
    for (const sqlFile of sqlFiles) {
        const query = fs.readFileSync(join(filePath, sqlFile), { encoding: "UTF8" });
        queries[sqlFile.replace(".sql", "")] = query;
    }
    return queries;
}
module.exports = { loadSqlQueries };