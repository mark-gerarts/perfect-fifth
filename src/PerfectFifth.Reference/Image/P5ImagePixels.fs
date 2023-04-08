module P5Reference.Image.P5ImagePixels

open P5.Core
open P5.Color
open P5.Environment
open P5.Image

let draw p5 =
    let width = width p5
    let height = height p5

    let pink = (RGB(255, 102, 204))
    let img = createImage p5 66 66
    img.loadPixels ()

    for i in { 0..4 .. (4 * (width * height / 2)) } do
        img.pixels[i] <- red p5 pink
        img.pixels[i + 1] <- green p5 pink
        img.pixels[i + 2] <- blue p5 pink
        img.pixels[i + 3] <- alpha p5 pink

    img.updatePixels ()
    image p5 img 17 17

let run node = display node draw
