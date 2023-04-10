module P5Reference.Image.Filter4

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/bricks.jpg"

let draw p5 img =
    image p5 img 0 0
    filter p5 (Posterize 3)

let run node = displayWithPreload node preload draw
