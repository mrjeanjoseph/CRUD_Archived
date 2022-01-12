const express = require('express');
const fileUpload = require('express-fileupload');
const path = require('path');

const app = express();

app.set('view engine', 'ejs');
app.use(fileUpload())

app.get('/', async function (request, response, next) {
    response.render('index');
});

app.post('/single', async function (request, response, next) {
    try {
        const file = request.files.mFile;
        console.log(file);

        const customFileName = new Date().getTime().toString() + path.extname(file.name);
        const savePath = path.join(__dirname, 'public', 'uploads', customFileName);

        await file.mv(savePath);
        response.redirect('/');

    } catch (error) {
        console.log(error);
        response.send("Error uploading file");
    }
})

const port = 2022;
app.listen(port, function () {
    console.log('server is listening on ' + port);
});