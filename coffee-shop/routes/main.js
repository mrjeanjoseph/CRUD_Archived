const express = require('express');
const router = express.Router();

router.get('/', function(req, res, next) {
    res.render('homepage', req.context);
})
router.get('/blog', function(req, res, next) {
    res.render('blog', req.context);
})

module.exports = router;