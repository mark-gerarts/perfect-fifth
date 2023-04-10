module P5Reference.Image.ImageMode0

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/bricks.jpg"

let draw p5 img =
    imageMode p5 Corner
    imageWithSize p5 img 10 10 50 50

let run node = displayWithPreload node preload draw
