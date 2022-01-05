const mysql = require('mysql');

//inlude mysql
const pool = mysql.createPool({
    connectionLimit: 100,
    host: process.env.DB_HOST,
    user: process.env.DB_USER,
    password: process.env.DB_PASS,
    database: process.env.DB_NAME
});

//connect to DB

//get views
exports.view = function (req, res) {
    pool.getConnection(function (err, connection) {
        if (err) throw err;
        console.log('Connected as ID' + connection.threadId);
        connection.query('SELECT * FROM user', function (err, rows) {
            connection.release();
            if (!err) {
                res.render('home', { rows });
            } else {
                console.log(err);
            }
            console.log("Data from db\n", rows);
        });
    });
};

//find user by search
exports.find = function (req, res) {
    pool.getConnection(function (err, connection) {
        if (err) throw err;
        console.log('Connected as ID' + connection.threadId);

        let searchTerm = req.body.search;
        // console.log(searchTerm);

        connection.query('SELECT * FROM user WHERE first_name LIKE ?', [`%${searchTerm}%`], function (err, rows) {
            //This peice of code is not filtering like it is supposed to.
            connection.release();
            if (!err) {
                res.render('home', { rows });
            } else {
                console.log(err);
            }
            console.log("Data from db\n", rows);
        });
    });
}


exports.find = function (req, res) {
    res.render('add-user');
}