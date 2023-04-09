module P5Reference.Image.NoTint

open P5.Core
open P5.Image
open P5.Color

let preload p5 = loadImage p5 "assets/bricks.jpg"

let draw p5 img =
    tint p5 (RGB(0, 153, 204))
    image p5 img 0 0
    noTint p5
    image p5 img 50 0

let run node = displayWithPreload node preload draw
