const express = require('express');
const router = express.Router();

router.get('/', function(req, res, next) {
    res.send('this is the main page again!');
})

module.exports = router;