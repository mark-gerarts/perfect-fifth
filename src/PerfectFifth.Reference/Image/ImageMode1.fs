module P5Reference.Image.ImageMode1

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/bricks.jpg"

let draw p5 img =
    imageMode p5 Corners
    imageWithSize p5 img 10 10 90 40

let run node = displayWithPreload node preload draw
