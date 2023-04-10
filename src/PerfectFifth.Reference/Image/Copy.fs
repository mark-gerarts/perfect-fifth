module P5Reference.Image.Copy

open P5.Core
open P5.Image
open P5.Color
open P5.Shape

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 img =
    backgroundImage p5 img
    copyFrom p5 img 7 22 10 10 35 25 50 50
    stroke p5 (Grayscale 255)
    noFill p5
    square p5 7 22 10

let run node = displayWithPreload node preload draw
