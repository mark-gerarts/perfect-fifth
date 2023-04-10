module P5Reference.Image.Image1

open P5.Core
open P5.Image
open P5.Color

let preload p5 = loadImage p5 "assets/laDefense.png"

let draw p5 img =
    background p5 (Grayscale 50)
    imageWithSize p5 img 10 10 50 50

let run node = displayWithPreload node preload draw
