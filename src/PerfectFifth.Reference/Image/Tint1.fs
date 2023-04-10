module P5Reference.Image.Tint1

open P5.Core
open P5.Image
open P5.Color

let preload p5 = loadImage p5 "assets/laDefense.png"

let draw p5 img =
    image p5 img 0 0
    tint p5 (RGBA(0, 153, 204, 126))
    image p5 img 50 0

let run node = displayWithPreload node preload draw
