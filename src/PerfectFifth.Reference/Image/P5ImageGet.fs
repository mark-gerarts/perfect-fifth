module P5Reference.Image.P5ImageGet

open P5.Core
open P5.Color
open P5.Shape
open P5.Image

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 (img: P5Image) =
    backgroundImage p5 img
    noStroke p5
    let c = img.getPixel 60 90
    fill p5 (Values c)
    rect p5 25 25 50 50

let run node = displayWithPreload node preload draw
