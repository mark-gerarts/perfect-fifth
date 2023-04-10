module P5Reference.Image.P5ImageWidth

open P5.Core
open P5.Color
open P5.Shape
open P5.Image
open P5.Rendering

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 (img: P5Image) =
    createCanvas p5 100 100
    image p5 img 0 0

    for i in { 0 .. (img.width - 1) } do
        let c = img.getPixel (i |> float) (img.height / 2 |> float)
        stroke p5 (Values c)
        line p5 i 50 i 100

let run node = displayWithPreload node preload draw
