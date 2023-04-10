module P5Reference.Image.ImageMode2

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/bricks.jpg"

let draw p5 img =
    imageMode p5 Center
    imageWithSize p5 img 50 50 80 80

let run node = displayWithPreload node preload draw
