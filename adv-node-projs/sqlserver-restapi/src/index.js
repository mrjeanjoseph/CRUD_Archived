import app from './app.js';

app.listen(app.get("port"));
console.log("server is listening", app.get("port"));