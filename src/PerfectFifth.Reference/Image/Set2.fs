module P5Reference.Image.Set2

open P5.Core
open P5.Shape
open P5.Image
open P5.Environment

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 img =
    let width = width p5 |> float
    let height = height p5 |> float

    setImage p5 0 0 img
    updatePixels p5
    line p5 0 0 width height
    line p5 0 height width 0

let run node = displayWithPreload node preload draw
