const express = require("express");
const artistController = require("../controllers/artistController.js");
const artistRouter = express.Router();
 
artistRouter.use("/postArtist", artistController.postArtist);
artistRouter.use("/create", artistController.addArtist);
artistRouter.use("/details", artistController.getArtistDetails);
artistRouter.use("/", artistController.getArtists);
 
module.exports = artistRouter;