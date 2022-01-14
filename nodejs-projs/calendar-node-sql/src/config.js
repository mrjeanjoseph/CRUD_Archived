"use strict";

const dotenv = require("dotenv");

dotenv.config();

const {
    PORT,
    HOST,
    HOST_URL,
    COOKIE_ENCRYPT_PWD,
    SQL_SERVER,
    SQL_DATABASE,
    SQL_USER,
    SQL_PASSWORD,
    OKTA_ORG_URL,
    OKTA_CLIENT_ID,
    OKTA_CLIENT_SECRET
} = process.env;

const sqlEncrypt = process.env.SQL_ENCRYPT === "true";

