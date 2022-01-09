const express = require('express');
const router = express.Router();

router.get('/', function(req, res, next) {
    const data = {
        title: "kafe Kiskeya ou Boyo!",
        deskripsyon: "Nou apresye ou menm avek fanmi/zanmi'w vinn dine nan restaurant sa a. Mwen swete nou jwen yon bon ekperyans." 
    }

    res.render('homepage', data);
})

module.exports = router;