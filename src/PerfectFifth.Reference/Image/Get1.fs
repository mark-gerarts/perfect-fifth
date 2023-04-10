module P5Reference.Image.Get1

open P5.Core
open P5.Image
open P5.Color
open P5.Shape

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 img =
    image p5 img 0 0
    let c = getPixel p5 50 90
    fill p5 (Values c)
    noStroke p5
    square p5 25 25 50

let run node = displayWithPreload node preload draw
