const express = require("express");
const app = express();
const artistRouter = require("./routes/artistRouter");
const homeRouter = require("./routes/homeRouter");
 
app.set("view engine", "hbs");
app.use(express.urlencoded({ extended: false }));

app.use("/artists", artistRouter);;
app.use("/", homeRouter);
 
app.use(function (req, res, next) {
    res.status(404).send("Not Found")
});
 
app.listen(3000, ()=>console.log("The server is running and waiting for a connection..."));