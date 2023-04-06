module P5Reference.Image.CreateImage1

open P5.Core
open P5.Image
open P5.Color

let draw p5 =
    let img = createImage p5 66 66
    img.loadPixels ()

    for i in seq { 0 .. (img.width - 1) } do
        for j in seq { 0 .. (img.height - 1) } do
            let alpha = (i % img.width) / 2 |> float
            img.setPixel (float i) (float j) (color p5 (RGBA(0, 90, 102, alpha)))

    img.updatePixels ()
    image p5 img 17 17
    image p5 img 34 34

let run node = display node draw
